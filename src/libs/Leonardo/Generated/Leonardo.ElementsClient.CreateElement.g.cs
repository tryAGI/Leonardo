
#nullable enable

namespace Leonardo
{
    public partial class ElementsClient
    {
        partial void PrepareCreateElementArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Leonardo.CreateElementRequest request);
        partial void PrepareCreateElementRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Leonardo.CreateElementRequest request);
        partial void ProcessCreateElementResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateElementResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Train a Custom Element<br/>
        /// This endpoint will train a new custom element.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateElementResponse> CreateElementAsync(
            global::Leonardo.CreateElementRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateElementArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Leonardo.PathBuilder(
                path: "/elements",
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
            PrepareCreateElementRequest(
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
            ProcessCreateElementResponse(
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
                ProcessCreateElementResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::Leonardo.CreateElementResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::Leonardo.CreateElementResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Train a Custom Element<br/>
        /// This endpoint will train a new custom element.
        /// </summary>
        /// <param name="name">
        /// The name of the element.<br/>
        /// Default Value: placeholder
        /// </param>
        /// <param name="description">
        /// The description of the element.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to train the element on.
        /// </param>
        /// <param name="instancePrompt">
        /// Use a word that is closely related to what you're training that isn't too common. For example, instead of 'dog,' try something unique like 'jackthedog' or 'magicdonut'. Required for all non-FLUX_DEV models and FLUX_DEV Character model training.
        /// </param>
        /// <param name="loraFocus">
        /// The category determines how the element will be trained. Options are 'General' | 'Character' | 'Style' | 'Object'. FLUX_DEV doesn't support General category.
        /// </param>
        /// <param name="trainTextEncoder">
        /// Whether or not encode the train text.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="resolution">
        /// The resolution for training. Must be 1024.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="sdVersion">
        /// The base version to use if not using a custom model.<br/>
        /// Default Value: FLUX_DEV
        /// </param>
        /// <param name="numTrainEpochs">
        /// The number of times the entire training dataset is passed through the element.&lt;table&gt;&lt;tr&gt;&lt;th&gt;Model Type&lt;/th&gt;&lt;th&gt;Lora Focus&lt;/th&gt;&lt;th&gt;Min&lt;/th&gt;&lt;th&gt;Max&lt;/th&gt;&lt;th&gt;Default&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Default&lt;/td&gt;&lt;td&gt;General | Style | Character | Object&lt;/td&gt;&lt;td&gt;1&lt;/td&gt;&lt;td&gt;250&lt;/td&gt;&lt;td&gt;100&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td rowspan='3'&gt;FLUX_DEV&lt;/td&gt;&lt;td&gt;Style&lt;/td&gt;&lt;td&gt;30&lt;/td&gt;&lt;td&gt;120&lt;/td&gt;&lt;td&gt;60&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Object&lt;/td&gt;&lt;td&gt;120&lt;/td&gt;&lt;td&gt;220&lt;/td&gt;&lt;td&gt;140&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Character&lt;/td&gt;&lt;td&gt;100&lt;/td&gt;&lt;td&gt;200&lt;/td&gt;&lt;td&gt;135&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;General&lt;/td&gt;&lt;td colspan='3'&gt;NA&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </param>
        /// <param name="learningRate">
        /// The speed at which the model learns during training.&lt;table&gt;&lt;tr&gt;&lt;th&gt;Model Type&lt;/th&gt;&lt;th&gt;Lora Focus&lt;/th&gt;&lt;th&gt;Min&lt;/th&gt;&lt;th&gt;Max&lt;/th&gt;&lt;th&gt;Default&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Default&lt;/td&gt;&lt;td&gt;General | Style | Character | Object&lt;/td&gt;&lt;td&gt;0.00000001&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.000001&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td rowspan='3'&gt;FLUX_DEV&lt;/td&gt;&lt;td&gt;Style&lt;/td&gt;&lt;td&gt;0.000001&lt;/td&gt;&lt;td&gt;0.00003&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Object&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.001&lt;/td&gt;&lt;td&gt;0.0004&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Character&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.001&lt;/td&gt;&lt;td&gt;0.0005&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;General&lt;/td&gt;&lt;td colspan='3'&gt;NA&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateElementResponse> CreateElementAsync(
            string name,
            string datasetId,
            string loraFocus,
            bool trainTextEncoder,
            global::Leonardo.CreateElementRequestSdVersion sdVersion,
            int numTrainEpochs,
            double learningRate,
            string? description = default,
            string? instancePrompt = default,
            int? resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Leonardo.CreateElementRequest
            {
                Name = name,
                Description = description,
                DatasetId = datasetId,
                InstancePrompt = instancePrompt,
                LoraFocus = loraFocus,
                TrainTextEncoder = trainTextEncoder,
                Resolution = resolution,
                SdVersion = sdVersion,
                NumTrainEpochs = numTrainEpochs,
                LearningRate = learningRate,
            };

            return await CreateElementAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}