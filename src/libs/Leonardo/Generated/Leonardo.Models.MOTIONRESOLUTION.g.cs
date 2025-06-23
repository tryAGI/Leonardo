
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
    /// </summary>
    public enum MOTIONRESOLUTION
    {
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MOTIONRESOLUTIONExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MOTIONRESOLUTION value)
        {
            return value switch
            {
                MOTIONRESOLUTION.RESOLUTION720 => "RESOLUTION_720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MOTIONRESOLUTION? ToEnum(string value)
        {
            return value switch
            {
                "RESOLUTION_720" => MOTIONRESOLUTION.RESOLUTION720,
                _ => null,
            };
        }
    }
}