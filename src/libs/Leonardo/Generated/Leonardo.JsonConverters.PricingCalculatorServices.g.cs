#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class PricingCalculatorServicesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.PricingCalculatorServices>
    {
        /// <inheritdoc />
        public override global::Leonardo.PricingCalculatorServices Read(
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
                        return global::Leonardo.PricingCalculatorServicesExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.PricingCalculatorServices)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.PricingCalculatorServices);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.PricingCalculatorServices value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Leonardo.PricingCalculatorServicesExtensions.ToValueString(value));
        }
    }
}
