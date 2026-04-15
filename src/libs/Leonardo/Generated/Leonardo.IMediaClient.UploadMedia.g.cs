#nullable enable

namespace Leonardo
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Upload media<br/>
        /// This endpoint returns presigned details to upload a media file to S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.UploadMediaResponse> UploadMediaAsync(

            global::Leonardo.UploadMediaRequest request,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media<br/>
        /// This endpoint returns presigned details to upload a media file to S3
        /// </summary>
        /// <param name="extension">
        /// The file extension of the media file to upload. Supported extensions: mp4, mov.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.UploadMediaResponse> UploadMediaAsync(
            string extension,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}