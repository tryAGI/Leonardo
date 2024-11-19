
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Leonardo.JsonConverters.SdVersionsJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdVersionsNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.StrengthJsonConverter),
            typeof(global::Leonardo.JsonConverters.StrengthNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.JobStatusJsonConverter),
            typeof(global::Leonardo.JsonConverters.JobStatusNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.MODELASSETTEXTURETYPESJsonConverter),
            typeof(global::Leonardo.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.CustomModelTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.CustomModelTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdGenerationSchedulersJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdGenerationSchedulersNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.VARIATIONTYPEJsonConverter),
            typeof(global::Leonardo.JsonConverters.VARIATIONTYPENullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.ControlnetInputInitImageTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.ControlnetInputInitImageTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.ControlnetInputStrengthTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.ControlnetInputStrengthTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdGenerationStyleJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdGenerationStyleNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.LcmGenerationStyleJsonConverter),
            typeof(global::Leonardo.JsonConverters.LcmGenerationStyleNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.UniversalUpscalerStyleJsonConverter),
            typeof(global::Leonardo.JsonConverters.UniversalUpscalerStyleNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.UniversalUpscalerUltraStyleJsonConverter),
            typeof(global::Leonardo.JsonConverters.UniversalUpscalerUltraStyleNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.ControlnetTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.ControlnetTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.PricingCalculatorServicesJsonConverter),
            typeof(global::Leonardo.JsonConverters.PricingCalculatorServicesNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.CanvasRequestTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.CanvasRequestTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateGenerationRequestTransparencyJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateGenerationRequestTransparencyNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}