
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// This table captures the elements that are applied to Generations.
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPkGenerationElement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Element used for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora")]
        public global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Lora { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightApplied")]
        public double? WeightApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElement" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lora">
        /// Element used for the generation.
        /// </param>
        /// <param name="weightApplied"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetGenerationByIdResponseGenerationsByPkGenerationElement(
            int? id,
            global::Leonardo.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? lora,
            double? weightApplied)
        {
            this.Id = id;
            this.Lora = lora;
            this.WeightApplied = weightApplied;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElement" /> class.
        /// </summary>
        public GetGenerationByIdResponseGenerationsByPkGenerationElement()
        {
        }
    }
}