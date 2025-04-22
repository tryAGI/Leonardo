
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
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.SdVersions? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Lora? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Strength? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.JobStatus? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.MODELASSETTEXTURETYPES? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CustomModelType? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.SdGenerationSchedulers? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.VARIATIONTYPE? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ControlnetInput? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ControlnetInputInitImageType? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ControlnetInputStrengthType? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ElementInput? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UserElementsInput? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.SdGenerationStyle? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.LcmGenerationStyle? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UniversalUpscalerStyle? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UniversalUpscalerUltraStyle? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ControlnetType? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorServices? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CanvasRequestType? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationRequest? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ControlnetInput>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ElementInput>? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.UserElementsInput>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationRequestTransparency? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationRequest? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationRequest? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationRequest? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationRequestImageType? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationRequest? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationRequest? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineRequest? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMRequest? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMRequest? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdRequest? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdRequest? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdRequest? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetRequest? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdRequest? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdRequest? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdRequest? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageRequest? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageRequest? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomRequest? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleRequest? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGRequest? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobRequest? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetRequest? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageRequest? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenRequest? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequest? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequestSdVersion? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequest? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequestSdVersion? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveRequest? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequest? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParams? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsIMAGEGENERATION? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONGENERATION? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsLCMGENERATION? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAINING? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponse? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetUserSelfResponseUserDetail>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetail? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetailUser? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponse? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponseSdGenerationJob? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponse? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPk? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponse? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponseDeleteGenerationsByPk? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponse? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGeneration>? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGeneration? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponse? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponseTextureGenerationJob? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponse? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponseMotionSvdGenerationJob? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponse? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponseMotionVideoGenerationJob? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponse? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponseMotionVideoGenerationJob? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponse? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponseLcmGenerationJob? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponse? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponse? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponseLcmGenerationJob? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponse? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponse? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponse? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPk? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage>? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponse? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponseDeleteModelAssetTextureGenerationsByPk? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponse? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponseUploadModelAsset? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponse? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponseModelAsset? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponse? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponse? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponseDeleteModelAssetsByPk? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponse? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponseUploadInitImage? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponse? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponseInitImagesByPk? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponse? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponseDeleteInitImagesByPk? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponse? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponse? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponseSdUnzoomJob? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponse? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponse? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponseSdNobgJob? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponse? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponseUniversalUpscaler? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponse? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponse? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponseInsertDatasetsOne? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponse? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPk? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponseDeleteDatasetsByPk? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponse? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponseUploadDatasetImage? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponse? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponse? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponseSdTrainingJob? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponse? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponseCustomModelsByPk? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponse? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponse? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponseCustomModel? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponse? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListPlatformModelsResponseCustomModel>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModel? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponse? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponseUserLorasByPk? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponse? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponse? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponseUserLora? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponse? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponseSdTrainingJob? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponse? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponseLora? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponse? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponsePromptGeneration? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponse? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponsePromptGeneration? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponse? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponseCalculateProductionApiServiceCost? Type197 { get; set; }
    }
}