
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCanvasInitImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadCanvasInitImage")]
        public global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? UploadCanvasInitImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageResponse" /> class.
        /// </summary>
        /// <param name="uploadCanvasInitImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadCanvasInitImageResponse(
            global::Leonardo.UploadCanvasInitImageResponseUploadCanvasInitImage? uploadCanvasInitImage)
        {
            this.UploadCanvasInitImage = uploadCanvasInitImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageResponse" /> class.
        /// </summary>
        public UploadCanvasInitImageResponse()
        {
        }
    }
}