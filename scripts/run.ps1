param(
    [Parameter(Position = 0)][string]$Exercise = 'hello-world',
    [switch]$List,
    [switch]$BuildOnly
)
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
$catalog = Get-Content -LiteralPath (Join-Path $repoRoot 'challenges/catalog.json') -Raw | ConvertFrom-Json
if ($List) { $catalog | Format-Table tier, id; exit 0 }
$entry = $catalog | Where-Object { $_.id -eq $Exercise -or $_.path -eq $Exercise }
if (-not $entry) { Write-Error "Unknown exercise '$Exercise'. Run ./scripts/run.ps1 -List to see available IDs."; exit 1 }
$project = Join-Path $repoRoot 'runner/Runner.csproj'
# Build explicitly: MSBuild properties select this exercise's source files.
# Run the resulting DLL only after a successful build, avoiding a second build.
& dotnet build $project "-p:Challenge=$($entry.path)" --nologo --verbosity quiet
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
if ($BuildOnly) { exit 0 }
& dotnet (Join-Path $repoRoot 'runner/bin/Debug/net10.0/Runner.dll')
exit $LASTEXITCODE
