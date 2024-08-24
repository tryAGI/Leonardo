#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class MODELASSETTEXTURETYPESNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.MODELASSETTEXTURETYPES?>
    {
        /// <inheritdoc />
        public override global::Leonardo.MODELASSETTEXTURETYPES? Read(
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
                        return global::Leonardo.MODELASSETTEXTURETYPESExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.MODELASSETTEXTURETYPES)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.MODELASSETTEXTURETYPES? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Leonardo.MODELASSETTEXTURETYPESExtensions.ToValueString(value.Value));
            }
        }
    }
}
