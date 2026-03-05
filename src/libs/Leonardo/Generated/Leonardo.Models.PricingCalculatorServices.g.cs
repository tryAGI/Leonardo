
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The services to be chosen for calculating the API credit cost.
    /// </summary>
    public enum PricingCalculatorServices
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        FantasyAvatarGeneration,
        /// <summary>
        /// 
        /// </summary>
        MotionSvdGeneration,
        /// <summary>
        /// 
        /// </summary>
        MotionVideoGeneration,
        /// <summary>
        /// 
        /// </summary>
        Veo3MotionVideoGeneration,
        /// <summary>
        /// 
        /// </summary>
        LcmGeneration,
        /// <summary>
        /// 
        /// </summary>
        ModelTraining,
        /// <summary>
        /// 
        /// </summary>
        TextureGeneration,
        /// <summary>
        /// 
        /// </summary>
        UniversalUpscaler,
        /// <summary>
        /// 
        /// </summary>
        UniversalUpscalerUltra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingCalculatorServicesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingCalculatorServices value)
        {
            return value switch
            {
                PricingCalculatorServices.ImageGeneration => "IMAGE_GENERATION",
                PricingCalculatorServices.FantasyAvatarGeneration => "FANTASY_AVATAR_GENERATION",
                PricingCalculatorServices.MotionSvdGeneration => "MOTION_SVD_GENERATION",
                PricingCalculatorServices.MotionVideoGeneration => "MOTION_VIDEO_GENERATION",
                PricingCalculatorServices.Veo3MotionVideoGeneration => "VEO3_MOTION_VIDEO_GENERATION",
                PricingCalculatorServices.LcmGeneration => "LCM_GENERATION",
                PricingCalculatorServices.ModelTraining => "MODEL_TRAINING",
                PricingCalculatorServices.TextureGeneration => "TEXTURE_GENERATION",
                PricingCalculatorServices.UniversalUpscaler => "UNIVERSAL_UPSCALER",
                PricingCalculatorServices.UniversalUpscalerUltra => "UNIVERSAL_UPSCALER_ULTRA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingCalculatorServices? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE_GENERATION" => PricingCalculatorServices.ImageGeneration,
                "FANTASY_AVATAR_GENERATION" => PricingCalculatorServices.FantasyAvatarGeneration,
                "MOTION_SVD_GENERATION" => PricingCalculatorServices.MotionSvdGeneration,
                "MOTION_VIDEO_GENERATION" => PricingCalculatorServices.MotionVideoGeneration,
                "VEO3_MOTION_VIDEO_GENERATION" => PricingCalculatorServices.Veo3MotionVideoGeneration,
                "LCM_GENERATION" => PricingCalculatorServices.LcmGeneration,
                "MODEL_TRAINING" => PricingCalculatorServices.ModelTraining,
                "TEXTURE_GENERATION" => PricingCalculatorServices.TextureGeneration,
                "UNIVERSAL_UPSCALER" => PricingCalculatorServices.UniversalUpscaler,
                "UNIVERSAL_UPSCALER_ULTRA" => PricingCalculatorServices.UniversalUpscalerUltra,
                _ => null,
            };
        }
    }
}