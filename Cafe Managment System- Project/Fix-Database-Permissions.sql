-- Fix Database Permissions for User: DESKTOP-UHPED7U\ADMIN
-- Run this script in SQL Server Management Studio (SSMS)
-- Connect to server: DESKTOP-UHPED7U
-- Make sure you're connected as a user with admin rights (like 'sa' or another admin)

USE master;
GO

-- Check if the database exists
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ManagementSystem')
BEGIN
    PRINT 'ERROR: Database ManagementSystem does not exist!';
    PRINT 'Please run RMS Project.sql first to create the database.';
    RETURN;
END
GO

-- Step 1: Create login at server level (if it doesn't exist)
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    PRINT 'Creating login for DESKTOP-UHPED7U\ADMIN at server level...';
    CREATE LOGIN [DESKTOP-UHPED7U\ADMIN] FROM WINDOWS;
    PRINT 'Login created successfully.';
END
ELSE
BEGIN
    PRINT 'Login already exists at server level.';
END
GO

-- Step 2: Switch to ManagementSystem database
USE ManagementSystem;
GO

-- Step 3: Drop user if it exists (to recreate it properly)
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    PRINT 'Removing existing user from database...';
    DROP USER [DESKTOP-UHPED7U\ADMIN];
    PRINT 'Existing user removed.';
END
GO

-- Step 4: Create user in the database
PRINT 'Creating user in ManagementSystem database...';
CREATE USER [DESKTOP-UHPED7U\ADMIN] FOR LOGIN [DESKTOP-UHPED7U\ADMIN];
PRINT 'User created successfully.';
GO

-- Step 5: Grant db_owner role (full access to the database)
PRINT 'Granting db_owner role...';
ALTER ROLE db_owner ADD MEMBER [DESKTOP-UHPED7U\ADMIN];
PRINT 'Role granted successfully.';
GO

-- Step 6: Verify the setup
PRINT '';
PRINT 'Verifying user setup...';
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
BEGIN
    DECLARE @roleName NVARCHAR(128);
    SELECT @roleName = r.name
    FROM sys.database_role_members rm
    JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id
    JOIN sys.database_principals m ON rm.member_principal_id = m.principal_id
    WHERE m.name = 'DESKTOP-UHPED7U\ADMIN' AND r.name = 'db_owner';
    
    IF @roleName IS NOT NULL
    BEGIN
        PRINT '✓ User exists and has db_owner role.';
    END
    ELSE
    BEGIN
        PRINT '⚠ User exists but role assignment may have failed.';
    END
END
ELSE
BEGIN
    PRINT '✗ User was not created successfully.';
END
GO

PRINT '';
PRINT '========================================';
PRINT 'Setup Complete!';
PRINT 'User: DESKTOP-UHPED7U\ADMIN';
PRINT 'Database: ManagementSystem';
PRINT 'Role: db_owner (full access)';
PRINT '========================================';
PRINT '';
PRINT 'You can now try connecting from the application.';
GO
