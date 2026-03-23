
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
        FantasyAvatarGeneration,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
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
        MotionSvdGeneration,
        /// <summary>
        /// 
        /// </summary>
        MotionVideoGeneration,
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
        /// <summary>
        /// 
        /// </summary>
        Veo3MotionVideoGeneration,
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
                PricingCalculatorServices.FantasyAvatarGeneration => "FANTASY_AVATAR_GENERATION",
                PricingCalculatorServices.ImageGeneration => "IMAGE_GENERATION",
                PricingCalculatorServices.LcmGeneration => "LCM_GENERATION",
                PricingCalculatorServices.ModelTraining => "MODEL_TRAINING",
                PricingCalculatorServices.MotionSvdGeneration => "MOTION_SVD_GENERATION",
                PricingCalculatorServices.MotionVideoGeneration => "MOTION_VIDEO_GENERATION",
                PricingCalculatorServices.TextureGeneration => "TEXTURE_GENERATION",
                PricingCalculatorServices.UniversalUpscaler => "UNIVERSAL_UPSCALER",
                PricingCalculatorServices.UniversalUpscalerUltra => "UNIVERSAL_UPSCALER_ULTRA",
                PricingCalculatorServices.Veo3MotionVideoGeneration => "VEO3_MOTION_VIDEO_GENERATION",
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
                "FANTASY_AVATAR_GENERATION" => PricingCalculatorServices.FantasyAvatarGeneration,
                "IMAGE_GENERATION" => PricingCalculatorServices.ImageGeneration,
                "LCM_GENERATION" => PricingCalculatorServices.LcmGeneration,
                "MODEL_TRAINING" => PricingCalculatorServices.ModelTraining,
                "MOTION_SVD_GENERATION" => PricingCalculatorServices.MotionSvdGeneration,
                "MOTION_VIDEO_GENERATION" => PricingCalculatorServices.MotionVideoGeneration,
                "TEXTURE_GENERATION" => PricingCalculatorServices.TextureGeneration,
                "UNIVERSAL_UPSCALER" => PricingCalculatorServices.UniversalUpscaler,
                "UNIVERSAL_UPSCALER_ULTRA" => PricingCalculatorServices.UniversalUpscalerUltra,
                "VEO3_MOTION_VIDEO_GENERATION" => PricingCalculatorServices.Veo3MotionVideoGeneration,
                _ => null,
            };
        }
    }
}