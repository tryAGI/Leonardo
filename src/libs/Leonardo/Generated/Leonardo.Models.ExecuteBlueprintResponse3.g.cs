
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteBlueprintResponse3
    {
        /// <summary>
        /// Error message describing the invalid input type or missing field<br/>
        /// Example: Invalid input type: expected 'string' for field 'blueprintVersionId'
        /// </summary>
        /// <example>Invalid input type: expected 'string' for field 'blueprintVersionId'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Error message describing the invalid input type or missing field<br/>
        /// Example: Invalid input type: expected 'string' for field 'blueprintVersionId'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteBlueprintResponse3(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlueprintResponse3" /> class.
        /// </summary>
        public ExecuteBlueprintResponse3()
        {
        }
    }
}