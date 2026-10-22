@echo off
chcp 65001 >nul
cd /d "%~dp0"
if exist "%~dp0PortsPC.exe" (
    start "" "%~dp0PortsPC.exe"
    exit /b
)
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0scripts\portspc.ps1"
