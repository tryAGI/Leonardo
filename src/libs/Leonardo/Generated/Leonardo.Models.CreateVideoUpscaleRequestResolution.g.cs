
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
    /// </summary>
    public enum CreateVideoUpscaleRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoUpscaleRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoUpscaleRequestResolution value)
        {
            return value switch
            {
                CreateVideoUpscaleRequestResolution.RESOLUTION720 => "RESOLUTION_720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoUpscaleRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "RESOLUTION_720" => CreateVideoUpscaleRequestResolution.RESOLUTION720,
                _ => null,
            };
        }
    }
}