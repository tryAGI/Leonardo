
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Represents a single generation within a Blueprint Execution
    /// </summary>
    public sealed partial class BlueprintExecutionGeneration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.AllOfJsonConverter<string, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.AllOf<string, object> AkUUID { get; set; }

        /// <summary>
        /// The status of a Blueprint Execution Generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.BlueprintExecutionGenerationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.BlueprintExecutionGenerationStatus Status { get; set; }

        /// <summary>
        /// The generation ID associated with this execution generation<br/>
        /// Example: 1f0bba44-923a-69b0-b519-62a6710d46a9
        /// </summary>
        /// <example>1f0bba44-923a-69b0-b519-62a6710d46a9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Details about a generation failure due to prompt moderation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedReason")]
        public global::Leonardo.PromptModerationFailureReason? FailedReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecutionGeneration" /> class.
        /// </summary>
        /// <param name="akUUID"></param>
        /// <param name="status">
        /// The status of a Blueprint Execution Generation
        /// </param>
        /// <param name="generationId">
        /// The generation ID associated with this execution generation<br/>
        /// Example: 1f0bba44-923a-69b0-b519-62a6710d46a9
        /// </param>
        /// <param name="failedReason">
        /// Details about a generation failure due to prompt moderation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintExecutionGeneration(
            global::Leonardo.AllOf<string, object> akUUID,
            global::Leonardo.BlueprintExecutionGenerationStatus status,
            string generationId,
            global::Leonardo.PromptModerationFailureReason? failedReason)
        {
            this.AkUUID = akUUID;
            this.Status = status;
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.FailedReason = failedReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecutionGeneration" /> class.
        /// </summary>
        public BlueprintExecutionGeneration()
        {
        }
    }
}