
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteBlueprintResponseExecuteBlueprint
    {
        /// <summary>
        /// The unique identifier of the Blueprint Execution<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AkUUID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintResponseExecuteBlueprint" /> class.
        /// </summary>
        /// <param name="akUUID">
        /// The unique identifier of the Blueprint Execution<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteBlueprintResponseExecuteBlueprint(
            global::System.Guid akUUID)
        {
            this.AkUUID = akUUID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintResponseExecuteBlueprint" /> class.
        /// </summary>
        public ExecuteBlueprintResponseExecuteBlueprint()
        {
        }
    }
}