
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBlueprintExecutionResponse2
    {
        /// <summary>
        /// Represents the Execution of a Blueprint Version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprintExecution")]
        public global::Leonardo.BlueprintExecution? BlueprintExecution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintExecutionResponse2" /> class.
        /// </summary>
        /// <param name="blueprintExecution">
        /// Represents the Execution of a Blueprint Version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBlueprintExecutionResponse2(
            global::Leonardo.BlueprintExecution? blueprintExecution)
        {
            this.BlueprintExecution = blueprintExecution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintExecutionResponse2" /> class.
        /// </summary>
        public GetBlueprintExecutionResponse2()
        {
        }
    }
}