#nullable enable

namespace Leonardo
{
    public partial interface IMotionClient
    {
        /// <summary>
        /// Upscale a generated video<br/>
        /// This endpoint will upscale a generated video to a higher resolution.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVideoUpscaleResponse> CreateVideoUpscaleAsync(

            global::Leonardo.CreateVideoUpscaleRequest request,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale a generated video<br/>
        /// This endpoint will upscale a generated video to a higher resolution.
        /// </summary>
        /// <param name="resolution">
        /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
        /// </param>
        /// <param name="sourceGenerationId">
        /// The ID of the source video generation to upscale.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVideoUpscaleResponse> CreateVideoUpscaleAsync(
            string sourceGenerationId,
            global::Leonardo.CreateVideoUpscaleRequestResolution resolution = default,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}