
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInitImageByIdResponse
    {
        /// <summary>
        /// columns and relationships of "init_images"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_images_by_pk")]
        public global::Leonardo.GetInitImageByIdResponseInitImagesByPk? InitImagesByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInitImageByIdResponse" /> class.
        /// </summary>
        /// <param name="initImagesByPk">
        /// columns and relationships of "init_images"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetInitImageByIdResponse(
            global::Leonardo.GetInitImageByIdResponseInitImagesByPk? initImagesByPk)
        {
            this.InitImagesByPk = initImagesByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInitImageByIdResponse" /> class.
        /// </summary>
        public GetInitImageByIdResponse()
        {
        }
    }
}