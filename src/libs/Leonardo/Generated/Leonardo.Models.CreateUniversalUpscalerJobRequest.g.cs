
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Leonardo.CreateUniversalUpscalerJobRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Leonardo.CreateUniversalUpscalerJobRequest),
                jsonSerializerContext) as global::Leonardo.CreateUniversalUpscalerJobRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Leonardo.CreateUniversalUpscalerJobRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Leonardo.CreateUniversalUpscalerJobRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}