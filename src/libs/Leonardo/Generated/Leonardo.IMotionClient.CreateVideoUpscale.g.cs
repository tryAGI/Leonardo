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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVideoUpscaleResponse> CreateVideoUpscaleAsync(
            global::Leonardo.CreateVideoUpscaleRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVideoUpscaleResponse> CreateVideoUpscaleAsync(
            string sourceGenerationId,
            global::Leonardo.CreateVideoUpscaleRequestResolution resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}