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
        /// <param name="endFrameImage">
        /// The end frame image. Supported only on kling2_1 model when used in conjunction with an init image.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the output video. Acceptable values vary based on model
        /// </param>
        /// <param name="model">
        /// The model to use for the video generation. Defaults to MOTION2 if not specified.<br/>
        /// Default Value: MOTION2
        /// </param>
        /// <param name="frameInterpolation">
        /// Smoothly blend frames for fluid video transitions using Interpolation.
        /// </param>
        /// <param name="isPublic">
        /// Whether the generation is public or not
        /// </param>
        /// <param name="seed">
        /// Apply a fixed seed to maintain consistency across generation sets. The maximum seed value is 2147483637 for Motion 2.0.
        /// </param>
        /// <param name="negativePrompt">
        /// The negative prompt used for the video generation.
        /// </param>
        /// <param name="promptEnhance">
        /// Whether to enhance the prompt.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds. Allowed values: 4, 6, or 8 on models VEO3 and VEO3FAST (default: 8) and 5 or 10 on model KLING2_5 (default: 5).
        /// </param>
        /// <param name="promptEnhanceInstruction">
        /// A natural language instruction used to modify the main prompt. For example, 'make it cinematic', 'add a rainbow', or 'change the subject to a cat'.
        /// </param>
        /// <param name="styleIds">
        /// Predefined styles to enhance the prompt. This accepts a list of style uuids.
        /// </param>
        /// <param name="elements">
        /// An array of elements/loras objects that will be applied sequentially to the output. Elements are only supported for Motion2.0 generations. 
        /// </param>
        /// <param name="height">
        /// Height of the output video. Acceptable values vary based on model
        /// </param>
        /// <param name="width">
        /// Width of the output video. Acceptable values vary based on model
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateImageToVideoGenerationResponse> CreateImageToVideoGenerationAsync(
            string prompt,
            string imageId,
            global::Leonardo.CreateImageToVideoGenerationRequestImageType imageType,
            global::Leonardo.CreateImageToVideoGenerationRequestEndFrameImage? endFrameImage = default,
            global::Leonardo.CreateImageToVideoGenerationRequestResolution? resolution = default,
            global::Leonardo.CreateImageToVideoGenerationRequestModel? model = default,
            bool? frameInterpolation = default,
            bool? isPublic = default,
            int? seed = default,
            string? negativePrompt = default,
            bool? promptEnhance = default,
            int? duration = default,
            string? promptEnhanceInstruction = default,
            global::System.Collections.Generic.IList<string>? styleIds = default,
            global::System.Collections.Generic.IList<global::Leonardo.ElementInput>? elements = default,
            int? height = default,
            int? width = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}