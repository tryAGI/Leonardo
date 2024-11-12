
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVariationByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_image_variation_generic")]
        public global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? GeneratedImageVariationGeneric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariationByIdResponse" /> class.
        /// </summary>
        /// <param name="generatedImageVariationGeneric"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetVariationByIdResponse(
            global::System.Collections.Generic.IList<global::Leonardo.GetVariationByIdResponseGeneratedImageVariationGenericItem>? generatedImageVariationGeneric)
        {
            this.GeneratedImageVariationGeneric = generatedImageVariationGeneric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariationByIdResponse" /> class.
        /// </summary>
        public GetVariationByIdResponse()
        {
        }
    }
}