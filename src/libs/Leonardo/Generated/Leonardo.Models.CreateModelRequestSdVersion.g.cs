
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5.
    /// </summary>
    public enum CreateModelRequestSdVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V15,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelRequestSdVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestSdVersion value)
        {
            return value switch
            {
                CreateModelRequestSdVersion.V15 => "v1_5",
                CreateModelRequestSdVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestSdVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1_5" => CreateModelRequestSdVersion.V15,
                "v2" => CreateModelRequestSdVersion.V2,
                _ => null,
            };
        }
    }
}