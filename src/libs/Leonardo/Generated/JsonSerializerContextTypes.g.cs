
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
        public global::Leonardo.CreateTextToVideoGenerationRequest? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationRequest? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineRequest? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMRequest? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMRequest? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdRequest? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdRequest? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdRequest? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetRequest? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdRequest? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdRequest? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdRequest? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageRequest? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageRequest? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomRequest? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleRequest? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGRequest? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobRequest? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetRequest? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageRequest? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenRequest? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequest? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequestSdVersion? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequest? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequestSdVersion? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveRequest? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequest? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParams? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsIMAGEGENERATION? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONGENERATION? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsLCMGENERATION? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAINING? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponse? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetUserSelfResponseUserDetail>? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetail? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetailUser? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponse? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponseSdGenerationJob? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponse? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPk? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponse? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponseDeleteGenerationsByPk? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponse? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGeneration>? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGeneration? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponse? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponseTextureGenerationJob? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponse? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponseMotionSvdGenerationJob? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponse? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateImageToVideoGenerationResponseMotionVideoGenerationJob? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponse? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponseMotionVideoGenerationJob? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponse? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponseLcmGenerationJob? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponse? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponse? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponseLcmGenerationJob? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponse? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponse? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponse? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPk? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponse? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponseDeleteModelAssetTextureGenerationsByPk? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponse? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponseUploadModelAsset? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponse? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponseModelAsset? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponse? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponse? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponseDeleteModelAssetsByPk? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponse? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponseUploadInitImage? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponse? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponseInitImagesByPk? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponse? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponseDeleteInitImagesByPk? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponse? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponse? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponseSdUnzoomJob? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponse? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponse? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponseSdNobgJob? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponse? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponseUniversalUpscaler? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponse? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponse? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponseInsertDatasetsOne? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponse? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPk? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponse? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponseDeleteDatasetsByPk? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponse? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponseUploadDatasetImage? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponse? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponse? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponseSdTrainingJob? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponse? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponseCustomModelsByPk? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponse? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponse? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponseCustomModel? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponse? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListPlatformModelsResponseCustomModel>? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModel? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponse? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponseUserLorasByPk? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponse? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponse? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponseUserLora? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponse? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponseSdTrainingJob? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponse? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponseLora? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponse? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponsePromptGeneration? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponse? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponsePromptGeneration? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponse? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponseCalculateProductionApiServiceCost? Type194 { get; set; }
    }
}