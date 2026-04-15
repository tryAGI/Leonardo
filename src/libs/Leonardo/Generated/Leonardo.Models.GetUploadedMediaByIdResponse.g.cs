
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUploadedMediaByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_media_by_pk")]
        public global::Leonardo.GetUploadedMediaByIdResponseUploadedMediaByPk? UploadedMediaByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadedMediaByIdResponse" /> class.
        /// </summary>
        /// <param name="uploadedMediaByPk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUploadedMediaByIdResponse(
            global::Leonardo.GetUploadedMediaByIdResponseUploadedMediaByPk? uploadedMediaByPk)
        {
            this.UploadedMediaByPk = uploadedMediaByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadedMediaByIdResponse" /> class.
        /// </summary>
        public GetUploadedMediaByIdResponse()
        {
        }
    }
}