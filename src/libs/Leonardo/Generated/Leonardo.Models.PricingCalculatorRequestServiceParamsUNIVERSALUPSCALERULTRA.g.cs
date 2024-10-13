
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for UNIVERSAL_UPSCALER_ULTRA service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA
    {
        /// <summary>
        /// The input width of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputWidth")]
        public int? InputWidth { get; set; }

        /// <summary>
        /// The input height of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputHeight")]
        public int? InputHeight { get; set; }

        /// <summary>
        /// The upscale multiplier of the universal upscaler. Must be between 1.00 and 2.00.<br/>
        /// Default Value: 1.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscaleMultiplier")]
        public double? UpscaleMultiplier { get; set; } = 1.5;

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
        public static global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA),
                jsonSerializerContext) as global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA>(
                json,
                jsonSerializerOptions);
        }

    }
}