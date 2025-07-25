
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The model to use for the video generation. Defaults to MOTION2 if not specified.<br/>
    /// Default Value: MOTION2
    /// </summary>
    public enum CreateTextToVideoGenerationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        MOTION2,
        /// <summary>
        /// 
        /// </summary>
        VEO3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoGenerationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoGenerationRequestModel value)
        {
            return value switch
            {
                CreateTextToVideoGenerationRequestModel.MOTION2 => "MOTION2",
                CreateTextToVideoGenerationRequestModel.VEO3 => "VEO3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoGenerationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "MOTION2" => CreateTextToVideoGenerationRequestModel.MOTION2,
                "VEO3" => CreateTextToVideoGenerationRequestModel.VEO3,
                _ => null,
            };
        }
    }
}