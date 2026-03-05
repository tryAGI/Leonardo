
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The type of motion variation.
    /// </summary>
    public enum MotionVariationType
    {
        /// <summary>
        /// 
        /// </summary>
        Upscale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MotionVariationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MotionVariationType value)
        {
            return value switch
            {
                MotionVariationType.Upscale => "UPSCALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MotionVariationType? ToEnum(string value)
        {
            return value switch
            {
                "UPSCALE" => MotionVariationType.Upscale,
                _ => null,
            };
        }
    }
}