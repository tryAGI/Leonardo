
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
        public global::Leonardo.PricingCalculatorRequestServiceParamsImageGeneration? ImageGeneration { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FANTASY_AVATAR_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration? FantasyAvatarGeneration { get; set; }

        /// <summary>
        /// Parameters for MOTION_SVD_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_SVD_GENERATION")]
        public object? MotionSvdGeneration { get; set; }

        /// <summary>
        /// Parameters for MOTION_VIDEO_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_VIDEO_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsMotionVideoGeneration? MotionVideoGeneration { get; set; }

        /// <summary>
        /// Parameters for VEO3_MOTION_VIDEO_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("VEO3_MOTION_VIDEO_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration? Veo3MotionVideoGeneration { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCM_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsLcmGeneration? LcmGeneration { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MODEL_TRAINING")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsModelTraining? ModelTraining { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TEXTURE_GENERATION")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsTextureGeneration? TextureGeneration { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscaler? UniversalUpscaler { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER_ULTRA service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER_ULTRA")]
        public global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscalerUltra? UniversalUpscalerUltra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        /// <param name="imageGeneration">
        /// Parameters for IMAGE_GENERATION service
        /// </param>
        /// <param name="fantasyAvatarGeneration">
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </param>
        /// <param name="motionSvdGeneration">
        /// Parameters for MOTION_SVD_GENERATION service
        /// </param>
        /// <param name="motionVideoGeneration">
        /// Parameters for MOTION_VIDEO_GENERATION service
        /// </param>
        /// <param name="veo3MotionVideoGeneration">
        /// Parameters for VEO3_MOTION_VIDEO_GENERATION service
        /// </param>
        /// <param name="lcmGeneration">
        /// Parameters for LCM_GENERATION service
        /// </param>
        /// <param name="modelTraining">
        /// Parameters for MODEL_TRAINING service
        /// </param>
        /// <param name="textureGeneration">
        /// Parameters for TEXTURE_GENERATION service
        /// </param>
        /// <param name="universalUpscaler">
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </param>
        /// <param name="universalUpscalerUltra">
        /// Parameters for UNIVERSAL_UPSCALER_ULTRA service
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParams(
            global::Leonardo.PricingCalculatorRequestServiceParamsImageGeneration? imageGeneration,
            global::Leonardo.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration? fantasyAvatarGeneration,
            object? motionSvdGeneration,
            global::Leonardo.PricingCalculatorRequestServiceParamsMotionVideoGeneration? motionVideoGeneration,
            global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration? veo3MotionVideoGeneration,
            global::Leonardo.PricingCalculatorRequestServiceParamsLcmGeneration? lcmGeneration,
            global::Leonardo.PricingCalculatorRequestServiceParamsModelTraining? modelTraining,
            global::Leonardo.PricingCalculatorRequestServiceParamsTextureGeneration? textureGeneration,
            global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscaler? universalUpscaler,
            global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscalerUltra? universalUpscalerUltra)
        {
            this.ImageGeneration = imageGeneration;
            this.FantasyAvatarGeneration = fantasyAvatarGeneration;
            this.MotionSvdGeneration = motionSvdGeneration;
            this.MotionVideoGeneration = motionVideoGeneration;
            this.Veo3MotionVideoGeneration = veo3MotionVideoGeneration;
            this.LcmGeneration = lcmGeneration;
            this.ModelTraining = modelTraining;
            this.TextureGeneration = textureGeneration;
            this.UniversalUpscaler = universalUpscaler;
            this.UniversalUpscalerUltra = universalUpscalerUltra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParams()
        {
        }
    }
}