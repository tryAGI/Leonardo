
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Leonardo.Ai API OpenAPI specification.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ILeonardoApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset { get; }

        /// <summary>
        /// 
        /// </summary>
        public ElementsClient Elements { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageClient Image { get; }

        /// <summary>
        /// 
        /// </summary>
        public InitImagesClient InitImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public MotionClient Motion { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public PricingCalculatorClient PricingCalculator { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt { get; }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeCanvasClient RealtimeCanvas { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextureClient Texture { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public VariationClient Variation { get; }

        /// <summary>
        /// 
        /// </summary>
        public x3DModelAssetsClient x3DModelAssets { get; }

    }
}