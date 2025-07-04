
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The model to use for the video generation. Defaults to MOTION2 if not specified.<br/>
    /// Default Value: MOTION2
    /// </summary>
    public enum CreateImageToVideoGenerationRequestModel
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
    public static class CreateImageToVideoGenerationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoGenerationRequestModel value)
        {
            return value switch
            {
                CreateImageToVideoGenerationRequestModel.MOTION2 => "MOTION2",
                CreateImageToVideoGenerationRequestModel.VEO3 => "VEO3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoGenerationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "MOTION2" => CreateImageToVideoGenerationRequestModel.MOTION2,
                "VEO3" => CreateImageToVideoGenerationRequestModel.VEO3,
                _ => null,
            };
        }
    }
}