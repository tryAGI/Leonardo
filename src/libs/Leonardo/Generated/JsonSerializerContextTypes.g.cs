
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
        public global::Leonardo.CreateTextToVideoGenerationRequest? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationRequest? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineRequest? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMRequest? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMRequest? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdRequest? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdRequest? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdRequest? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetRequest? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdRequest? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdRequest? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdRequest? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageRequest? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageRequest? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomRequest? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleRequest? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGRequest? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobRequest? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetRequest? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageRequest? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenRequest? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequest? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequestSdVersion? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequest? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequestSdVersion? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveRequest? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequest? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParams? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsIMAGEGENERATION? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONGENERATION? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsLCMGENERATION? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAINING? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponse? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetUserSelfResponseUserDetail>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetail? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetailUser? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponse? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponseSdGenerationJob? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponse? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPk? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponse? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponseDeleteGenerationsByPk? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponse? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGeneration>? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGeneration? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponse? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponseTextureGenerationJob? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponse? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponseMotionSvdGenerationJob? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponse? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextToVideoGenerationResponseMotionVideoGenerationJob? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponse? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponseLcmGenerationJob? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponse? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponse? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponseLcmGenerationJob? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponse? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponse? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponse? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPk? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponse? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponseDeleteModelAssetTextureGenerationsByPk? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponse? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponseUploadModelAsset? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponse? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponseModelAsset? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponse? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponse? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponseDeleteModelAssetsByPk? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponse? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponseUploadInitImage? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponse? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponseInitImagesByPk? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponse? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponseDeleteInitImagesByPk? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponse? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponse? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponseSdUnzoomJob? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponse? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponse? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponseSdNobgJob? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponse? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponseUniversalUpscaler? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponse? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponse? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponseInsertDatasetsOne? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponse? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPk? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponse? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponseDeleteDatasetsByPk? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponse? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponseUploadDatasetImage? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponse? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponse? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponseSdTrainingJob? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponse? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponseCustomModelsByPk? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponse? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponse? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponseCustomModel? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponse? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListPlatformModelsResponseCustomModel>? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModel? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponse? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponseUserLorasByPk? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponse? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponse? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponseUserLora? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponse? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponseSdTrainingJob? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponse? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponseLora? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponse? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponsePromptGeneration? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponse? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponsePromptGeneration? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponse? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponseCalculateProductionApiServiceCost? Type190 { get; set; }
    }
}