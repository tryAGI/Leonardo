
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The type of motion variation.
    /// </summary>
    public enum MOTIONVARIATIONTYPE
    {
        /// <summary>
        /// 
        /// </summary>
        UPSCALE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MOTIONVARIATIONTYPEExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MOTIONVARIATIONTYPE value)
        {
            return value switch
            {
                MOTIONVARIATIONTYPE.UPSCALE => "UPSCALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MOTIONVARIATIONTYPE? ToEnum(string value)
        {
            return value switch
            {
                "UPSCALE" => MOTIONVARIATIONTYPE.UPSCALE,
                _ => null,
            };
        }
    }
}