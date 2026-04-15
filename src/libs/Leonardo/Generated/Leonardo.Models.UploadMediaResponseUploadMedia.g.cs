
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadMediaResponseUploadMedia
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadId")]
        public string? UploadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public string? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaResponseUploadMedia" /> class.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="url"></param>
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadMediaResponseUploadMedia(
            string? uploadId,
            string? url,
            string? fields)
        {
            this.UploadId = uploadId;
            this.Url = url;
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaResponseUploadMedia" /> class.
        /// </summary>
        public UploadMediaResponseUploadMedia()
        {
        }
    }
}