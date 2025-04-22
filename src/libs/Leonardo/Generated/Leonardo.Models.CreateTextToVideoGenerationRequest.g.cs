
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
        /// Optional predefined styles to enhance the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleIds")]
        public global::System.Collections.Generic.IList<string>? StyleIds { get; set; }

        /// <summary>
        /// Height of the output<br/>
        /// Default Value: 480
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of the output<br/>
        /// Default Value: 832
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTextToVideoGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used to generate video
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoGenerationRequest(
            string prompt,
            bool? frameInterpolation,
            bool? isPublic,
            string? negativePrompt,
            bool? promptEnhance,
            global::System.Collections.Generic.IList<string>? styleIds,
            int? height,
            int? width,
            global::System.Collections.Generic.IList<object>? elements)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
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