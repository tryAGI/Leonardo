#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class BlueprintExecutionGenerationStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.BlueprintExecutionGenerationStatus?>
    {
        /// <inheritdoc />
        public override global::Leonardo.BlueprintExecutionGenerationStatus? Read(
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
                        return global::Leonardo.BlueprintExecutionGenerationStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.BlueprintExecutionGenerationStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.BlueprintExecutionGenerationStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.BlueprintExecutionGenerationStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Leonardo.BlueprintExecutionGenerationStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
