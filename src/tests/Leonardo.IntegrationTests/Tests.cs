namespace Leonardo.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static LeonardoClient GetAuthorizedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LEONARDO_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LEONARDO_API_KEY environment variable is not found.");

        var api = new LeonardoClient(apiKey);

        return api;
    }
}