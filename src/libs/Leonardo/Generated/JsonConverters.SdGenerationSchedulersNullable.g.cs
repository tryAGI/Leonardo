#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class SdGenerationSchedulersNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.SdGenerationSchedulers?>
    {
        /// <inheritdoc />
        public override global::Leonardo.SdGenerationSchedulers? Read(
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
                        return global::Leonardo.SdGenerationSchedulersExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.SdGenerationSchedulers)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.SdGenerationSchedulers?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.SdGenerationSchedulers? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Leonardo.SdGenerationSchedulersExtensions.ToValueString(value.Value));
            }
        }
    }
}
