#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptModerationFailureReasonTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.PromptModerationFailureReasonType>
    {
        /// <inheritdoc />
        public override global::Leonardo.PromptModerationFailureReasonType Read(
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
                        return global::Leonardo.PromptModerationFailureReasonTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.PromptModerationFailureReasonType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.PromptModerationFailureReasonType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.PromptModerationFailureReasonType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Leonardo.PromptModerationFailureReasonTypeExtensions.ToValueString(value));
        }
    }
}
