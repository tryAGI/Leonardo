
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
            typeof(global::Leonardo.JsonConverters.CostUnitJsonConverter),

            typeof(global::Leonardo.JsonConverters.CostUnitNullableJsonConverter),

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

            typeof(global::Leonardo.JsonConverters.ModelAssetTextureTypesJsonConverter),

            typeof(global::Leonardo.JsonConverters.ModelAssetTextureTypesNullableJsonConverter),

            typeof(global::Leonardo.JsonConverters.CustomModelTypeJsonConverter),

            typeof(global::Leonardo.JsonConverters.CustomModelTypeNullableJsonConverter),

            typeof(global::Leonardo.JsonConverters.SdGenerationSchedulersJsonConverter),

            typeof(global::Leonardo.JsonConverters.SdGenerationSchedulersNullableJsonConverter),

            typeof(global::Leonardo.JsonConverters.VariationTypeJsonConverter),

            typeof(global::Leonardo.JsonConverters.VariationTypeNullableJsonConverter),

            typeof(global::Leonardo.JsonConverters.MotionVariationTypeJsonConverter),

            typeof(global::Leonardo.JsonConverters.MotionVariationTypeNullableJsonConverter),

            typeof(global::Leonardo.JsonConverters.MotionResolutionJsonConverter),

            typeof(global::Leonardo.JsonConverters.MotionResolutionNullableJsonConverter),

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

            typeof(global::Leonardo.JsonConverters.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolutionJsonConverter),

            typeof(global::Leonardo.JsonConverters.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolutionNullableJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Cost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CostUnit), TypeInfoPropertyName = "CostUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Blueprint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintThumbnail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintThumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNodeUiMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNodeExecutability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.NodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.NodeInputSettingName), TypeInfoPropertyName = "NodeInputSettingName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>>), TypeInfoPropertyName = "OneOfStringIListTextVariable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.TextVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.TextVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ApiErrorLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ApiErrorLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.SdVersions), TypeInfoPropertyName = "SdVersions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Lora))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Strength), TypeInfoPropertyName = "Strength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionStatus), TypeInfoPropertyName = "BlueprintExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.AllOf<string, object>), TypeInfoPropertyName = "AllOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.NodeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.AllOf<bool?, object>), TypeInfoPropertyName = "AllOfBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGenerationsConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintExecutionGenerationEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGenerationEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGenerationStatus), TypeInfoPropertyName = "BlueprintExecutionGenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptModerationFailureReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptModerationFailureReasonType), TypeInfoPropertyName = "PromptModerationFailureReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ModelAssetTextureTypes), TypeInfoPropertyName = "ModelAssetTextureTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CustomModelType), TypeInfoPropertyName = "CustomModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.SdGenerationSchedulers), TypeInfoPropertyName = "SdGenerationSchedulers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.VariationType), TypeInfoPropertyName = "VariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.MotionVariationType), TypeInfoPropertyName = "MotionVariationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.MotionResolution), TypeInfoPropertyName = "MotionResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ControlnetInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ControlnetInputInitImageType), TypeInfoPropertyName = "ControlnetInputInitImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ControlnetInputStrengthType), TypeInfoPropertyName = "ControlnetInputStrengthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ElementInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UserElementsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.SdGenerationStyle), TypeInfoPropertyName = "SdGenerationStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.LcmGenerationStyle), TypeInfoPropertyName = "LcmGenerationStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UniversalUpscalerStyle), TypeInfoPropertyName = "UniversalUpscalerStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UniversalUpscalerUltraStyle), TypeInfoPropertyName = "UniversalUpscalerUltraStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ControlnetType), TypeInfoPropertyName = "ControlnetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorServices), TypeInfoPropertyName = "PricingCalculatorServices2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CanvasRequestType), TypeInfoPropertyName = "CanvasRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ControlnetInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ElementInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.UserElementsInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateGenerationRequestTransparency), TypeInfoPropertyName = "CreateGenerationRequestTransparency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateTextureGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateSVDMotionGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateImageToVideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateImageToVideoGenerationRequestImageType), TypeInfoPropertyName = "CreateImageToVideoGenerationRequestImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateImageToVideoGenerationRequestEndFrameImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateImageToVideoGenerationRequestEndFrameImageType), TypeInfoPropertyName = "CreateImageToVideoGenerationRequestEndFrameImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateTextToVideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVideoUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVideoUpscaleRequestResolution), TypeInfoPropertyName = "CreateVideoUpscaleRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateLCMGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformInstantRefineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformInpaintingLCMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformAlchemyUpscaleLCMRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationsByModelIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteTextureGenerationByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadModelAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Get3DModelsByUserIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Get3DModelByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Delete3DModelByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadInitImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadCanvasInitImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationUnzoomRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationNoBGRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateUniversalUpscalerJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadDatasetImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadDatasetImageFromGenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateElementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateElementRequestSdVersion), TypeInfoPropertyName = "CreateElementRequestSdVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptImproveRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsImageGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsMotionVideoGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution), TypeInfoPropertyName = "PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsLcmGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsModelTraining))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsTextureGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscaler))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscalerUltra))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsRequestPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsRequestPlatform), TypeInfoPropertyName = "ListBlueprintsRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetUserSelfResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetUserSelfResponseUserDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetUserSelfResponseUserDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetUserSelfResponseUserDetailUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateGenerationResponseSdGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationByIdResponseGenerationsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteGenerationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteGenerationByIdResponseDeleteGenerationsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationsByUserIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationsByUserIdResponseGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElementLora))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateTextureGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateTextureGenerationResponseTextureGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateSVDMotionGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateSVDMotionGenerationResponseMotionSvdGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateImageToVideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateImageToVideoGenerationResponseMotionVideoGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateTextToVideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateTextToVideoGenerationResponseMotionVideoGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVideoUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVideoUpscaleResponseMotionVideoGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateLCMGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateLCMGenerationResponseLcmGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformInstantRefineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformInstantRefineResponseLcmGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformInpaintingLCMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformInpaintingLCMResponseLcmGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformAlchemyUpscaleLCMResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PerformAlchemyUpscaleLCMResponseLcmGenerationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationsByModelIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteTextureGenerationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteTextureGenerationByIdResponseDeleteModelAssetTextureGenerationsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadModelAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadModelAssetResponseUploadModelAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Get3DModelsByUserIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Get3DModelsByUserIdResponseModelAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Get3DModelByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Get3DModelByIdResponseModelAssetsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Delete3DModelByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Delete3DModelByIdResponseDeleteModelAssetsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadInitImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadInitImageResponseUploadInitImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetInitImageByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetInitImageByIdResponseInitImagesByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteInitImageByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteInitImageByIdResponseDeleteInitImagesByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadCanvasInitImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationUnzoomResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationUnzoomResponseSdUnzoomJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationNoBGResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateVariationNoBGResponseSdNobgJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateUniversalUpscalerJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateUniversalUpscalerJobResponseUniversalUpscaler))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetVariationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetMotionVariationByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateDatasetResponseInsertDatasetsOne))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetDatasetByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetDatasetByIdResponseDatasetsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteDatasetByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteDatasetByIdResponseDeleteDatasetsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadDatasetImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadDatasetImageResponseUploadDatasetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadDatasetImageFromGenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateModelResponseSdTrainingJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetModelByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetModelByIdResponseCustomModelsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteModelByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetCustomModelsByUserIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetCustomModelsByUserIdResponseCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListPlatformModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ListPlatformModelsResponseCustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListPlatformModelsResponseCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetElementByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetElementByIdResponseUserLorasByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteElementByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetCustomElementsByUserIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetCustomElementsByUserIdResponseUserLora))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateElementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.CreateElementResponseSdTrainingJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListElementsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListElementsResponseLora))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptRandomResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptRandomResponsePromptGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptImproveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptImproveResponsePromptGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PricingCalculatorResponseCalculateProductionApiServiceCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfListBlueprintsResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsResponseBlueprints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsResponseBlueprintsEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ApiError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfGetBlueprintByIdResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfGetBlueprintVersionsByBlueprintIdResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfExecuteBlueprintResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintResponseExecuteBlueprint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfGetBlueprintExecutionResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintExecutionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintExecutionGenerationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintThumbnail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintVersionEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<string, global::System.Collections.Generic.List<global::Leonardo.TextVariable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.TextVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ApiErrorLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.NodeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintExecutionGenerationEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ControlnetInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ElementInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.UserElementsInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ListBlueprintsRequestPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetUserSelfResponseUserDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ListPlatformModelsResponseCustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ListElementsResponseLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ApiError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}