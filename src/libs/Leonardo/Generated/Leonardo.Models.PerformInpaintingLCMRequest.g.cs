
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformInpaintingLCMRequest
    {
        /// <summary>
        /// Image data used to generate image. In base64 format. Prefix: `data:image/jpeg;base64,`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageDataUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageDataUrl { get; set; }

        /// <summary>
        /// Image data of the mask layer used for inpainting. In base64 format. Prefix: `data:image/jpeg;base64,`. Mask should be white on black where generation is applied to the white area.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskDataUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaskDataUrl { get; set; }

        /// <summary>
        /// The prompt used to generate images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Creativity strength of generation. Higher strength will deviate more from the original image supplied in imageDataUrl. Must be a float between 0.1 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestTimestamp")]
        public string? RequestTimestamp { get; set; }

        /// <summary>
        /// The style to generate LCM images with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.LcmGenerationStyleJsonConverter))]
        public global::Leonardo.LcmGenerationStyle? Style { get; set; }

        /// <summary>
        /// The number of steps to use for the generation. Must be between 4 and 16.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        public static global::Leonardo.PerformInpaintingLCMRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Leonardo.PerformInpaintingLCMRequest),
                jsonSerializerContext) as global::Leonardo.PerformInpaintingLCMRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Leonardo.PerformInpaintingLCMRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Leonardo.PerformInpaintingLCMRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}