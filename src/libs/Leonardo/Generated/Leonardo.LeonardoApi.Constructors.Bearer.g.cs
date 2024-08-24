
#nullable enable

namespace Leonardo
{
    public sealed partial class LeonardoApi
    {
        /// <inheritdoc cref="LeonardoApi(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public LeonardoApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}