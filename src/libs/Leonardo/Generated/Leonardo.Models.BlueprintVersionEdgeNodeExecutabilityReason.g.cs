
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintVersionEdgeNodeExecutabilityReason
    {
        /// <summary>
        /// Example: gemini-2.5-flash-image
        /// </summary>
        /// <example>gemini-2.5-flash-image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public string? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdgeNodeExecutabilityReason" /> class.
        /// </summary>
        /// <param name="models">
        /// Example: gemini-2.5-flash-image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintVersionEdgeNodeExecutabilityReason(
            string? models)
        {
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionEdgeNodeExecutabilityReason" /> class.
        /// </summary>
        public BlueprintVersionEdgeNodeExecutabilityReason()
        {
        }
    }
}