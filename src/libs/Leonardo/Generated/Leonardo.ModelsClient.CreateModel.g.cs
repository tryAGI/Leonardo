
#nullable enable

namespace Leonardo
{
    public partial class ModelsClient
    {
        partial void PrepareCreateModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Leonardo.CreateModelRequest request);
        partial void PrepareCreateModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Leonardo.CreateModelRequest request);
        partial void ProcessCreateModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Train a Custom Model<br/>
        /// This endpoint will train a new custom model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateModelResponse> CreateModelAsync(
            global::Leonardo.CreateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateModelArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/models",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareCreateModelRequest(
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
            ProcessCreateModelResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateModelResponseContent(
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
                    global::Leonardo.CreateModelResponse.FromJson(__content, JsonSerializerContext) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Leonardo.CreateModelResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Train a Custom Model<br/>
        /// This endpoint will train a new custom model
        /// </summary>
        /// <param name="name">
        /// The name of the model.
        /// </param>
        /// <param name="description">
        /// The description of the model.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to train the model on.
        /// </param>
        /// <param name="instancePrompt">
        /// The instance prompt to use during training.
        /// </param>
        /// <param name="modelType">
        /// The category the most accurately reflects the model.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="nsfw">
        /// Whether or not the model is NSFW.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resolution">
        /// The resolution for training. Must be 512 or 768.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="sdVersion">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="strength">
        /// When training using the PIXEL_ART model type, this influences the training strength.<br/>
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.CreateModelResponse> CreateModelAsync(
            string name,
            string datasetId,
            string instancePrompt,
            string? description = default,
            global::Leonardo.CustomModelType? modelType = default,
            bool? nsfw = default,
            int? resolution = default,
            global::Leonardo.SdVersions? sdVersion = default,
            global::Leonardo.Strength? strength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Leonardo.CreateModelRequest
            {
                Name = name,
                Description = description,
                DatasetId = datasetId,
                InstancePrompt = instancePrompt,
                ModelType = modelType,
                Nsfw = nsfw,
                Resolution = resolution,
                SdVersion = sdVersion,
                Strength = strength,
            };

            return await CreateModelAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}