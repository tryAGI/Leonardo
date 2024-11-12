
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGenerationByIdResponse
    {
        /// <summary>
        /// columns and relationships of "generations"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations_by_pk")]
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPk? GenerationsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponse" /> class.
        /// </summary>
        /// <param name="generationsByPk">
        /// columns and relationships of "generations"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetGenerationByIdResponse(
            global::Leonardo.GetGenerationByIdResponseGenerationsByPk? generationsByPk)
        {
            this.GenerationsByPk = generationsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponse" /> class.
        /// </summary>
        public GetGenerationByIdResponse()
        {
        }
    }
}