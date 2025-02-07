
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTextureGenerationByIdResponse
    {
        /// <summary>
        /// columns and relationships of "model_asset_texture_generations"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_asset_texture_generations_by_pk")]
        public global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPk? ModelAssetTextureGenerationsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationByIdResponse" /> class.
        /// </summary>
        /// <param name="modelAssetTextureGenerationsByPk">
        /// columns and relationships of "model_asset_texture_generations"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTextureGenerationByIdResponse(
            global::Leonardo.GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPk? modelAssetTextureGenerationsByPk)
        {
            this.ModelAssetTextureGenerationsByPk = modelAssetTextureGenerationsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationByIdResponse" /> class.
        /// </summary>
        public GetTextureGenerationByIdResponse()
        {
        }
    }
}