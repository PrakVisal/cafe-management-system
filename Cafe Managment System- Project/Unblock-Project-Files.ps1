# Unblock all files in the RMS-Project folder
# Right-click this file and select "Run with PowerShell"

$ErrorActionPreference = "SilentlyContinue"

$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path
$projectPath = Join-Path $scriptPath "Cafe Managment System- Project\RMS-Project"

Write-Host "Unblocking files in: $projectPath" -ForegroundColor Cyan
Write-Host ""

if (Test-Path $projectPath) {
    $files = Get-ChildItem -Path $projectPath -Recurse -File
    $unblocked = 0
    
    foreach ($file in $files) {
        $zoneFile = $file.FullName + ":Zone.Identifier"
        if (Test-Path $zoneFile) {
            Remove-Item $zoneFile -Force
            $unblocked++
            Write-Host "Unblocked: $($file.Name)" -ForegroundColor Green
        }
    }
    
    Write-Host ""
    Write-Host "Done! Unblocked $unblocked file(s)." -ForegroundColor Green
    Write-Host "You can now build the project in Visual Studio." -ForegroundColor Green
} else {
    Write-Host "Error: Project path not found: $projectPath" -ForegroundColor Red
}

Write-Host ""
Read-Host "Press Enter to exit"