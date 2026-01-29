
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBlueprintsResponseBlueprintsEdge
    {
        /// <summary>
        /// An opaque cursor used for pagination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// A Blueprint object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public global::Leonardo.Blueprint? Node { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsResponseBlueprintsEdge" /> class.
        /// </summary>
        /// <param name="cursor">
        /// An opaque cursor used for pagination
        /// </param>
        /// <param name="node">
        /// A Blueprint object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBlueprintsResponseBlueprintsEdge(
            string? cursor,
            global::Leonardo.Blueprint? node)
        {
            this.Cursor = cursor;
            this.Node = node;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsResponseBlueprintsEdge" /> class.
        /// </summary>
        public ListBlueprintsResponseBlueprintsEdge()
        {
        }
    }
}