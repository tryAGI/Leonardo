
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
        public global::Leonardo.CreateLCMGenerationRequest? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineRequest? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMRequest? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMRequest? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdRequest? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdRequest? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdRequest? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetRequest? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdRequest? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdRequest? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdRequest? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageRequest? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageRequest? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomRequest? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleRequest? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGRequest? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobRequest? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetRequest? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageRequest? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenRequest? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequest? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelRequestSdVersion? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequest? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementRequestSdVersion? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveRequest? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequest? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParams? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsIMAGEGENERATION? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMOTIONGENERATION? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsLCMGENERATION? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsMODELTRAINING? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponse? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetUserSelfResponseUserDetail>? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetail? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetUserSelfResponseUserDetailUser? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponse? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateGenerationResponseSdGenerationJob? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponse? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPk? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImage? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElement? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponse? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteGenerationByIdResponseDeleteGenerationsByPk? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponse? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGeneration>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGeneration? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage>? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImage? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGeneratedImageGeneratedImageVariationGeneric? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement>? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElement? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponse? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateTextureGenerationResponseTextureGenerationJob? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponse? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateSVDMotionGenerationResponseMotionSvdGenerationJob? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponse? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateLCMGenerationResponseLcmGenerationJob? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponse? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponse? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformInpaintingLCMResponseLcmGenerationJob? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponse? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponse? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponse? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPk? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage>? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponse? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteTextureGenerationByIdResponseDeleteModelAssetTextureGenerationsByPk? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponse? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadModelAssetResponseUploadModelAsset? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponse? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.Get3DModelsByUserIdResponseModelAsset>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelsByUserIdResponseModelAsset? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponse? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponse? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.Delete3DModelByIdResponseDeleteModelAssetsByPk? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponse? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadInitImageResponseUploadInitImage? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponse? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetInitImageByIdResponseInitImagesByPk? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponse? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteInitImageByIdResponseDeleteInitImagesByPk? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponse? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponse? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUnzoomResponseSdUnzoomJob? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponse? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponse? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateVariationNoBGResponseSdNobgJob? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponse? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateUniversalUpscalerJobResponseUniversalUpscaler? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponse? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponse? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateDatasetResponseInsertDatasetsOne? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponse? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPk? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPkDatasetImage? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponse? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteDatasetByIdResponseDeleteDatasetsByPk? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponse? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageResponseUploadDatasetImage? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponse? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponse? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateModelResponseSdTrainingJob? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponse? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetModelByIdResponseCustomModelsByPk? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponse? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomModelsByUserIdResponseCustomModel? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponse? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListPlatformModelsResponseCustomModel>? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModel? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponse? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetElementByIdResponseUserLorasByPk? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponse? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponse? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.GetCustomElementsByUserIdResponseUserLora? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponse? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.CreateElementResponseSdTrainingJob? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponse? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.ListElementsResponseLora? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponse? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptRandomResponsePromptGeneration? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponse? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PromptImproveResponsePromptGeneration? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponse? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Leonardo.PricingCalculatorResponseCalculateProductionApiServiceCost? Type187 { get; set; }
    }
}