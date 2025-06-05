#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateImageToVideoGenerationRequestImageTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.CreateImageToVideoGenerationRequestImageType>
    {
        /// <inheritdoc />
        public override global::Leonardo.CreateImageToVideoGenerationRequestImageType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Leonardo.CreateImageToVideoGenerationRequestImageTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.CreateImageToVideoGenerationRequestImageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.CreateImageToVideoGenerationRequestImageType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.CreateImageToVideoGenerationRequestImageType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Leonardo.CreateImageToVideoGenerationRequestImageTypeExtensions.ToValueString(value));
        }
    }
}
