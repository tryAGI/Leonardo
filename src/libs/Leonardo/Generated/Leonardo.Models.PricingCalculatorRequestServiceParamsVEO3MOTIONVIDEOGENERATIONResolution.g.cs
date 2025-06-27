
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The resolution of the video. Supported resolution for VEO3 is RESOLUTION_720.
    /// </summary>
    public enum PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution
    {
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution value)
        {
            return value switch
            {
                PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution.RESOLUTION720 => "RESOLUTION_720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution? ToEnum(string value)
        {
            return value switch
            {
                "RESOLUTION_720" => PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution.RESOLUTION720,
                _ => null,
            };
        }
    }
}