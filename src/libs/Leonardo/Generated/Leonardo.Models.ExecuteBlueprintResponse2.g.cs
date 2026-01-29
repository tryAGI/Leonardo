
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteBlueprintResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executeBlueprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.ExecuteBlueprintResponseExecuteBlueprint ExecuteBlueprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintResponse2" /> class.
        /// </summary>
        /// <param name="executeBlueprint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteBlueprintResponse2(
            global::Leonardo.ExecuteBlueprintResponseExecuteBlueprint executeBlueprint)
        {
            this.ExecuteBlueprint = executeBlueprint ?? throw new global::System.ArgumentNullException(nameof(executeBlueprint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintResponse2" /> class.
        /// </summary>
        public ExecuteBlueprintResponse2()
        {
        }
    }
}