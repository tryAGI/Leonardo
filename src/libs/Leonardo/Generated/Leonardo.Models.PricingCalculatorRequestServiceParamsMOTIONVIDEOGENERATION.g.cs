
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for MOTION_VIDEO_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsMOTIONVIDEOGENERATION
    {
        /// <summary>
        /// The resolution of the video. Must be enum value of FAST and QUALITY.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMOTIONVIDEOGENERATION" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution of the video. Must be enum value of FAST and QUALITY.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParamsMOTIONVIDEOGENERATION(
            string? resolution)
        {
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMOTIONVIDEOGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsMOTIONVIDEOGENERATION()
        {
        }
    }
}