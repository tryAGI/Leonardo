
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
            typeof(global::OpenApiGenerator.JsonConverters.SdVersionsJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SdVersionsNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StrengthJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StrengthNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.JobStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.JobStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MODELASSETTEXTURETYPESJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CustomModelTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CustomModelTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SdGenerationSchedulersJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SdGenerationSchedulersNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.VARIATIONTYPEJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.VARIATIONTYPENullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ControlnetInputInitImageTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ControlnetInputInitImageTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ControlnetInputStrengthTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ControlnetInputStrengthTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SdGenerationStyleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SdGenerationStyleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LcmGenerationStyleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LcmGenerationStyleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.UniversalUpscalerStyleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.UniversalUpscalerStyleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.UniversalUpscalerUltraStyleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.UniversalUpscalerUltraStyleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ControlnetTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ControlnetTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.PricingCalculatorServicesJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.PricingCalculatorServicesNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CanvasRequestTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CanvasRequestTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CreateGenerationRequestTransparencyJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CreateGenerationRequestTransparencyNullableJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}