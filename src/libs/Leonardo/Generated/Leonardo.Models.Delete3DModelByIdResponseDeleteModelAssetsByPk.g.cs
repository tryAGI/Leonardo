
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "model_assets"
    /// </summary>
    public sealed partial class Delete3DModelByIdResponseDeleteModelAssetsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete3DModelByIdResponseDeleteModelAssetsByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Delete3DModelByIdResponseDeleteModelAssetsByPk(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete3DModelByIdResponseDeleteModelAssetsByPk" /> class.
        /// </summary>
        public Delete3DModelByIdResponseDeleteModelAssetsByPk()
        {
        }
    }
}