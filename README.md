# Leonardo

[![Nuget package](https://img.shields.io/nuget/vpre/LeonardoAI](https://www.nuget.org/packages/LeonardoAI/)
[![dotnet](https://github.com/tryAGI/Leonardo/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Leonardo/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Leonardo)](https://github.com/tryAGI/Leonardo/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAPI specification](https://api-docs-nine-delta.vercel.app/cloud/openapi.json) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Leonardo;

using var api = new LeonardoApi(apiKey);

var createResponse = await api.Image.CreateGenerationAsync(
    prompt: "Generate cat");

createResponse.SdGenerationJob.Should().NotBeNull();

await Task.Delay(TimeSpan.FromSeconds(15));

var response = await api.Image.GetGenerationByIdAsync(createResponse.SdGenerationJob?.GenerationId ?? throw new InvalidOperationException("GenerationId is null"));

var url = response.GenerationsByPk?.GeneratedImages?.ElementAtOrDefault(0)?.Url;
```

## Support

Priority place for bugs: https://github.com/tryAGI/Leonardo/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Leonardo/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).