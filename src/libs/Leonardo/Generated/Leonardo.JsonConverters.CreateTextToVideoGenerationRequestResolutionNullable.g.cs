#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToVideoGenerationRequestResolutionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.CreateTextToVideoGenerationRequestResolution?>
    {
        /// <inheritdoc />
        public override global::Leonardo.CreateTextToVideoGenerationRequestResolution? Read(
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
                        return global::Leonardo.CreateTextToVideoGenerationRequestResolutionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.CreateTextToVideoGenerationRequestResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.CreateTextToVideoGenerationRequestResolution?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.CreateTextToVideoGenerationRequestResolution? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Leonardo.CreateTextToVideoGenerationRequestResolutionExtensions.ToValueString(value.Value));
            }
        }
    }
}
