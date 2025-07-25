
#nullable enable

namespace Leonardo
{
    public partial class VariationClient
    {
        partial void PrepareCreateUniversalUpscalerJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Leonardo.CreateUniversalUpscalerJobRequest request);
        partial void PrepareCreateUniversalUpscalerJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Leonardo.CreateUniversalUpscalerJobRequest request);
        partial void ProcessCreateUniversalUpscalerJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateUniversalUpscalerJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            global::Leonardo.CreateUniversalUpscalerJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateUniversalUpscalerJobArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Leonardo.PathBuilder(
                path: "/variations/universal-upscaler",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateUniversalUpscalerJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateUniversalUpscalerJobResponse(
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
                ProcessCreateUniversalUpscalerJobResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Leonardo.CreateUniversalUpscalerJobResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Leonardo.CreateUniversalUpscalerJobResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="creativityStrength">
        /// The creativity strength of the universal upscaler. Must be between 1 and 10.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="detailContrast">
        /// The detail contrast of the universal upscaler. Must be between 1 and 10. Can only be used with ultraUpscaleStyle.
        /// </param>
        /// <param name="generatedImageId">
        /// The ID of the generated image.
        /// </param>
        /// <param name="initImageId">
        /// The ID of the init image uploaded.
        /// </param>
        /// <param name="prompt">
        /// The prompt for the universal upscaler.
        /// </param>
        /// <param name="similarity">
        /// The similarity of the universal upscaler. Must be between 1 and 10. Can only be used with ultraUpscaleStyle.
        /// </param>
        /// <param name="ultraUpscaleStyle">
        /// The ultra style to upscale images using universal upscaler with. Can not be used with upscalerStyle.
        /// </param>
        /// <param name="upscaleMultiplier">
        /// The upscale multiplier of the universal upscaler. Must be between 1.0 and 2.0.<br/>
        /// Default Value: 1.5
        /// </param>
        /// <param name="upscalerStyle">
        /// The style to upscale images using universal upscaler with. Can not be used with ultraUpscaleStyle.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="variationId">
        /// The ID of the variation image.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            int? creativityStrength = default,
            int? detailContrast = default,
            string? generatedImageId = default,
            string? initImageId = default,
            string? prompt = default,
            int? similarity = default,
            global::Leonardo.UniversalUpscalerUltraStyle? ultraUpscaleStyle = default,
            double? upscaleMultiplier = default,
            global::Leonardo.UniversalUpscalerStyle? upscalerStyle = default,
            string? variationId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Leonardo.CreateUniversalUpscalerJobRequest
            {
                CreativityStrength = creativityStrength,
                DetailContrast = detailContrast,
                GeneratedImageId = generatedImageId,
                InitImageId = initImageId,
                Prompt = prompt,
                Similarity = similarity,
                UltraUpscaleStyle = ultraUpscaleStyle,
                UpscaleMultiplier = upscaleMultiplier,
                UpscalerStyle = upscalerStyle,
                VariationId = variationId,
            };

            return await CreateUniversalUpscalerJobAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}