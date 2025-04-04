#nullable enable

namespace Leonardo
{
    public partial interface IMotionClient
    {
        /// <summary>
        /// Create a video generation from an image<br/>
        /// This endpoint will generate a video using an uploaded or generated image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateImageToVideoGenerationResponse> CreateImageToVideoGenerationAsync(
            global::Leonardo.CreateImageToVideoGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a video generation from an image<br/>
        /// This endpoint will generate a video using an uploaded or generated image.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used to generate video
        /// </param>
        /// <param name="imageId">
        /// The ID of the image, supports generated images and init images. Use only image or imageId with imageType.
        /// </param>
        /// <param name="imageType">
        /// Type indicating whether the init image is uploaded or generated. Use only image or imageId with imageType.
        /// </param>
        /// <param name="frameInterpolation">
        /// Smoothly blend frames for fluid video transitions using Interpolation.
        /// </param>
        /// <param name="isPublic">
        /// Whether the generation is public or not
        /// </param>
        /// <param name="negativePrompt">
        /// The negative prompt used for the video generation.
        /// </param>
        /// <param name="promptEnhance">
        /// Whether to enhance the prompt.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateImageToVideoGenerationResponse> CreateImageToVideoGenerationAsync(
            string prompt,
            string imageId,
            global::Leonardo.CreateImageToVideoGenerationRequestImageType imageType,
            bool? frameInterpolation = default,
            bool? isPublic = default,
            string? negativePrompt = default,
            bool? promptEnhance = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}