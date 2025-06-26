#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToVideoGenerationRequestModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.CreateTextToVideoGenerationRequestModel>
    {
        /// <inheritdoc />
        public override global::Leonardo.CreateTextToVideoGenerationRequestModel Read(
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
                        return global::Leonardo.CreateTextToVideoGenerationRequestModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.CreateTextToVideoGenerationRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.CreateTextToVideoGenerationRequestModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.CreateTextToVideoGenerationRequestModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Leonardo.CreateTextToVideoGenerationRequestModelExtensions.ToValueString(value));
        }
    }
}
