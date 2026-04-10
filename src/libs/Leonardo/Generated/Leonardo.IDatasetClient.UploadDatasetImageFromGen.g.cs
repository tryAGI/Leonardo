#nullable enable

namespace Leonardo
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// Upload a Single Generated Image to a Dataset<br/>
        /// This endpoint will upload a previously generated image to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.UploadDatasetImageFromGenResponse> UploadDatasetImageFromGenAsync(
            string datasetId,

            global::Leonardo.UploadDatasetImageFromGenRequest request,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a Single Generated Image to a Dataset<br/>
        /// This endpoint will upload a previously generated image to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="generatedImageId">
        /// The ID of the image to upload to the dataset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.UploadDatasetImageFromGenResponse> UploadDatasetImageFromGenAsync(
            string datasetId,
            string generatedImageId,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}