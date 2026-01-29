
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// A paginated connection of Blueprint Execution Generations
    /// </summary>
    public sealed partial class BlueprintExecutionGenerationsConnection
    {
        /// <summary>
        /// Pagination information following the Relay cursor pagination spec
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.PageInfo PageInfo { get; set; }

        /// <summary>
        /// List of generation edges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Leonardo.BlueprintExecutionGenerationEdge> Edges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecutionGenerationsConnection" /> class.
        /// </summary>
        /// <param name="pageInfo">
        /// Pagination information following the Relay cursor pagination spec
        /// </param>
        /// <param name="edges">
        /// List of generation edges
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintExecutionGenerationsConnection(
            global::Leonardo.PageInfo pageInfo,
            global::System.Collections.Generic.IList<global::Leonardo.BlueprintExecutionGenerationEdge> edges)
        {
            this.PageInfo = pageInfo ?? throw new global::System.ArgumentNullException(nameof(pageInfo));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecutionGenerationsConnection" /> class.
        /// </summary>
        public BlueprintExecutionGenerationsConnection()
        {
        }
    }
}