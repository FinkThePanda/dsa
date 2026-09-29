#!/usr/bin/env bash
# Compatibility entry point; PowerShell 7 (pwsh) is required.
set -euo pipefail
script_dir="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
exec pwsh -NoProfile -File "$script_dir/run.ps1" "$@"
