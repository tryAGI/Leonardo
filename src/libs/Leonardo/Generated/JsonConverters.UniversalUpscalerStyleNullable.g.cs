#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class UniversalUpscalerStyleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.UniversalUpscalerStyle?>
    {
        /// <inheritdoc />
        public override global::Leonardo.UniversalUpscalerStyle? Read(
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
                        return global::Leonardo.UniversalUpscalerStyleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.UniversalUpscalerStyle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.UniversalUpscalerStyle?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.UniversalUpscalerStyle? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Leonardo.UniversalUpscalerStyleExtensions.ToValueString(value.Value));
            }
        }
    }
}
