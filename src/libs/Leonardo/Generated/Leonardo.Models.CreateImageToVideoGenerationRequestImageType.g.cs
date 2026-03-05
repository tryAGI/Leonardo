
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Type indicating whether the init image is uploaded or generated. Use only image or imageId with imageType.
    /// </summary>
    public enum CreateImageToVideoGenerationRequestImageType
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
    public static class CreateImageToVideoGenerationRequestImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoGenerationRequestImageType value)
        {
            return value switch
            {
                CreateImageToVideoGenerationRequestImageType.Generated => "GENERATED",
                CreateImageToVideoGenerationRequestImageType.Uploaded => "UPLOADED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoGenerationRequestImageType? ToEnum(string value)
        {
            return value switch
            {
                "GENERATED" => CreateImageToVideoGenerationRequestImageType.Generated,
                "UPLOADED" => CreateImageToVideoGenerationRequestImageType.Uploaded,
                _ => null,
            };
        }
    }
}