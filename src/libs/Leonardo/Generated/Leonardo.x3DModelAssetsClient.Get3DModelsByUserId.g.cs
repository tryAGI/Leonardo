
#nullable enable

namespace Leonardo
{
    public partial class x3DModelAssetsClient
    {
        partial void PrepareGet3DModelsByUserIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref string userId,
            global::Leonardo.Get3DModelsByUserIdRequest request);
        partial void PrepareGet3DModelsByUserIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            string userId,
            global::Leonardo.Get3DModelsByUserIdRequest request);
        partial void ProcessGet3DModelsByUserIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGet3DModelsByUserIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get 3D models by user ID<br/>
        /// This endpoint returns all 3D models by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.Get3DModelsByUserIdResponse> Get3DModelsByUserIdAsync(
            string userId,
            global::Leonardo.Get3DModelsByUserIdRequest request,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGet3DModelsByUserIdArguments(
                httpClient: HttpClient,
                offset: ref offset,
                limit: ref limit,
                userId: ref userId,
                request: request);

            var __pathBuilder = new global::Leonardo.PathBuilder(
                path: $"/models-3d/user/{userId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGet3DModelsByUserIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                offset: offset,
                limit: limit,
                userId: userId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGet3DModelsByUserIdResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGet3DModelsByUserIdResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Leonardo.Get3DModelsByUserIdResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Leonardo.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Leonardo.Get3DModelsByUserIdResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Leonardo.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Get 3D models by user ID<br/>
        /// This endpoint returns all 3D models by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.Get3DModelsByUserIdResponse> Get3DModelsByUserIdAsync(
            string userId,
            int? offset = default,
            int? limit = default,
            string? requestUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Leonardo.Get3DModelsByUserIdRequest
            {
                UserId = requestUserId,
            };

            return await Get3DModelsByUserIdAsync(
                offset: offset,
                limit: limit,
                userId: userId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}