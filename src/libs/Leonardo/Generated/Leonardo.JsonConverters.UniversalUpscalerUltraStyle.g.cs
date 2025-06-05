#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class UniversalUpscalerUltraStyleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.UniversalUpscalerUltraStyle>
    {
        /// <inheritdoc />
        public override global::Leonardo.UniversalUpscalerUltraStyle Read(
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
                        return global::Leonardo.UniversalUpscalerUltraStyleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.UniversalUpscalerUltraStyle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.UniversalUpscalerUltraStyle);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.UniversalUpscalerUltraStyle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Leonardo.UniversalUpscalerUltraStyleExtensions.ToValueString(value));
        }
    }
}
