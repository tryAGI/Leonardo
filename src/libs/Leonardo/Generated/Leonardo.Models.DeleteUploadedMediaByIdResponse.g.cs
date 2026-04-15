
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteUploadedMediaByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_uploaded_media_by_pk")]
        public global::Leonardo.DeleteUploadedMediaByIdResponseDeleteUploadedMediaByPk? DeleteUploadedMediaByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUploadedMediaByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteUploadedMediaByPk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteUploadedMediaByIdResponse(
            global::Leonardo.DeleteUploadedMediaByIdResponseDeleteUploadedMediaByPk? deleteUploadedMediaByPk)
        {
            this.DeleteUploadedMediaByPk = deleteUploadedMediaByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUploadedMediaByIdResponse" /> class.
        /// </summary>
        public DeleteUploadedMediaByIdResponse()
        {
        }
    }
}