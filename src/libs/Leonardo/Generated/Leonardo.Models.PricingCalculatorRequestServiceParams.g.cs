
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
        /// Parameters for MOTION_SVD_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_SVD_GENERATION")]
        public object? MOTIONSVDGENERATION { get; set; }

        /// <summary>
        /// Parameters for MOTION_VIDEO_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_VIDEO_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONVIDEOGENERATION? MOTIONVIDEOGENERATION { get; set; }

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
        /// Parameters for UNIVERSAL_UPSCALER_ULTRA service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER_ULTRA")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? UNIVERSALUPSCALERULTRA { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        /// <param name="iMAGEGENERATION">
        /// Parameters for IMAGE_GENERATION service
        /// </param>
        /// <param name="fANTASYAVATARGENERATION">
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </param>
        /// <param name="mOTIONGENERATION">
        /// Parameters for MOTION_GENERATION service
        /// </param>
        /// <param name="mOTIONSVDGENERATION">
        /// Parameters for MOTION_SVD_GENERATION service
        /// </param>
        /// <param name="mOTIONVIDEOGENERATION">
        /// Parameters for MOTION_VIDEO_GENERATION service
        /// </param>
        /// <param name="lCMGENERATION">
        /// Parameters for LCM_GENERATION service
        /// </param>
        /// <param name="mODELTRAINING">
        /// Parameters for MODEL_TRAINING service
        /// </param>
        /// <param name="tEXTUREGENERATION">
        /// Parameters for TEXTURE_GENERATION service
        /// </param>
        /// <param name="uNIVERSALUPSCALER">
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </param>
        /// <param name="uNIVERSALUPSCALERULTRA">
        /// Parameters for UNIVERSAL_UPSCALER_ULTRA service
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParams(
            global::Leonardo.PricingCalculatorRequestServiceParamsIMAGEGENERATION? iMAGEGENERATION,
            global::Leonardo.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? fANTASYAVATARGENERATION,
            global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONGENERATION? mOTIONGENERATION,
            object? mOTIONSVDGENERATION,
            global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONVIDEOGENERATION? mOTIONVIDEOGENERATION,
            global::Leonardo.PricingCalculatorRequestServiceParamsLCMGENERATION? lCMGENERATION,
            global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAINING? mODELTRAINING,
            global::Leonardo.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? tEXTUREGENERATION,
            global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? uNIVERSALUPSCALER,
            global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? uNIVERSALUPSCALERULTRA)
        {
            this.IMAGEGENERATION = iMAGEGENERATION;
            this.FANTASYAVATARGENERATION = fANTASYAVATARGENERATION;
            this.MOTIONGENERATION = mOTIONGENERATION;
            this.MOTIONSVDGENERATION = mOTIONSVDGENERATION;
            this.MOTIONVIDEOGENERATION = mOTIONVIDEOGENERATION;
            this.LCMGENERATION = lCMGENERATION;
            this.MODELTRAINING = mODELTRAINING;
            this.TEXTUREGENERATION = tEXTUREGENERATION;
            this.UNIVERSALUPSCALER = uNIVERSALUPSCALER;
            this.UNIVERSALUPSCALERULTRA = uNIVERSALUPSCALERULTRA;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParams()
        {
        }
    }
}