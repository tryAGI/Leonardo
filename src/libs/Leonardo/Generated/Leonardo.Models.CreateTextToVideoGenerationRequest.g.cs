
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToVideoGenerationRequest
    {
        /// <summary>
        /// The prompt used to generate video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolution of the video. Defaults to RESOLUTION_480 if not specified. VEO3 only supports RESOLUTION_720 and RESOLUTION_1080.<br/>
        /// Default Value: RESOLUTION_480
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateTextToVideoGenerationRequestResolutionJsonConverter))]
        public global::Leonardo.CreateTextToVideoGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// The model to use for the video generation. Defaults to MOTION2 if not specified.<br/>
        /// Default Value: MOTION2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateTextToVideoGenerationRequestModelJsonConverter))]
        public global::Leonardo.CreateTextToVideoGenerationRequestModel? Model { get; set; }

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
        /// Predefined styles to enhance the prompt. This accepts a list of style uuids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleIds")]
        public global::System.Collections.Generic.IList<string>? StyleIds { get; set; }

        /// <summary>
        /// Height of the output video.<br/>
        /// Default Value: 480
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of the output video<br/>
        /// Default Value: 832
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTextToVideoGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used to generate video
        /// </param>
        /// <param name="resolution">
        /// The resolution of the video. Defaults to RESOLUTION_480 if not specified. VEO3 only supports RESOLUTION_720 and RESOLUTION_1080.<br/>
        /// Default Value: RESOLUTION_480
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
        /// <param name="negativePrompt">
        /// The negative prompt used for the video generation.
        /// </param>
        /// <param name="promptEnhance">
        /// Whether to enhance the prompt.
        /// </param>
        /// <param name="styleIds">
        /// Predefined styles to enhance the prompt. This accepts a list of style uuids.
        /// </param>
        /// <param name="height">
        /// Height of the output video.<br/>
        /// Default Value: 480
        /// </param>
        /// <param name="width">
        /// Width of the output video<br/>
        /// Default Value: 832
        /// </param>
        /// <param name="elements">
        /// An array of elements/loras objects that will be applied sequentially to the output. Elements are only supported for Motion2.0 generations. 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoGenerationRequest(
            string prompt,
            global::Leonardo.CreateTextToVideoGenerationRequestResolution? resolution,
            global::Leonardo.CreateTextToVideoGenerationRequestModel? model,
            bool? frameInterpolation,
            bool? isPublic,
            string? negativePrompt,
            bool? promptEnhance,
            global::System.Collections.Generic.IList<string>? styleIds,
            int? height,
            int? width,
            global::System.Collections.Generic.IList<global::Leonardo.ElementInput>? elements)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution;
            this.Model = model;
            this.FrameInterpolation = frameInterpolation;
            this.IsPublic = isPublic;
            this.NegativePrompt = negativePrompt;
            this.PromptEnhance = promptEnhance;
            this.StyleIds = styleIds;
            this.Height = height;
            this.Width = width;
            this.Elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoGenerationRequest" /> class.
        /// </summary>
        public CreateTextToVideoGenerationRequest()
        {
        }
    }
}