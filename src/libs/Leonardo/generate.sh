#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api-docs-nine-delta.vercel.app/cloud/openapi.json
install_autosdk_cli
fetch_spec --fail --silent --show-error -L -o openapi.json https://api-docs-nine-delta.vercel.app/cloud/openapi.json
rm -rf Generated
autosdk generate openapi.json \
  --namespace Leonardo \
  --clientClassName LeonardoClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
