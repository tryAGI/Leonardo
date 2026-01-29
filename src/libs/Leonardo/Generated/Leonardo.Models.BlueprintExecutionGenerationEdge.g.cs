
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// An edge containing a Blueprint Execution Generation node
    /// </summary>
    public sealed partial class BlueprintExecutionGenerationEdge
    {
        /// <summary>
        /// An opaque cursor used for pagination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cursor { get; set; }

        /// <summary>
        /// Represents a single generation within a Blueprint Execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.BlueprintExecutionGeneration Node { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecutionGenerationEdge" /> class.
        /// </summary>
        /// <param name="cursor">
        /// An opaque cursor used for pagination
        /// </param>
        /// <param name="node">
        /// Represents a single generation within a Blueprint Execution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintExecutionGenerationEdge(
            string cursor,
            global::Leonardo.BlueprintExecutionGeneration node)
        {
            this.Cursor = cursor ?? throw new global::System.ArgumentNullException(nameof(cursor));
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecutionGenerationEdge" /> class.
        /// </summary>
        public BlueprintExecutionGenerationEdge()
        {
        }
    }
}