
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCanvasInitImageResponseUploadCanvasInitImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initImageId")]
        public string? InitImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initFields")]
        public string? InitFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initKey")]
        public string? InitKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initUrl")]
        public string? InitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskImageId")]
        public string? MaskImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskFields")]
        public string? MaskFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskKey")]
        public string? MaskKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskUrl")]
        public string? MaskUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageResponseUploadCanvasInitImage" /> class.
        /// </summary>
        /// <param name="initImageId"></param>
        /// <param name="initFields"></param>
        /// <param name="initKey"></param>
        /// <param name="initUrl"></param>
        /// <param name="maskImageId"></param>
        /// <param name="maskFields"></param>
        /// <param name="maskKey"></param>
        /// <param name="maskUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadCanvasInitImageResponseUploadCanvasInitImage(
            string? initImageId,
            string? initFields,
            string? initKey,
            string? initUrl,
            string? maskImageId,
            string? maskFields,
            string? maskKey,
            string? maskUrl)
        {
            this.InitImageId = initImageId;
            this.InitFields = initFields;
            this.InitKey = initKey;
            this.InitUrl = initUrl;
            this.MaskImageId = maskImageId;
            this.MaskFields = maskFields;
            this.MaskKey = maskKey;
            this.MaskUrl = maskUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageResponseUploadCanvasInitImage" /> class.
        /// </summary>
        public UploadCanvasInitImageResponseUploadCanvasInitImage()
        {
        }
    }
}