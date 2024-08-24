
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Leonardo.Ai API OpenAPI specification.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LeonardoApi : global::System.IDisposable
    {
        /// <summary>
        /// Leonardo.Ai API server
        /// </summary>
        public const string BaseUrl = "https://cloud.leonardo.ai/api/rest/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;


        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset => new DatasetClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ElementsClient Elements => new ElementsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ImageClient Image => new ImageClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public InitImagesClient InitImages => new InitImagesClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public MotionClient Motion => new MotionClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public PricingCalculatorClient PricingCalculator => new PricingCalculatorClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public RealtimeCanvasClient RealtimeCanvas => new RealtimeCanvasClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public TextureClient Texture => new TextureClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public VariationClient Variation => new VariationClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public x3DModelAssetsClient x3DModelAssets => new x3DModelAssetsClient(_httpClient);

        /// <summary>
        /// Creates a new instance of the LeonardoApi.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param> 
        public LeonardoApi(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null 
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}