
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintVersionEdgeNode
    {
        /// <summary>
        /// Example: 956e9564-19f7-4968-b56d-05c2c567726f
        /// </summary>
        /// <example>956e9564-19f7-4968-b56d-05c2c567726f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        public global::System.Guid? AkUUID { get; set; }

        /// <summary>
        /// Example: 2025-11-27T05:13:21.8960000+00:00
        /// </summary>
        /// <example>2025-11-27T05:13:21.8960000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: 2025-11-27T05:13:21.8960000+00:00
        /// </summary>
        /// <example>2025-11-27T05:13:21.8960000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Example: 160
        /// </summary>
        /// <example>160</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiMetadata")]
        public global::Leonardo.BlueprintVersionEdgeNodeUiMetadata? UiMetadata { get; set; }

        /// <summary>
        /// Example: 21
        /// </summary>
        /// <example>21</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uiMetadataSchemaVersion")]
        public string? UiMetadataSchemaVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executability")]
        public global::Leonardo.BlueprintVersionEdgeNodeExecutability? Executability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdgeNode" /> class.
        /// </summary>
        /// <param name="akUUID">
        /// Example: 956e9564-19f7-4968-b56d-05c2c567726f
        /// </param>
        /// <param name="createdAt">
        /// Example: 2025-11-27T05:13:21.8960000+00:00
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2025-11-27T05:13:21.8960000+00:00
        /// </param>
        /// <param name="cost">
        /// Example: 160
        /// </param>
        /// <param name="uiMetadata"></param>
        /// <param name="uiMetadataSchemaVersion">
        /// Example: 21
        /// </param>
        /// <param name="models"></param>
        /// <param name="executability"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintVersionEdgeNode(
            global::System.Guid? akUUID,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? cost,
            global::Leonardo.BlueprintVersionEdgeNodeUiMetadata? uiMetadata,
            string? uiMetadataSchemaVersion,
            global::System.Collections.Generic.IList<string>? models,
            global::Leonardo.BlueprintVersionEdgeNodeExecutability? executability)
        {
            this.AkUUID = akUUID;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Cost = cost;
            this.UiMetadata = uiMetadata;
            this.UiMetadataSchemaVersion = uiMetadataSchemaVersion;
            this.Models = models;
            this.Executability = executability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdgeNode" /> class.
        /// </summary>
        public BlueprintVersionEdgeNode()
        {
        }
    }
}