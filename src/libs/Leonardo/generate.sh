dotnet tool install --global openapigenerator.cli --prerelease
curl -o openapi.yaml https://api-docs-nine-delta.vercel.app/cloud/openapi.json
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi
rm -rf Generated
oag generate openapi.yaml \
  --namespace Leonardo \
  --clientClassName LeonardoApi \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations