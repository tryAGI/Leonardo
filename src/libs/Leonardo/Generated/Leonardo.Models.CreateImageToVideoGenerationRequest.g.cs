
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
        /// The resolution of the video. MOTION2 and MOTION2FAST supports RESOLUTION_480 and RESOLUTION_720 and defaults to RESOLUTION_480 if not specified. VEO3 and VEO3FAST supports RESOLUTION_720 and RESOLUTION_1080 and defaults to RESOLUTION_720 if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestResolutionJsonConverter))]
        public global::Leonardo.CreateImageToVideoGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// The model to use for the video generation. Defaults to MOTION2 if not specified.<br/>
        /// Default Value: MOTION2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestModelJsonConverter))]
        public global::Leonardo.CreateImageToVideoGenerationRequestModel? Model { get; set; }

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
        /// Apply a fixed seed to maintain consistency across generation sets. The maximum seed value is 2147483637 for Motion 2.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Duration of the output video in seconds. Defaults to 8 seconds if not specified. Allowed values: 4, 6, or 8. Supported on models VEO3 and VEO3FAST.<br/>
        /// Default Value: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// A natural language instruction used to modify the main prompt. For example, 'make it cinematic', 'add a rainbow', or 'change the subject to a cat'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptEnhanceInstruction")]
        public string? PromptEnhanceInstruction { get; set; }

        /// <summary>
        /// Predefined styles to enhance the prompt. This accepts a list of style uuids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleIds")]
        public global::System.Collections.Generic.IList<string>? StyleIds { get; set; }

        /// <summary>
        /// An array of elements/loras objects that will be applied sequentially to the output. Elements are only supported for Motion2.0 generations. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::Leonardo.ElementInput>? Elements { get; set; }

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
        /// The resolution of the video. MOTION2 and MOTION2FAST supports RESOLUTION_480 and RESOLUTION_720 and defaults to RESOLUTION_480 if not specified. VEO3 and VEO3FAST supports RESOLUTION_720 and RESOLUTION_1080 and defaults to RESOLUTION_720 if not specified.
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
        /// Duration of the output video in seconds. Defaults to 8 seconds if not specified. Allowed values: 4, 6, or 8. Supported on models VEO3 and VEO3FAST.<br/>
        /// Default Value: 8
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoGenerationRequest(
            string prompt,
            string imageId,
            global::Leonardo.CreateImageToVideoGenerationRequestImageType imageType,
            global::Leonardo.CreateImageToVideoGenerationRequestResolution? resolution,
            global::Leonardo.CreateImageToVideoGenerationRequestModel? model,
            bool? frameInterpolation,
            bool? isPublic,
            int? seed,
            string? negativePrompt,
            bool? promptEnhance,
            int? duration,
            string? promptEnhanceInstruction,
            global::System.Collections.Generic.IList<string>? styleIds,
            global::System.Collections.Generic.IList<global::Leonardo.ElementInput>? elements)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.ImageType = imageType;
            this.Resolution = resolution;
            this.Model = model;
            this.FrameInterpolation = frameInterpolation;
            this.IsPublic = isPublic;
            this.Seed = seed;
            this.NegativePrompt = negativePrompt;
            this.PromptEnhance = promptEnhance;
            this.Duration = duration;
            this.PromptEnhanceInstruction = promptEnhanceInstruction;
            this.StyleIds = styleIds;
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