-- Quick Fix: Add User to ManagementSystem Database
-- Run this in SSMS after creating the database

USE ManagementSystem;
GO

-- Step 1: Create login at server level if it doesn't exist
USE master;
GO

IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    CREATE LOGIN [DESKTOP-UHPED7U\ADMIN] FROM WINDOWS;
    PRINT 'Login created at server level.';
END
ELSE
BEGIN
    PRINT 'Login already exists at server level.';
END
GO

-- Step 2: Switch back to ManagementSystem database
USE ManagementSystem;
GO

-- Step 3: Find and remove ALL existing users mapped to this login
DECLARE @sql NVARCHAR(MAX);
DECLARE @userName NVARCHAR(128);

-- Find all users in this database that are mapped to the login
DECLARE user_cursor CURSOR FOR
SELECT dp.name
FROM sys.database_principals dp
JOIN sys.server_principals sp ON dp.sid = sp.sid
WHERE sp.name = 'DESKTOP-UHPED7U\ADMIN' AND dp.type = 'S';

OPEN user_cursor;
FETCH NEXT FROM user_cursor INTO @userName;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @sql = 'DROP USER [' + @userName + ']';
    EXEC sp_executesql @sql;
    PRINT 'Removed existing user: ' + @userName;
    FETCH NEXT FROM user_cursor INTO @userName;
END;

CLOSE user_cursor;
DEALLOCATE user_cursor;
GO

-- Step 4: Create the user fresh
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    CREATE USER [DESKTOP-UHPED7U\ADMIN] FOR LOGIN [DESKTOP-UHPED7U\ADMIN];
    PRINT 'User created successfully.';
END
ELSE
BEGIN
    PRINT 'User already exists.';
END
GO

-- Step 5: Grant full access (remove from other roles first, then add to db_owner)
ALTER ROLE db_owner ADD MEMBER [DESKTOP-UHPED7U\ADMIN];
PRINT 'Permissions granted (db_owner role).';
GO

-- Step 6: Verify
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    PRINT '';
    PRINT '========================================';
    PRINT '✓ User setup complete!';
    PRINT 'User: DESKTOP-UHPED7U\ADMIN';
    PRINT 'Database: ManagementSystem';
    PRINT 'Role: db_owner';
    PRINT '========================================';
END
ELSE
BEGIN
    PRINT '✗ Warning: User may not have been created properly.';
END
GO
