
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadMediaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadMedia")]
        public global::Leonardo.UploadMediaResponseUploadMedia? UploadMedia { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaResponse" /> class.
        /// </summary>
        /// <param name="uploadMedia"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadMediaResponse(
            global::Leonardo.UploadMediaResponseUploadMedia? uploadMedia)
        {
            this.UploadMedia = uploadMedia;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaResponse" /> class.
        /// </summary>
        public UploadMediaResponse()
        {
        }
    }
}