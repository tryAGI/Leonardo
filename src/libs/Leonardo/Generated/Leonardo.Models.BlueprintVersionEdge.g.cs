
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintVersionEdge
    {
        /// <summary>
        /// Example: eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==
        /// </summary>
        /// <example>eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public global::Leonardo.BlueprintVersionEdgeNode? Node { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdge" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Example: eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==
        /// </param>
        /// <param name="node"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintVersionEdge(
            string? cursor,
            global::Leonardo.BlueprintVersionEdgeNode? node)
        {
            this.Cursor = cursor;
            this.Node = node;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdge" /> class.
        /// </summary>
        public BlueprintVersionEdge()
        {
        }
    }
}