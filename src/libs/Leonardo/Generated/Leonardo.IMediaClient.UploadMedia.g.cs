#nullable enable

namespace Leonardo
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Upload media<br/>
        /// This endpoint returns presigned POST credentials to upload a video or audio file directly to S3.
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
        /// This endpoint returns presigned POST credentials to upload a video or audio file directly to S3.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.AutoSDKHttpResponse<global::Leonardo.UploadMediaResponse>> UploadMediaAsResponseAsync(

            global::Leonardo.UploadMediaRequest request,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media<br/>
        /// This endpoint returns presigned POST credentials to upload a video or audio file directly to S3.
        /// </summary>
        /// <param name="extension">
        /// The file extension of the media file to upload. Supported extensions for video: `mp4`, `mov`. Supported for audio: `mp3`, `wav`.
        /// </param>
        /// <param name="originalFilename">
        /// Original file name for display. Required for audio uploads (`mp3`, `wav`). Optional for video.
        /// </param>
        /// <param name="teamId">
        /// Optional team UUID. When set, the upload is associated with that team and the caller must be a member.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.UploadMediaResponse> UploadMediaAsync(
            string extension,
            string? originalFilename = default,
            string? teamId = default,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}