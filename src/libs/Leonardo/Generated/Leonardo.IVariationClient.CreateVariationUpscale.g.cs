#nullable enable

namespace Leonardo
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create upscale<br/>
        /// This endpoint will create an upscale for the provided image ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVariationUpscaleResponse> CreateVariationUpscaleAsync(
            global::Leonardo.CreateVariationUpscaleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create upscale<br/>
        /// This endpoint will create an upscale for the provided image ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVariationUpscaleResponse> CreateVariationUpscaleAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}