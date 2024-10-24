#nullable enable

namespace Leonardo
{
    public partial interface IRealtimeCanvasClient
    {
        /// <summary>
        /// Perform Alchemy Upscale on a LCM image<br/>
        /// This endpoint will perform Alchemy Upscale on a LCM image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.PerformAlchemyUpscaleLCMResponse> PerformAlchemyUpscaleLCMAsync(
            global::Leonardo.PerformAlchemyUpscaleLCMRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Perform Alchemy Upscale on a LCM image<br/>
        /// This endpoint will perform Alchemy Upscale on a LCM image
        /// </summary>
        /// <param name="imageDataUrl">
        /// Image data used to generate image. In base64 format. Prefix: `data:image/jpeg;base64,`
        /// </param>
        /// <param name="prompt">
        /// The prompt used to generate images
        /// </param>
        /// <param name="guidance">
        /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
        /// </param>
        /// <param name="strength">
        /// Creativity strength of generation. Higher strength will deviate more from the original image supplied in imageDataUrl. Must be a float between 0.1 and 1.
        /// </param>
        /// <param name="requestTimestamp"></param>
        /// <param name="style">
        /// The style to generate LCM images with.
        /// </param>
        /// <param name="steps">
        /// The number of steps to use for the generation. Must be between 4 and 16.
        /// </param>
        /// <param name="width">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="height">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="seed"></param>
        /// <param name="refineCreative">
        /// Refine creative
        /// </param>
        /// <param name="refineStrength">
        /// Must be a float between 0.5 and 0.9.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.PerformAlchemyUpscaleLCMResponse> PerformAlchemyUpscaleLCMAsync(
            string imageDataUrl,
            string prompt,
            double? guidance = default,
            double? strength = default,
            string? requestTimestamp = default,
            global::Leonardo.LcmGenerationStyle? style = default,
            int? steps = default,
            int? width = default,
            int? height = default,
            int? seed = default,
            bool? refineCreative = default,
            double? refineStrength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}