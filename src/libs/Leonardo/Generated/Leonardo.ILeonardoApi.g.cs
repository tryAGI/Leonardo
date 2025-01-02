
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
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Leonardo.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

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
        public StylesClient Styles { get; }

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