
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
    /// </summary>
    public enum MotionResolution
    {
        /// <summary>
        /// 
        /// </summary>
        Resolution720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MotionResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MotionResolution value)
        {
            return value switch
            {
                MotionResolution.Resolution720 => "RESOLUTION_720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MotionResolution? ToEnum(string value)
        {
            return value switch
            {
                "RESOLUTION_720" => MotionResolution.Resolution720,
                _ => null,
            };
        }
    }
}