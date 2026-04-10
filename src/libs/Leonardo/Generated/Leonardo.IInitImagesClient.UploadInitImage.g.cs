#nullable enable

namespace Leonardo
{
    public partial interface IInitImagesClient
    {
        /// <summary>
        /// Upload init image<br/>
        /// This endpoint returns presigned details to upload an init image to S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.UploadInitImageResponse> UploadInitImageAsync(

            global::Leonardo.UploadInitImageRequest request,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload init image<br/>
        /// This endpoint returns presigned details to upload an init image to S3
        /// </summary>
        /// <param name="extension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.UploadInitImageResponse> UploadInitImageAsync(
            string extension,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}