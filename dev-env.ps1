$DotnetRoot = "D:\develop\tools\dotnet"

$env:DOTNET_ROOT = $DotnetRoot
$env:PATH = "$DotnetRoot;$DotnetRoot\tools;$env:PATH"

$env:DOTNET_CLI_TELEMETRY_OPTOUT = "1"
$env:DOTNET_NOLOGO = "1"

Write-Host "Portable .NET configured:" -ForegroundColor Green
dotnet --list-sdks