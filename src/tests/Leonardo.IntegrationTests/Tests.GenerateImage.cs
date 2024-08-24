namespace Leonardo.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImage()
    {
        using var api = GetAuthorizedApi();
        
        var createResponse = await api.Image.CreateGenerationAsync(
            prompt: "Generate cat");
        
        createResponse.SdGenerationJob.Should().NotBeNull();
        
        await Task.Delay(TimeSpan.FromSeconds(15));
        
        var response = await api.Image.GetGenerationByIdAsync(createResponse.SdGenerationJob?.GenerationId ?? throw new InvalidOperationException("GenerationId is null"));

        var url = response.GenerationsByPk?.GeneratedImages?.ElementAtOrDefault(0)?.Url;
        url.Should().NotBeNullOrEmpty();
    }
}