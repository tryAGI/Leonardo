
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteBlueprintRequestInput
    {
        /// <summary>
        /// Array of node input objects to customize the Blueprint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeInputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Leonardo.NodeInput> NodeInputs { get; set; }

        /// <summary>
        /// Whether the resulting generations should be public<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// Optional list of collection IDs to add the generations to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionIds")]
        public global::System.Collections.Generic.IList<int>? CollectionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintRequestInput" /> class.
        /// </summary>
        /// <param name="nodeInputs">
        /// Array of node input objects to customize the Blueprint
        /// </param>
        /// <param name="public">
        /// Whether the resulting generations should be public<br/>
        /// Example: false
        /// </param>
        /// <param name="collectionIds">
        /// Optional list of collection IDs to add the generations to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteBlueprintRequestInput(
            global::System.Collections.Generic.IList<global::Leonardo.NodeInput> nodeInputs,
            bool @public,
            global::System.Collections.Generic.IList<int>? collectionIds)
        {
            this.NodeInputs = nodeInputs ?? throw new global::System.ArgumentNullException(nameof(nodeInputs));
            this.Public = @public;
            this.CollectionIds = collectionIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintRequestInput" /> class.
        /// </summary>
        public ExecuteBlueprintRequestInput()
        {
        }
    }
}