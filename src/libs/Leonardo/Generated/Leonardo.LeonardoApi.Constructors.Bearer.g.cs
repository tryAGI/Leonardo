
#nullable enable

namespace Leonardo
{
    public sealed partial class LeonardoApi
    {
        /// <inheritdoc cref="LeonardoApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::Leonardo.EndPointAuthorization}?, bool)"/>
        public LeonardoApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Leonardo.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}