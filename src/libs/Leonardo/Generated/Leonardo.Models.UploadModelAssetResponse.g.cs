
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadModelAssetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadModelAsset")]
        public global::Leonardo.UploadModelAssetResponseUploadModelAsset? UploadModelAsset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetResponse" /> class.
        /// </summary>
        /// <param name="uploadModelAsset"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadModelAssetResponse(
            global::Leonardo.UploadModelAssetResponseUploadModelAsset? uploadModelAsset)
        {
            this.UploadModelAsset = uploadModelAsset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetResponse" /> class.
        /// </summary>
        public UploadModelAssetResponse()
        {
        }
    }
}