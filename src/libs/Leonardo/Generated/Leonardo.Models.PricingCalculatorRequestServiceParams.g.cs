
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for the service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParams
    {
        /// <summary>
        /// Parameters for IMAGE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("IMAGE_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsIMAGEGENERATION? IMAGEGENERATION { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FANTASY_AVATAR_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? FANTASYAVATARGENERATION { get; set; }

        /// <summary>
        /// Parameters for MOTION_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONGENERATION? MOTIONGENERATION { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCM_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsLCMGENERATION? LCMGENERATION { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MODEL_TRAINING")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAINING? MODELTRAINING { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TEXTURE_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? TEXTUREGENERATION { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? UNIVERSALUPSCALER { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}