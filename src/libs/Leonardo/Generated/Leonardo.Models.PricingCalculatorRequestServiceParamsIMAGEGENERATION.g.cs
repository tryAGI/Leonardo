
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for IMAGE_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsIMAGEGENERATION
    {
        /// <summary>
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageHeight")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageWidth")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numImages")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The Step Count to use for the generation. Must be between 10 and 60.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferenceSteps")]
        public int? InferenceSteps { get; set; }

        /// <summary>
        /// Enable to use Prompt Magic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagic")]
        public bool? PromptMagic { get; set; }

        /// <summary>
        /// Strength of prompt magic. Must be a float between 0.1 and 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicStrength")]
        public double? PromptMagicStrength { get; set; }

        /// <summary>
        /// Prompt magic version v2 or v3, for use when promptMagic: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicVersion")]
        public string? PromptMagicVersion { get; set; }

        /// <summary>
        /// Enable to use Alchemy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alchemyMode")]
        public bool? AlchemyMode { get; set; }

        /// <summary>
        /// Enable to use PhotoReal. Requires enabling alchemy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoRealMode")]
        public bool? PhotoRealMode { get; set; }

        /// <summary>
        /// Depth of field of photoReal. Must be 0.55 for low, 0.5 for medium, or 0.45 for high. Defaults to 0.55 if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoRealStrength")]
        public double? PhotoRealStrength { get; set; }

        /// <summary>
        /// The version of photoReal to use. Must be v1 or v2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoRealVersion")]
        public string? PhotoRealVersion { get; set; }

        /// <summary>
        /// Enable to use high resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highResolution")]
        public bool? HighResolution { get; set; }

        /// <summary>
        /// The number of elements used for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loraCount")]
        public int? LoraCount { get; set; }

        /// <summary>
        /// Enable to use custom model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isModelCustom")]
        public bool? IsModelCustom { get; set; }

        /// <summary>
        /// The total cost of controlnets input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlnetsCost")]
        public int? ControlnetsCost { get; set; }

        /// <summary>
        /// Enable to use Phoenix model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPhoenix")]
        public bool? IsPhoenix { get; set; }

        /// <summary>
        /// Enable to use SDXL model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSDXL")]
        public bool? IsSDXL { get; set; }

        /// <summary>
        /// Enable to use SDXL Lightning model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSDXLLightning")]
        public bool? IsSDXLLightning { get; set; }

        /// <summary>
        /// Enable to use Ultra mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isUltra")]
        public bool? IsUltra { get; set; }

        /// <summary>
        /// Enable to use Flux Schnell model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFluxSchnell")]
        public bool? IsFluxSchnell { get; set; }

        /// <summary>
        /// Enable to use Flux Dev model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFluxDev")]
        public bool? IsFluxDev { get; set; }

        /// <summary>
        /// Enable to use Flux Kontext model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFluxKontext")]
        public bool? IsFluxKontext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsIMAGEGENERATION" /> class.
        /// </summary>
        /// <param name="imageHeight">
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </param>
        /// <param name="imageWidth">
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.
        /// </param>
        /// <param name="inferenceSteps">
        /// The Step Count to use for the generation. Must be between 10 and 60.
        /// </param>
        /// <param name="promptMagic">
        /// Enable to use Prompt Magic.
        /// </param>
        /// <param name="promptMagicStrength">
        /// Strength of prompt magic. Must be a float between 0.1 and 1.0
        /// </param>
        /// <param name="promptMagicVersion">
        /// Prompt magic version v2 or v3, for use when promptMagic: true
        /// </param>
        /// <param name="alchemyMode">
        /// Enable to use Alchemy.
        /// </param>
        /// <param name="photoRealMode">
        /// Enable to use PhotoReal. Requires enabling alchemy.
        /// </param>
        /// <param name="photoRealStrength">
        /// Depth of field of photoReal. Must be 0.55 for low, 0.5 for medium, or 0.45 for high. Defaults to 0.55 if not specified.
        /// </param>
        /// <param name="photoRealVersion">
        /// The version of photoReal to use. Must be v1 or v2.
        /// </param>
        /// <param name="highResolution">
        /// Enable to use high resolution.
        /// </param>
        /// <param name="loraCount">
        /// The number of elements used for the generation.
        /// </param>
        /// <param name="isModelCustom">
        /// Enable to use custom model.
        /// </param>
        /// <param name="controlnetsCost">
        /// The total cost of controlnets input.
        /// </param>
        /// <param name="isPhoenix">
        /// Enable to use Phoenix model.
        /// </param>
        /// <param name="isSDXL">
        /// Enable to use SDXL model.
        /// </param>
        /// <param name="isSDXLLightning">
        /// Enable to use SDXL Lightning model.
        /// </param>
        /// <param name="isUltra">
        /// Enable to use Ultra mode.
        /// </param>
        /// <param name="isFluxSchnell">
        /// Enable to use Flux Schnell model.
        /// </param>
        /// <param name="isFluxDev">
        /// Enable to use Flux Dev model.
        /// </param>
        /// <param name="isFluxKontext">
        /// Enable to use Flux Kontext model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParamsIMAGEGENERATION(
            int? imageHeight,
            int? imageWidth,
            int? numImages,
            int? inferenceSteps,
            bool? promptMagic,
            double? promptMagicStrength,
            string? promptMagicVersion,
            bool? alchemyMode,
            bool? photoRealMode,
            double? photoRealStrength,
            string? photoRealVersion,
            bool? highResolution,
            int? loraCount,
            bool? isModelCustom,
            int? controlnetsCost,
            bool? isPhoenix,
            bool? isSDXL,
            bool? isSDXLLightning,
            bool? isUltra,
            bool? isFluxSchnell,
            bool? isFluxDev,
            bool? isFluxKontext)
        {
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
            this.NumImages = numImages;
            this.InferenceSteps = inferenceSteps;
            this.PromptMagic = promptMagic;
            this.PromptMagicStrength = promptMagicStrength;
            this.PromptMagicVersion = promptMagicVersion;
            this.AlchemyMode = alchemyMode;
            this.PhotoRealMode = photoRealMode;
            this.PhotoRealStrength = photoRealStrength;
            this.PhotoRealVersion = photoRealVersion;
            this.HighResolution = highResolution;
            this.LoraCount = loraCount;
            this.IsModelCustom = isModelCustom;
            this.ControlnetsCost = controlnetsCost;
            this.IsPhoenix = isPhoenix;
            this.IsSDXL = isSDXL;
            this.IsSDXLLightning = isSDXLLightning;
            this.IsUltra = isUltra;
            this.IsFluxSchnell = isFluxSchnell;
            this.IsFluxDev = isFluxDev;
            this.IsFluxKontext = isFluxKontext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsIMAGEGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsIMAGEGENERATION()
        {
        }
    }
}