
#nullable enable

namespace Leonardo
{
    public partial class MotionClient
    {
        partial void PrepareCreateTextToVideoGenerationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Leonardo.CreateTextToVideoGenerationRequest request);
        partial void PrepareCreateTextToVideoGenerationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Leonardo.CreateTextToVideoGenerationRequest request);
        partial void ProcessCreateTextToVideoGenerationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextToVideoGenerationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a video generation from a text prompt<br/>
        /// This endpoint will generate a video using a text prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateTextToVideoGenerationResponse> CreateTextToVideoGenerationAsync(
            global::Leonardo.CreateTextToVideoGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextToVideoGenerationArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Leonardo.PathBuilder(
                path: "/generations-text-to-video",
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
            PrepareCreateTextToVideoGenerationRequest(
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
            ProcessCreateTextToVideoGenerationResponse(
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
                ProcessCreateTextToVideoGenerationResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Leonardo.CreateTextToVideoGenerationResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Leonardo.CreateTextToVideoGenerationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create a video generation from a text prompt<br/>
        /// This endpoint will generate a video using a text prompt
        /// </summary>
        /// <param name="prompt">
        /// The prompt used to generate video
        /// </param>
        /// <param name="resolution">
        /// The resolution of the video. MOTION2 and MOTION2FAST supports RESOLUTION_480 and RESOLUTION_720 and defaults to RESOLUTION_480 if not specified. VEO3 and VEO3FAST supports RESOLUTION_720 and RESOLUTION_1080 and defaults to RESOLUTION_720 if not specified. KLING2_5 supports RESOLUTION_1080.
        /// </param>
        /// <param name="model">
        /// The model to use for the video generation. Defaults to MOTION2 if not specified.<br/>
        /// Default Value: MOTION2
        /// </param>
        /// <param name="frameInterpolation">
        /// Smoothly blend frames for fluid video transitions using Interpolation.
        /// </param>
        /// <param name="isPublic">
        /// Whether the generation is public or not
        /// </param>
        /// <param name="seed">
        /// Apply a fixed seed to maintain consistency across generation sets. The maximum seed value is 2147483637 for Motion 2.0 and 4294967293 for Veo3.
        /// </param>
        /// <param name="negativePrompt">
        /// The negative prompt used for the video generation.
        /// </param>
        /// <param name="promptEnhance">
        /// Whether to enhance the prompt.
        /// </param>
        /// <param name="promptEnhanceInstruction">
        /// A natural language instruction used to modify the main prompt. For example, 'make it cinematic', 'add a rainbow', or 'change the subject to a cat'.
        /// </param>
        /// <param name="styleIds">
        /// Predefined styles to enhance the prompt. This accepts a list of style uuids.
        /// </param>
        /// <param name="height">
        /// Height of the output video. Acceptable values vary based on model
        /// </param>
        /// <param name="width">
        /// Width of the output video. Acceptable values vary based on model
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds. Defaults to 8 seconds if not specified. Allowed values: 4, 6, or 8. Supported on models VEO3 and VEO3FAST.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="elements">
        /// An array of elements/loras objects that will be applied sequentially to the output. Elements are only supported for Motion2.0 generations. 
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateTextToVideoGenerationResponse> CreateTextToVideoGenerationAsync(
            string prompt,
            global::Leonardo.CreateTextToVideoGenerationRequestResolution? resolution = default,
            global::Leonardo.CreateTextToVideoGenerationRequestModel? model = default,
            bool? frameInterpolation = default,
            bool? isPublic = default,
            int? seed = default,
            string? negativePrompt = default,
            bool? promptEnhance = default,
            string? promptEnhanceInstruction = default,
            global::System.Collections.Generic.IList<string>? styleIds = default,
            int? height = default,
            int? width = default,
            int? duration = default,
            global::System.Collections.Generic.IList<global::Leonardo.ElementInput>? elements = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Leonardo.CreateTextToVideoGenerationRequest
            {
                Prompt = prompt,
                Resolution = resolution,
                Model = model,
                FrameInterpolation = frameInterpolation,
                IsPublic = isPublic,
                Seed = seed,
                NegativePrompt = negativePrompt,
                PromptEnhance = promptEnhance,
                PromptEnhanceInstruction = promptEnhanceInstruction,
                StyleIds = styleIds,
                Height = height,
                Width = width,
                Duration = duration,
                Elements = elements,
            };

            return await CreateTextToVideoGenerationAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}