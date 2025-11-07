-- SIMPLE FIX: Clean and Recreate User
-- Run this if you're getting "login already has an account" error

USE ManagementSystem;
GO

-- Remove ALL users mapped to this login (regardless of name)
DECLARE @sql NVARCHAR(MAX);
DECLARE @userName NVARCHAR(128);

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
    PRINT 'Removed: ' + @userName;
    FETCH NEXT FROM user_cursor INTO @userName;
END;

CLOSE user_cursor;
DEALLOCATE user_cursor;
GO

-- Now create the user with the correct name
CREATE USER [DESKTOP-UHPED7U\ADMIN] FOR LOGIN [DESKTOP-UHPED7U\ADMIN];
GO

-- Grant permissions
ALTER ROLE db_owner ADD MEMBER [DESKTOP-UHPED7U\ADMIN];
GO

PRINT 'Done! Try your application now.';
GO
