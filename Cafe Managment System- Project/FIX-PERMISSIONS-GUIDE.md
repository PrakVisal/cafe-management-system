# Fix Database Permissions - Quick Guide

## Problem
Error 4060: Login failed for user 'DESKTOP-UHPED7U\ADMIN'
- The user can connect to SQL Server
- But doesn't have permission to access the ManagementSystem database

## Solution

### Option 1: Run the SQL Script (Recommended)

1. **Open SQL Server Management Studio (SSMS)**
2. **Connect to server:** `DESKTOP-UHPED7U`
   - Use **Windows Authentication** or **SQL Server Authentication** (as admin)
3. **Open New Query** (Ctrl+N)
4. **Open the file:** `Fix-Database-Permissions.sql`
5. **Execute the script** (Press F5)
6. **Verify:** You should see "Permissions granted successfully!"

### Option 2: Manual Fix in SSMS

1. **Open SSMS** and connect to `DESKTOP-UHPED7U`
2. **Expand:** Security → Logins
3. **Right-click:** `DESKTOP-UHPED7U\ADMIN` → Properties
   - If the login doesn't exist:
     - Right-click **Logins** → New Login
     - Search for: `DESKTOP-UHPED7U\ADMIN`
     - Click OK
4. **Go to:** User Mapping page
5. **Check:** `ManagementSystem` database
6. **Select role:** `db_owner` (or `db_datareader`, `db_datawriter`, `db_ddladmin`)
7. **Click OK**

### Option 3: Quick SQL Command

Run this in SSMS (as admin):

```sql
USE ManagementSystem;
GO

-- Create user if doesn't exist
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'DESKTOP-UHPED7U\ADMIN')
    CREATE USER [DESKTOP-UHPED7U\ADMIN] FOR LOGIN [DESKTOP-UHPED7U\ADMIN];
GO

-- Grant full access
ALTER ROLE db_owner ADD MEMBER [DESKTOP-UHPED7U\ADMIN];
GO
```

## Verify It Works

After running the fix, test the connection:

```sql
USE ManagementSystem;
EXECUTE AS USER = 'DESKTOP-UHPED7U\ADMIN';
SELECT USER_NAME();
REVERT;
```

If this works, your application should now be able to connect!

## Still Having Issues?

If you still get errors:
1. Make sure you're running SSMS **as Administrator**
2. Check if the database exists: `SELECT name FROM sys.databases WHERE name = 'ManagementSystem'`
3. Try connecting as a different admin user first, then grant permissions
4. Check Windows Authentication is enabled in SQL Server
