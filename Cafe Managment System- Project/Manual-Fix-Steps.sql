-- SIMPLE MANUAL FIX - Do this step by step in SSMS

-- Step 1: Check what user exists
USE ManagementSystem;
GO

SELECT 
    dp.name AS DatabaseUser,
    sp.name AS ServerLogin,
    dp.type_desc AS UserType
FROM sys.database_principals dp
LEFT JOIN sys.server_principals sp ON dp.sid = sp.sid
WHERE sp.name = 'DESKTOP-UHPED7U\ADMIN' OR dp.name LIKE '%ADMIN%';
GO

-- Step 2: If you see a user above, note its name and run:
-- DROP USER [the_user_name_from_step_1];
-- GO

-- Step 3: Then create the user:
-- CREATE USER [DESKTOP-UHPED7U\ADMIN] FOR LOGIN [DESKTOP-UHPED7U\ADMIN];
-- GO

-- Step 4: Grant permissions:
-- ALTER ROLE db_owner ADD MEMBER [DESKTOP-UHPED7U\ADMIN];
-- GO
