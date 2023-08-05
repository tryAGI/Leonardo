using LeonardoAi;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LEONARDOAI_API_KEY") ??
            throw new AssertInconclusiveException("LEONARDOAI_API_KEY environment variable is not found.");

        using var client = new HttpClient();
        var api = new LeonardoAiApi(apiKey, client);
        var createResponse = await api.CreateGenerationAsync(new Body
        {
            Prompt = "Generate cat",
        });

        await Task.Delay(TimeSpan.FromSeconds(15));
        
        var response = await api.GetGenerationByIdAsync(createResponse.SdGenerationJob?.GenerationId ?? throw new InvalidOperationException("GenerationId is null"));
        
        response.Generations_by_pk?.Generated_images?.ElementAtOrDefault(0)?.Url.Should().NotBeNullOrEmpty();
    }
}