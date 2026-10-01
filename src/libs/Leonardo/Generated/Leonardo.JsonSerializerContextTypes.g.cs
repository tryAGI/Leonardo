
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
        public global::Leonardo.PerformAlchemyUpscaleLCMRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadModelAssetRequest? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelByIdRequest? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Delete3DModelByIdRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadInitImageRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadMediaRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationNoBGRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobRequest? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateDatasetRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateModelRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementRequestSdVersion? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptImproveRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParams? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsImageGeneration? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMotionVideoGeneration? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGeneration? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsVeo3MotionVideoGenerationResolution? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsLcmGeneration? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsModelTraining? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsTextureGeneration? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscaler? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUniversalUpscalerUltra? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsRequestPlatform>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsRequestPlatform? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintRequest? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintRequestInput? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int?>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUserSelfResponse? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetUserSelfResponseUserDetail>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetail? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetailUser? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateGenerationResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateGenerationResponseSdGenerationJob? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponse? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPk? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponseDeleteGenerationsByPk? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGeneration>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGeneration? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponseMotionVideoGenerationJob? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponseMotionVideoGenerationJob? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponseLcmGenerationJob? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponse? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadModelAssetResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadModelAssetResponseUploadModelAsset? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponseModelAsset? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponse? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponseDeleteModelAssetsByPk? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadInitImageResponse? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadInitImageResponseUploadInitImage? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadMediaResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadMediaResponseUploadMedia? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUploadedMediaByIdResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetUploadedMediaByIdResponseUploadedMediaByPk? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteUploadedMediaByIdResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteUploadedMediaByIdResponseDeleteUploadedMediaByPk? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponseInitImagesByPk? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponseDeleteInitImagesByPk? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponseSdUnzoomJob? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponseSdNobgJob? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponseUniversalUpscaler? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetVariationByIdResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetMotionVariationByIdResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateDatasetResponse? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateDatasetResponseInsertDatasetsOne? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPk? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponseDeleteDatasetsByPk? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponse? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponseUploadDatasetImage? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateModelResponse? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateModelResponseSdTrainingJob? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetModelByIdResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetModelByIdResponseCustomModelsByPk? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponse? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel?>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponseCustomModel? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListPlatformModelsResponseCustomModel>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModel? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetElementByIdResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetElementByIdResponseUserLorasByPk? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora?>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponseUserLora? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.CreateElementResponseSdTrainingJob? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListElementsResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListElementsResponseLora? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptRandomResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptRandomResponsePromptGeneration? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptImproveResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PromptImproveResponsePromptGeneration? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.PricingCalculatorResponseCalculateProductionApiServiceCost? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsResponse2? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsResponseBlueprints? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ListBlueprintsResponseBlueprintsEdge? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ApiError>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintByIdResponse2? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintResponse2? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintResponseExecuteBlueprint? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.ExecuteBlueprintResponse3? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintExecutionResponse2? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Leonardo.GetBlueprintExecutionGenerationsResponse? Type246 { get; set; }

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