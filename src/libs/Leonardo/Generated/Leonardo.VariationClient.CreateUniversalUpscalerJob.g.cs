
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            global::Leonardo.CreateUniversalUpscalerJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateUniversalUpscalerJobArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/variations/universal-upscaler",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateUniversalUpscalerJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateUniversalUpscalerJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateUniversalUpscalerJobResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Leonardo.CreateUniversalUpscalerJobResponse), JsonSerializerContext) as global::Leonardo.CreateUniversalUpscalerJobResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
            int? creativityStrength = 5,
            int? detailContrast = default,
            string? generatedImageId = default,
            string? initImageId = default,
            string? prompt = default,
            int? similarity = default,
            global::Leonardo.UniversalUpscalerUltraStyle? ultraUpscaleStyle = default,
            double? upscaleMultiplier = 1.5,
            global::Leonardo.UniversalUpscalerStyle? upscalerStyle = global::Leonardo.UniversalUpscalerStyle.GENERAL,
            string? variationId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Leonardo.CreateUniversalUpscalerJobRequest
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
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}