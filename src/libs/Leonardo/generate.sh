#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
curl --fail --silent --show-error -L -o openapi.json https://api-docs-nine-delta.vercel.app/cloud/openapi.json
rm -rf Generated
autosdk generate openapi.json \
  --namespace Leonardo \
  --clientClassName LeonardoClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
