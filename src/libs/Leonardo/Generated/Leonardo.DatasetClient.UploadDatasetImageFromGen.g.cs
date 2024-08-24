
#nullable enable

namespace Leonardo
{
    public partial class DatasetClient
    {
        partial void PrepareUploadDatasetImageFromGenArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::Leonardo.UploadDatasetImageFromGenRequest request);
        partial void PrepareUploadDatasetImageFromGenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::Leonardo.UploadDatasetImageFromGenRequest request);
        partial void ProcessUploadDatasetImageFromGenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadDatasetImageFromGenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload a Single Generated Image to a Dataset<br/>
        /// This endpoint will upload a previously generated image to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.UploadDatasetImageFromGenResponse> UploadDatasetImageFromGenAsync(
            string datasetId,
            global::Leonardo.UploadDatasetImageFromGenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUploadDatasetImageFromGenArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/datasets/{datasetId}/upload/gen", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::Leonardo.SourceGenerationContext.Default.UploadDatasetImageFromGenRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUploadDatasetImageFromGenRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUploadDatasetImageFromGenResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUploadDatasetImageFromGenResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::Leonardo.SourceGenerationContext.Default.UploadDatasetImageFromGenResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload a Single Generated Image to a Dataset<br/>
        /// This endpoint will upload a previously generated image to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="generatedImageId">
        /// The ID of the image to upload to the dataset.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Leonardo.UploadDatasetImageFromGenResponse> UploadDatasetImageFromGenAsync(
            string datasetId,
            string generatedImageId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Leonardo.UploadDatasetImageFromGenRequest
            {
                GeneratedImageId = generatedImageId,
            };

            return await UploadDatasetImageFromGenAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}