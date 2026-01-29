
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
            typeof(global::Leonardo.JsonConverters.NodeInputSettingNameJsonConverter),
            typeof(global::Leonardo.JsonConverters.NodeInputSettingNameNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdVersionsJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdVersionsNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.StrengthJsonConverter),
            typeof(global::Leonardo.JsonConverters.StrengthNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.JobStatusJsonConverter),
            typeof(global::Leonardo.JsonConverters.JobStatusNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.BlueprintExecutionStatusJsonConverter),
            typeof(global::Leonardo.JsonConverters.BlueprintExecutionStatusNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.BlueprintExecutionGenerationStatusJsonConverter),
            typeof(global::Leonardo.JsonConverters.BlueprintExecutionGenerationStatusNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.PromptModerationFailureReasonTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.PromptModerationFailureReasonTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.MODELASSETTEXTURETYPESJsonConverter),
            typeof(global::Leonardo.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.CustomModelTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.CustomModelTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdGenerationSchedulersJsonConverter),
            typeof(global::Leonardo.JsonConverters.SdGenerationSchedulersNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.VARIATIONTYPEJsonConverter),
            typeof(global::Leonardo.JsonConverters.VARIATIONTYPENullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.MOTIONVARIATIONTYPEJsonConverter),
            typeof(global::Leonardo.JsonConverters.MOTIONVARIATIONTYPENullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.MOTIONRESOLUTIONJsonConverter),
            typeof(global::Leonardo.JsonConverters.MOTIONRESOLUTIONNullableJsonConverter),
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
            typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestImageTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestImageTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestEndFrameImageTypeJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestEndFrameImageTypeNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateVideoUpscaleRequestResolutionJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateVideoUpscaleRequestResolutionNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateElementRequestSdVersionJsonConverter),
            typeof(global::Leonardo.JsonConverters.CreateElementRequestSdVersionNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolutionJsonConverter),
            typeof(global::Leonardo.JsonConverters.PricingCalculatorRequestServiceParamsVEO3MOTIONVIDEOGENERATIONResolutionNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.ListBlueprintsRequestPlatformJsonConverter),
            typeof(global::Leonardo.JsonConverters.ListBlueprintsRequestPlatformNullableJsonConverter),
            typeof(global::Leonardo.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>>),
            typeof(global::Leonardo.JsonConverters.AllOfJsonConverter<string, object>),
            typeof(global::Leonardo.JsonConverters.AllOfJsonConverter<bool?, object>),
            typeof(global::Leonardo.JsonConverters.AllOfJsonConverter<string, object>),
            typeof(global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>),
            typeof(global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>),
            typeof(global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>),
            typeof(global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>),
            typeof(global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>),
            typeof(global::Leonardo.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}