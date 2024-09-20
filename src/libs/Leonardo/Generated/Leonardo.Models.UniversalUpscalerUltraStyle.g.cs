
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The ultra style to upscale images using universal upscaler with. Can not be used with upscalerStyle.
    /// </summary>
    public enum UniversalUpscalerUltraStyle
    {
        /// <summary>
        /// 
        /// </summary>
        ARTISTIC,
        /// <summary>
        /// 
        /// </summary>
        REALISTIC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UniversalUpscalerUltraStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UniversalUpscalerUltraStyle value)
        {
            return value switch
            {
                UniversalUpscalerUltraStyle.ARTISTIC => "ARTISTIC",
                UniversalUpscalerUltraStyle.REALISTIC => "REALISTIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UniversalUpscalerUltraStyle? ToEnum(string value)
        {
            return value switch
            {
                "ARTISTIC" => UniversalUpscalerUltraStyle.ARTISTIC,
                "REALISTIC" => UniversalUpscalerUltraStyle.REALISTIC,
                _ => null,
            };
        }
    }
}