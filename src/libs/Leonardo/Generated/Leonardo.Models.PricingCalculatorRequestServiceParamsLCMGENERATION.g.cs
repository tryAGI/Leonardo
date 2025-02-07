
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for LCM_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsLCMGENERATION
    {
        /// <summary>
        /// The output height of the image. Must be 512, 640 or 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Enable for instant upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instantRefine")]
        public bool? InstantRefine { get; set; }

        /// <summary>
        /// Enable for normal alchemy upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refine")]
        public bool? Refine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsLCMGENERATION" /> class.
        /// </summary>
        /// <param name="height">
        /// The output height of the image. Must be 512, 640 or 1024.
        /// </param>
        /// <param name="width">
        /// The output width of the image. Must be 512, 640 or 1024.
        /// </param>
        /// <param name="instantRefine">
        /// Enable for instant upscale
        /// </param>
        /// <param name="refine">
        /// Enable for normal alchemy upscale
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParamsLCMGENERATION(
            int? height,
            int? width,
            bool? instantRefine,
            bool? refine)
        {
            this.Height = height;
            this.Width = width;
            this.InstantRefine = instantRefine;
            this.Refine = refine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsLCMGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsLCMGENERATION()
        {
        }
    }
}