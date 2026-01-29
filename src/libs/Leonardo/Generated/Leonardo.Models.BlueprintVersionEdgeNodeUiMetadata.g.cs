
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintVersionEdgeNodeUiMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdgeNodeUiMetadata" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintVersionEdgeNodeUiMetadata(
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<object>? outputs)
        {
            this.Inputs = inputs;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdgeNodeUiMetadata" /> class.
        /// </summary>
        public BlueprintVersionEdgeNodeUiMetadata()
        {
        }
    }
}