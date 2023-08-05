# LeonardoAi

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.LeonardoAi)](https://www.nuget.org/packages/tryAGI.LeonardoAi/)
[![dotnet](https://github.com/tryAGI/LeonardoAi/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/LeonardoAi/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/LeonardoAi)](https://github.com/tryAGI/LeonardoAi/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

Generated C# SDK based on LeonardoAi OpenAPI specification using NSwag.  

### Usage
```csharp
using LeonardoAi;

using var client = new HttpClient();
var api = new LeonardoAiApi(apiKey, client);
var createResponse = await api.CreateGenerationAsync(new Body
{
    Prompt = "Generate cat",
});

await Task.Delay(TimeSpan.FromSeconds(15));

var response = await api.GetGenerationByIdAsync(createResponse.SdGenerationJob.GenerationId);
var url = response.Generations_by_pk.Generated_images.ElementAt(0).Url;
```

## Support

Priority place for bugs: https://github.com/tryAGI/LeonardoAi/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/LeonardoAi/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  