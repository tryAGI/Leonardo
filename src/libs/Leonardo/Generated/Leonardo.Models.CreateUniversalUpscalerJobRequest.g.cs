
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUniversalUpscalerJobRequest
    {
        /// <summary>
        /// The creativity strength of the universal upscaler. Must be between 1 and 10.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativityStrength")]
        public int? CreativityStrength { get; set; }

        /// <summary>
        /// The detail contrast of the universal upscaler. Must be between 1 and 10. Can only be used with ultraUpscaleStyle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailContrast")]
        public int? DetailContrast { get; set; }

        /// <summary>
        /// The ID of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedImageId")]
        public string? GeneratedImageId { get; set; }

        /// <summary>
        /// The ID of the init image uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initImageId")]
        public string? InitImageId { get; set; }

        /// <summary>
        /// The prompt for the universal upscaler.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The similarity of the universal upscaler. Must be between 1 and 10. Can only be used with ultraUpscaleStyle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public int? Similarity { get; set; }

        /// <summary>
        /// The ultra style to upscale images using universal upscaler with. Can not be used with upscalerStyle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ultraUpscaleStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.UniversalUpscalerUltraStyleJsonConverter))]
        public global::Leonardo.UniversalUpscalerUltraStyle? UltraUpscaleStyle { get; set; }

        /// <summary>
        /// The upscale multiplier of the universal upscaler. Must be between 1.0 and 2.0.<br/>
        /// Default Value: 1.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscaleMultiplier")]
        public double? UpscaleMultiplier { get; set; }

        /// <summary>
        /// The style to upscale images using universal upscaler with. Can not be used with ultraUpscaleStyle.<br/>
        /// Default Value: GENERAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscalerStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.UniversalUpscalerStyleJsonConverter))]
        public global::Leonardo.UniversalUpscalerStyle? UpscalerStyle { get; set; }

        /// <summary>
        /// The ID of the variation image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variationId")]
        public string? VariationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobRequest" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateUniversalUpscalerJobRequest(
            int? creativityStrength,
            int? detailContrast,
            string? generatedImageId,
            string? initImageId,
            string? prompt,
            int? similarity,
            global::Leonardo.UniversalUpscalerUltraStyle? ultraUpscaleStyle,
            double? upscaleMultiplier,
            global::Leonardo.UniversalUpscalerStyle? upscalerStyle,
            string? variationId)
        {
            this.CreativityStrength = creativityStrength;
            this.DetailContrast = detailContrast;
            this.GeneratedImageId = generatedImageId;
            this.InitImageId = initImageId;
            this.Prompt = prompt;
            this.Similarity = similarity;
            this.UltraUpscaleStyle = ultraUpscaleStyle;
            this.UpscaleMultiplier = upscaleMultiplier;
            this.UpscalerStyle = upscalerStyle;
            this.VariationId = variationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobRequest" /> class.
        /// </summary>
        public CreateUniversalUpscalerJobRequest()
        {
        }
    }
}