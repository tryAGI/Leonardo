
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteBlueprintRequest
    {
        /// <summary>
        /// The unique identifier of the Blueprint Version to execute<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprintVersionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BlueprintVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.ExecuteBlueprintRequestInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintRequest" /> class.
        /// </summary>
        /// <param name="blueprintVersionId">
        /// The unique identifier of the Blueprint Version to execute<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteBlueprintRequest(
            global::System.Guid blueprintVersionId,
            global::Leonardo.ExecuteBlueprintRequestInput input)
        {
            this.BlueprintVersionId = blueprintVersionId;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintRequest" /> class.
        /// </summary>
        public ExecuteBlueprintRequest()
        {
        }
    }
}