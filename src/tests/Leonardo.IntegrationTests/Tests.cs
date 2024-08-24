namespace Leonardo.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static LeonardoApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LEONARDO_API_KEY") ??
            throw new AssertInconclusiveException("LEONARDO_API_KEY environment variable is not found.");

        var api = new LeonardoApi(apiKey);

        return api;
    }
}