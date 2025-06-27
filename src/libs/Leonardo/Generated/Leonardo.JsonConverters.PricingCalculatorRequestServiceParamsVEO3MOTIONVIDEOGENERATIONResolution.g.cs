#nullable enable

namespace Leonardo.JsonConverters
{
    /// <inheritdoc />
    public sealed class PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolutionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Leonardo.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution>
    {
        /// <inheritdoc />
        public override global::Leonardo.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution Read(
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
                        return global::Leonardo.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolutionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Leonardo.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Leonardo.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Leonardo.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolution value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Leonardo.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolutionExtensions.ToValueString(value));
        }
    }
}
