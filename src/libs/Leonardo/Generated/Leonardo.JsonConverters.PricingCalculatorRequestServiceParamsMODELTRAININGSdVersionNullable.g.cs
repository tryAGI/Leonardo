#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class PricingCalculatorRequestServiceParamsMODELTRAININGSdVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion?>
    {
        /// <inheritdoc />
        public override global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion? Read(
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
                        return global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
