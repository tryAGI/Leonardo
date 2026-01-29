
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBlueprintExecutionGenerationsResponse
    {
        /// <summary>
        /// A paginated connection of Blueprint Execution Generations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprintExecutionGenerations")]
        public global::Leonardo.BlueprintExecutionGenerationsConnection? BlueprintExecutionGenerations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintExecutionGenerationsResponse" /> class.
        /// </summary>
        /// <param name="blueprintExecutionGenerations">
        /// A paginated connection of Blueprint Execution Generations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBlueprintExecutionGenerationsResponse(
            global::Leonardo.BlueprintExecutionGenerationsConnection? blueprintExecutionGenerations)
        {
            this.BlueprintExecutionGenerations = blueprintExecutionGenerations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintExecutionGenerationsResponse" /> class.
        /// </summary>
        public GetBlueprintExecutionGenerationsResponse()
        {
        }
    }
}