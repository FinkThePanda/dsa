param([switch]$BuildOnly)
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
$catalog = Get-Content -LiteralPath (Join-Path $repoRoot 'challenges/catalog.json') -Raw | ConvertFrom-Json
$failed = @()
foreach ($entry in $catalog) {
    Write-Host "Checking $($entry.id)"
    & pwsh -NoProfile -File (Join-Path $PSScriptRoot 'run.ps1') $entry.id -BuildOnly:$BuildOnly
    if ($LASTEXITCODE -ne 0) { $failed += $entry.id }
}
if ($failed.Count -gt 0) { Write-Host "Incomplete or failed: $($failed -join ', ')"; exit 1 }
Write-Host "All exercises checked successfully."
exit 0
