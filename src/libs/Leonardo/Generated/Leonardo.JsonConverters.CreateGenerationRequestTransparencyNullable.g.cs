#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGenerationRequestTransparencyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.CreateGenerationRequestTransparency?>
    {
        /// <inheritdoc />
        public override global::Leonardo.CreateGenerationRequestTransparency? Read(
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
                        return global::Leonardo.CreateGenerationRequestTransparencyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.CreateGenerationRequestTransparency)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.CreateGenerationRequestTransparency?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.CreateGenerationRequestTransparency? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Leonardo.CreateGenerationRequestTransparencyExtensions.ToValueString(value.Value));
            }
        }
    }
}
