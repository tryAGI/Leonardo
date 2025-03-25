#nullable enable

namespace Leonardo
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            global::Leonardo.CreateUniversalUpscalerJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create using Universal Upscaler<br/>
        /// This endpoint will create a high resolution image using Universal Upscaler
        /// </summary>
        /// <param name="creativityStrength">
        /// The creativity strength of the universal upscaler. Must be between 1 and 10.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="detailContrast">
        /// The detail contrast of the universal upscaler. Must be between 1 and 10. Can only be used with ultraUpscaleStyle.
        /// </param>
        /// <param name="generatedImageId">
        /// The ID of the generated image.
        /// </param>
        /// <param name="initImageId">
        /// The ID of the init image uploaded.
        /// </param>
        /// <param name="prompt">
        /// The prompt for the universal upscaler.
        /// </param>
        /// <param name="similarity">
        /// The similarity of the universal upscaler. Must be between 1 and 10. Can only be used with ultraUpscaleStyle.
        /// </param>
        /// <param name="ultraUpscaleStyle">
        /// The ultra style to upscale images using universal upscaler with. Can not be used with upscalerStyle.
        /// </param>
        /// <param name="upscaleMultiplier">
        /// The upscale multiplier of the universal upscaler. Must be between 1.0 and 2.0.<br/>
        /// Default Value: 1.5
        /// </param>
        /// <param name="upscalerStyle">
        /// The style to upscale images using universal upscaler with. Can not be used with ultraUpscaleStyle.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="variationId">
        /// The ID of the variation image.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateUniversalUpscalerJobResponse> CreateUniversalUpscalerJobAsync(
            int? creativityStrength = default,
            int? detailContrast = default,
            string? generatedImageId = default,
            string? initImageId = default,
            string? prompt = default,
            int? similarity = default,
            global::Leonardo.UniversalUpscalerUltraStyle? ultraUpscaleStyle = default,
            double? upscaleMultiplier = default,
            global::Leonardo.UniversalUpscalerStyle? upscalerStyle = default,
            string? variationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}