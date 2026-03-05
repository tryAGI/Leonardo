
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Type indicating whether the end frame image is uploaded or generated.
    /// </summary>
    public enum CreateImageToVideoGenerationRequestEndFrameImageType
    {
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoGenerationRequestEndFrameImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoGenerationRequestEndFrameImageType value)
        {
            return value switch
            {
                CreateImageToVideoGenerationRequestEndFrameImageType.Generated => "GENERATED",
                CreateImageToVideoGenerationRequestEndFrameImageType.Uploaded => "UPLOADED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoGenerationRequestEndFrameImageType? ToEnum(string value)
        {
            return value switch
            {
                "GENERATED" => CreateImageToVideoGenerationRequestEndFrameImageType.Generated,
                "UPLOADED" => CreateImageToVideoGenerationRequestEndFrameImageType.Uploaded,
                _ => null,
            };
        }
    }
}