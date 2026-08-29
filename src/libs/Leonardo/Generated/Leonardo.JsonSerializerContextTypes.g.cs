
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Leonardo
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Cost? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CostUnit? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Blueprint? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.BlueprintThumbnail>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintThumbnail? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintVersion? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdge>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintVersionEdge? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintVersionEdgeNode? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintVersionEdgeNodeUiMetadata? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintVersionEdgeNodeExecutability? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintVersionPageInfo? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.NodeInput? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.NodeInputSettingName? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.TextVariable>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.TextVariable? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ApiError? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ApiErrorLocation>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ApiErrorLocation? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.SdVersions? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Lora? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Strength? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.JobStatus? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintExecutionStatus? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintExecution? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.AllOf<string, object>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.NodeInput>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.AllOf<bool?, object>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintExecutionGenerationsConnection? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PageInfo? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.BlueprintExecutionGenerationEdge>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintExecutionGenerationEdge? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintExecutionGeneration? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.BlueprintExecutionGenerationStatus? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptModerationFailureReason? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptModerationFailureReasonType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CustomModelType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.SdGenerationSchedulers? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.VariationType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.MotionVariationType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.MotionResolution? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ControlnetInput? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ControlnetInputInitImageType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ControlnetInputStrengthType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ElementInput? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UserElementsInput? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.SdGenerationStyle? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.LcmGenerationStyle? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UniversalUpscalerStyle? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UniversalUpscalerUltraStyle? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ControlnetType? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorServices? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CanvasRequestType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateGenerationRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ControlnetInput>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ElementInput>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.UserElementsInput>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateGenerationRequestTransparency? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationRequest? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationRequestImageType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationRequestEndFrameImage? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationRequestEndFrameImageType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateLCMGenerationRequest? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInstantRefineRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMRequest? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadModelAssetRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdRequest? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelByIdRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Delete3DModelByIdRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadInitImageRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadMediaRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationNoBGRequest? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateDatasetRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateModelRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementRequestSdVersion? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptImproveRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParams? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsImageGeneration? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMotionVideoGeneration? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsLcmGeneration? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsModelTraining? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsTextureGeneration? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscaler? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscalerUltra? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsRequest? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsRequestPlatform>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsRequestPlatform? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintRequestInput? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int?>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUserSelfResponse? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetUserSelfResponseUserDetail>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetail? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetailUser? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateGenerationResponse? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateGenerationResponseSdGenerationJob? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPk? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponseDeleteGenerationsByPk? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGeneration>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGeneration? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponseMotionVideoGenerationJob? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponseMotionVideoGenerationJob? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponseLcmGenerationJob? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponse? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponseLcmGenerationJob? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponse? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadModelAssetResponse? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadModelAssetResponseUploadModelAsset? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponseModelAsset? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponseDeleteModelAssetsByPk? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadInitImageResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadInitImageResponseUploadInitImage? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadMediaResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadMediaResponseUploadMedia? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUploadedMediaByIdResponse? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUploadedMediaByIdResponseUploadedMediaByPk? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteUploadedMediaByIdResponse? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteUploadedMediaByIdResponseDeleteUploadedMediaByPk? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponse? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponseInitImagesByPk? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponseDeleteInitImagesByPk? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponseSdUnzoomJob? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponseSdNobgJob? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponseUniversalUpscaler? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetVariationByIdResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetMotionVariationByIdResponse? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateDatasetResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateDatasetResponseInsertDatasetsOne? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponse? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPk? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponse? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponseDeleteDatasetsByPk? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponseUploadDatasetImage? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateModelResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateModelResponseSdTrainingJob? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetModelByIdResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetModelByIdResponseCustomModelsByPk? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponse? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel?>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponseCustomModel? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListPlatformModelsResponseCustomModel>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModel? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetElementByIdResponse? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetElementByIdResponseUserLorasByPk? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora?>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponseUserLora? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementResponseSdTrainingJob? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListElementsResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListElementsResponseLora? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptRandomResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptRandomResponsePromptGeneration? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptImproveResponse? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptImproveResponsePromptGeneration? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorResponseCalculateProductionApiServiceCost? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsResponse2? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsResponseBlueprints? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsResponseBlueprintsEdge? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ApiError>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintByIdResponse2? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintResponse2? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintResponseExecuteBlueprint? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintResponse3? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintExecutionResponse2? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintExecutionGenerationsResponse? Type249 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.BlueprintThumbnail>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.BlueprintVersionEdge>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<string, global::System.Collections.Generic.List<global::Leonardo.TextVariable>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.TextVariable>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ApiErrorLocation>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.NodeInput>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.BlueprintExecutionGenerationEdge>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ControlnetInput>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ElementInput>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.UserElementsInput>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ListBlueprintsRequestPlatform>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int?>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetUserSelfResponseUserDetail>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGeneration>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel?>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ListPlatformModelsResponseCustomModel>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.GetCustomElementsByUserIdResponseUserLora?>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ListElementsResponseLora>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.ApiError>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>? ListType36 { get; set; }
    }
}