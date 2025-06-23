#nullable enable

namespace Leonardo
{
    public partial interface IMotionClient
    {
        /// <summary>
        /// Create a video generation from a text prompt<br/>
        /// This endpoint will generate a video using a text prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateTextToVideoGenerationResponse> CreateTextToVideoGenerationAsync(
            global::Leonardo.CreateTextToVideoGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a video generation from a text prompt<br/>
        /// This endpoint will generate a video using a text prompt
        /// </summary>
        /// <param name="prompt">
        /// The prompt used to generate video
        /// </param>
        /// <param name="resolution">
        /// The resolution of the video. Defaults to RESOLUTION_480 if not specified.<br/>
        /// Default Value: RESOLUTION_480
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
        /// <param name="styleIds">
        /// Optional predefined styles to enhance the prompt
        /// </param>
        /// <param name="height">
        /// Height of the output<br/>
        /// Default Value: 480
        /// </param>
        /// <param name="width">
        /// Width of the output<br/>
        /// Default Value: 832
        /// </param>
        /// <param name="elements">
        /// An array of elements/loras objects that will be applied sequentially to the output.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateTextToVideoGenerationResponse> CreateTextToVideoGenerationAsync(
            string prompt,
            global::Leonardo.CreateTextToVideoGenerationRequestResolution? resolution = default,
            bool? frameInterpolation = default,
            bool? isPublic = default,
            string? negativePrompt = default,
            bool? promptEnhance = default,
            global::System.Collections.Generic.IList<string>? styleIds = default,
            int? height = default,
            int? width = default,
            global::System.Collections.Generic.IList<object>? elements = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}