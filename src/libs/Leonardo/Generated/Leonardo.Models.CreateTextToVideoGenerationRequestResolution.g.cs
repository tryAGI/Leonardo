
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The resolution of the video. Defaults to RESOLUTION_480 if not specified. VEO3 only supports RESOLUTION_720.<br/>
    /// Default Value: RESOLUTION_480
    /// </summary>
    public enum CreateTextToVideoGenerationRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION480,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoGenerationRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoGenerationRequestResolution value)
        {
            return value switch
            {
                CreateTextToVideoGenerationRequestResolution.RESOLUTION480 => "RESOLUTION_480",
                CreateTextToVideoGenerationRequestResolution.RESOLUTION720 => "RESOLUTION_720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoGenerationRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "RESOLUTION_480" => CreateTextToVideoGenerationRequestResolution.RESOLUTION480,
                "RESOLUTION_720" => CreateTextToVideoGenerationRequestResolution.RESOLUTION720,
                _ => null,
            };
        }
    }
}