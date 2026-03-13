#!/usr/bin/env bash
set -euo pipefail

AUTO_SDK_VERSION="0.29.1-dev.28"

if dotnet tool list --global | grep -q '^autosdk\.cli '; then
  dotnet tool update --global autosdk.cli --version "$AUTO_SDK_VERSION"
else
  dotnet tool install --global autosdk.cli --version "$AUTO_SDK_VERSION"
fi
curl -o openapi.yaml https://api-docs-nine-delta.vercel.app/cloud/openapi.json
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Leonardo \
  --clientClassName LeonardoApi \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
