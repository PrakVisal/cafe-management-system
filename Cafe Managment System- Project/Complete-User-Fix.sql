-- COMPLETE FIX: Remove conflicting user and recreate properly
-- Run this in SSMS - it will fix the user mapping issue

USE ManagementSystem;
GO

-- Step 1: Check what user exists for this login
PRINT 'Checking for existing users mapped to DESKTOP-UHPED7U\ADMIN...';
GO

DECLARE @existingUser NVARCHAR(128);
DECLARE @sql NVARCHAR(MAX);

-- Find the user that's mapped to this login
SELECT @existingUser = dp.name
FROM sys.database_principals dp
JOIN sys.server_principals sp ON dp.sid = sp.sid
WHERE sp.name = 'DESKTOP-UHPED7U\ADMIN' AND dp.type = 'S';

IF @existingUser IS NOT NULL
BEGIN
    PRINT 'Found existing user: ' + @existingUser;
    
    -- Remove from all roles first
    DECLARE @roleName NVARCHAR(128);
    DECLARE role_cursor CURSOR FOR
    SELECT r.name
    FROM sys.database_role_members rm
    JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id
    JOIN sys.database_principals m ON rm.member_principal_id = m.principal_id
    WHERE m.name = @existingUser;
    
    OPEN role_cursor;
    FETCH NEXT FROM role_cursor INTO @roleName;
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = 'ALTER ROLE [' + @roleName + '] DROP MEMBER [' + @existingUser + ']';
        EXEC sp_executesql @sql;
        PRINT 'Removed from role: ' + @roleName;
        FETCH NEXT FROM role_cursor INTO @roleName;
    END;
    
    CLOSE role_cursor;
    DEALLOCATE role_cursor;
    
    -- Now drop the user
    SET @sql = 'DROP USER [' + @existingUser + ']';
    EXEC sp_executesql @sql;
    PRINT 'Dropped user: ' + @existingUser;
END
ELSE
BEGIN
    PRINT 'No existing user found.';
END
GO

-- Step 2: Wait a moment for cleanup
WAITFOR DELAY '00:00:01';
GO

-- Step 3: Create the user with the correct name
PRINT 'Creating user DESKTOP-UHPED7U\ADMIN...';
GO

-- Check if user already exists with correct name
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    PRINT 'User already exists with correct name.';
END
ELSE
BEGIN
    BEGIN TRY
        CREATE USER [DESKTOP-UHPED7U\ADMIN] FOR LOGIN [DESKTOP-UHPED7U\ADMIN];
        PRINT 'User created successfully.';
    END TRY
    BEGIN CATCH
        PRINT 'Error creating user: ' + ERROR_MESSAGE();
        -- Try alternative: create with default schema
        BEGIN TRY
            CREATE USER [DESKTOP-UHPED7U\ADMIN] FOR LOGIN [DESKTOP-UHPED7U\ADMIN] WITH DEFAULT_SCHEMA = [dbo];
            PRINT 'User created successfully with default schema.';
        END TRY
        BEGIN CATCH
            PRINT 'Failed to create user: ' + ERROR_MESSAGE();
        END CATCH
    END CATCH
END
GO

-- Step 4: Grant permissions
PRINT 'Granting permissions...';
GO

IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    -- Remove from any existing roles first
    ALTER ROLE db_owner DROP MEMBER [DESKTOP-UHPED7U\ADMIN];
    
    -- Add to db_owner
    ALTER ROLE db_owner ADD MEMBER [DESKTOP-UHPED7U\ADMIN];
    PRINT 'Permissions granted (db_owner role).';
END
ELSE
BEGIN
    PRINT 'WARNING: User does not exist, cannot grant permissions.';
END
GO

-- Step 5: Final verification
PRINT '';
PRINT '========================================';
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    DECLARE @hasRole BIT = 0;
    SELECT @hasRole = 1
    FROM sys.database_role_members rm
    JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id
    JOIN sys.database_principals m ON rm.member_principal_id = m.principal_id
    WHERE m.name = 'DESKTOP-UHPED7U\ADMIN' AND r.name = 'db_owner';
    
    IF @hasRole = 1
    BEGIN
        PRINT '✓ SUCCESS! User is properly configured.';
        PRINT 'User: DESKTOP-UHPED7U\ADMIN';
        PRINT 'Database: ManagementSystem';
        PRINT 'Role: db_owner';
    END
    ELSE
    BEGIN
        PRINT '⚠ User exists but role assignment failed.';
    END
END
ELSE
BEGIN
    PRINT '✗ FAILED: User was not created.';
END
PRINT '========================================';
GO
