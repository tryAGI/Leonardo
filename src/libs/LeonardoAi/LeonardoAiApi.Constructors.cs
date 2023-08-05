namespace LeonardoAi;

/// <summary>
/// Class providing methods for API access.
/// </summary>
public partial class LeonardoAiApi
{
    /// <summary>
    /// Sets the selected apiKey as a default header for the HttpClient.
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="httpClient"></param>
    public LeonardoAiApi(string apiKey, HttpClient httpClient) : this(httpClient)
    {
        ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
    }
}
