dotnet tool install --global autosdk.cli --prerelease
curl -o openapi.yaml https://api-docs-nine-delta.vercel.app/cloud/openapi.json
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Leonardo \
  --clientClassName LeonardoClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
