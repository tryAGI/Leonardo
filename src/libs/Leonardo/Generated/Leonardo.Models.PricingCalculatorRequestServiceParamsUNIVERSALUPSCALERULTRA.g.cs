
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
        public int InputWidth { get; set; }

        /// <summary>
        /// The input height of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputHeight")]
        public int InputHeight { get; set; }

        /// <summary>
        /// The upscale multiplier of the universal upscaler. Must be between 1.00 and 2.00.<br/>
        /// Default Value: 1.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscaleMultiplier")]
        public double UpscaleMultiplier { get; set; } = 1.5;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}