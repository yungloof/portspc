# Script para compilar o executavel nativo do PortsPC Launcher (PortsPC.exe)
# Utiliza o compilador nativo csc.exe do .NET Framework ja presente em qualquer Windows 10/11.

$ErrorActionPreference = "Stop"

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$RepoRoot = Split-Path -Parent $ScriptDir
$SourceFile = Join-Path $RepoRoot "src\PortsPC.cs"
$OutputFile = Join-Path $RepoRoot "PortsPC.exe"

$CscPath = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe"
if (-not (Test-Path $CscPath)) {
    $CscPath = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe"
}

if (-not (Test-Path $CscPath)) {
    Write-Host "[ERRO] Compilador csc.exe do .NET Framework nao encontrado." -ForegroundColor Red
    exit 1
}

Write-Host "Compilando PortsPC.exe a partir de $SourceFile ..." -ForegroundColor Cyan

$WpfLib = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\WPF"
if (-not (Test-Path $WpfLib)) {
    $WpfLib = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF"
}

$Args = @(
    "/target:winexe",
    "/optimize+",
    "/lib:$WpfLib",
    "/r:System.Xaml.dll",
    "/r:PresentationCore.dll",
    "/r:PresentationFramework.dll",
    "/r:WindowsBase.dll",
    "/r:System.Web.Extensions.dll",
    "/r:System.IO.Compression.FileSystem.dll",
    "/r:System.IO.Compression.dll",
    "/out:$OutputFile",
    $SourceFile
)

& $CscPath $Args

if (Test-Path $OutputFile) {
    $SizeKB = [math]::Round((Get-Item $OutputFile).Length / 1KB, 2)
    Write-Host "[SUCESSO] PortsPC.exe gerado com sucesso ($SizeKB KB) em: $OutputFile" -ForegroundColor Green
} else {
    Write-Host "[ERRO] Falha ao gerar PortsPC.exe" -ForegroundColor Red
    exit 1
}
