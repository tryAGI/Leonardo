
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTextureGenerationsByModelIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_asset_texture_generations")]
        public global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>? ModelAssetTextureGenerations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationsByModelIdResponse" /> class.
        /// </summary>
        /// <param name="modelAssetTextureGenerations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTextureGenerationsByModelIdResponse(
            global::System.Collections.Generic.IList<global::Leonardo.GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration>? modelAssetTextureGenerations)
        {
            this.ModelAssetTextureGenerations = modelAssetTextureGenerations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationsByModelIdResponse" /> class.
        /// </summary>
        public GetTextureGenerationsByModelIdResponse()
        {
        }
    }
}