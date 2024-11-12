
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Get3DModelByIdResponse
    {
        /// <summary>
        /// columns and relationships of "model_assets"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_assets_by_pk")]
        public global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? ModelAssetsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelByIdResponse" /> class.
        /// </summary>
        /// <param name="modelAssetsByPk">
        /// columns and relationships of "model_assets"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Get3DModelByIdResponse(
            global::Leonardo.Get3DModelByIdResponseModelAssetsByPk? modelAssetsByPk)
        {
            this.ModelAssetsByPk = modelAssetsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelByIdResponse" /> class.
        /// </summary>
        public Get3DModelByIdResponse()
        {
        }
    }
}