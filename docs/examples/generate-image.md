# Generate Image



This example assumes `using Leonardo;` is in scope and `apiKey` contains your Leonardo API key.

```csharp
using var api = GetAuthorizedClient();

var createResponse = await api.Image.CreateGenerationAsync(
    prompt: "Generate cat");

await Task.Delay(TimeSpan.FromSeconds(15));

var response = await api.Image.GetGenerationByIdAsync(createResponse.SdGenerationJob?.GenerationId ?? throw new InvalidOperationException("GenerationId is null"));

var url = response.GenerationsByPk?.GeneratedImages?.ElementAtOrDefault(0)?.Url;
```