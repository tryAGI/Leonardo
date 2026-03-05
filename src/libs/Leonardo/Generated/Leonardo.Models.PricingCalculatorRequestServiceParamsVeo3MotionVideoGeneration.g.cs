
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for VEO3_MOTION_VIDEO_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration
    {
        /// <summary>
        /// The resolution of the video. Supported resolution for VEO3 is RESOLUTION_720.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolutionJsonConverter))]
        public global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution of the video. Supported resolution for VEO3 is RESOLUTION_720.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration(
            global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution? resolution)
        {
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration()
        {
        }
    }
}