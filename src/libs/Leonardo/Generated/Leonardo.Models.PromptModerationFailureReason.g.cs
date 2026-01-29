
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Details about a generation failure due to prompt moderation
    /// </summary>
    public sealed partial class PromptModerationFailureReason
    {
        /// <summary>
        /// The type of failure - PROMPT_MODERATION_BLOCKED indicates the prompt was blocked by content moderation<br/>
        /// Example: PROMPT_MODERATION_BLOCKED
        /// </summary>
        /// <example>PROMPT_MODERATION_BLOCKED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.PromptModerationFailureReasonTypeJsonConverter))]
        public global::Leonardo.PromptModerationFailureReasonType Type { get; set; }

        /// <summary>
        /// Human-readable message describing the failure<br/>
        /// Example: Generation blocked due to prompt moderation
        /// </summary>
        /// <example>Generation blocked due to prompt moderation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Number of outputs affected by this failure<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedOutputCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AffectedOutputCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptModerationFailureReason" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of failure - PROMPT_MODERATION_BLOCKED indicates the prompt was blocked by content moderation<br/>
        /// Example: PROMPT_MODERATION_BLOCKED
        /// </param>
        /// <param name="message">
        /// Human-readable message describing the failure<br/>
        /// Example: Generation blocked due to prompt moderation
        /// </param>
        /// <param name="affectedOutputCount">
        /// Number of outputs affected by this failure<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptModerationFailureReason(
            string message,
            int affectedOutputCount,
            global::Leonardo.PromptModerationFailureReasonType type)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.AffectedOutputCount = affectedOutputCount;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptModerationFailureReason" /> class.
        /// </summary>
        public PromptModerationFailureReason()
        {
        }
    }
}