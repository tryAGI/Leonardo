
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMotionVariationByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_image_variation_motion")]
        public global::System.Collections.Generic.IList<global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem>? GeneratedImageVariationMotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMotionVariationByIdResponse" /> class.
        /// </summary>
        /// <param name="generatedImageVariationMotion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMotionVariationByIdResponse(
            global::System.Collections.Generic.IList<global::Leonardo.GetMotionVariationByIdResponseGeneratedImageVariationMotionItem>? generatedImageVariationMotion)
        {
            this.GeneratedImageVariationMotion = generatedImageVariationMotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMotionVariationByIdResponse" /> class.
        /// </summary>
        public GetMotionVariationByIdResponse()
        {
        }
    }
}