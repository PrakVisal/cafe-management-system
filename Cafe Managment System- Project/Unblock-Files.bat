@echo off
echo Removing "Mark of the Web" from all project files...
echo.

cd /d "%~dp0RMS-Project"

for /r %%f in (*.*) do (
    if exist "%%f:Zone.Identifier" (
        echo Unblocking: %%~nxf
        del /f /q "%%f:Zone.Identifier" >nul 2>&1
    )
)

echo.
echo Done! All files have been unblocked.
echo You can now build the project in Visual Studio.
echo.
pause