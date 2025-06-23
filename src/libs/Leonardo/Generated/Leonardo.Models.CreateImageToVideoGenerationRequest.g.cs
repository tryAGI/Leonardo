
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoGenerationRequest
    {
        /// <summary>
        /// The prompt used to generate video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The ID of the image, supports generated images and init images. Use only image or imageId with imageType.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageId { get; set; }

        /// <summary>
        /// Type indicating whether the init image is uploaded or generated. Use only image or imageId with imageType.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestImageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.CreateImageToVideoGenerationRequestImageType ImageType { get; set; }

        /// <summary>
        /// The resolution of the video. Defaults to RESOLUTION_480 if not specified.<br/>
        /// Default Value: RESOLUTION_480
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestResolutionJsonConverter))]
        public global::Leonardo.CreateImageToVideoGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Smoothly blend frames for fluid video transitions using Interpolation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameInterpolation")]
        public bool? FrameInterpolation { get; set; }

        /// <summary>
        /// Whether the generation is public or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// The negative prompt used for the video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negativePrompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Whether to enhance the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptEnhance")]
        public bool? PromptEnhance { get; set; }

        /// <summary>
        /// An array of elements/loras objects that will be applied sequentially to the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<object>? Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoGenerationRequest" /> class.
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
        /// <param name="elements">
        /// An array of elements/loras objects that will be applied sequentially to the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoGenerationRequest(
            string prompt,
            string imageId,
            global::Leonardo.CreateImageToVideoGenerationRequestImageType imageType,
            global::Leonardo.CreateImageToVideoGenerationRequestResolution? resolution,
            bool? frameInterpolation,
            bool? isPublic,
            string? negativePrompt,
            bool? promptEnhance,
            global::System.Collections.Generic.IList<object>? elements)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.ImageType = imageType;
            this.Resolution = resolution;
            this.FrameInterpolation = frameInterpolation;
            this.IsPublic = isPublic;
            this.NegativePrompt = negativePrompt;
            this.PromptEnhance = promptEnhance;
            this.Elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoGenerationRequest" /> class.
        /// </summary>
        public CreateImageToVideoGenerationRequest()
        {
        }
    }
}