
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The resolution of the video. Supported resolution for VEO3 is RESOLUTION_720.
    /// </summary>
    public enum PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution
    {
        /// <summary>
        /// 
        /// </summary>
        Resolution720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution value)
        {
            return value switch
            {
                PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution.Resolution720 => "RESOLUTION_720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution? ToEnum(string value)
        {
            return value switch
            {
                "RESOLUTION_720" => PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution.Resolution720,
                _ => null,
            };
        }
    }
}