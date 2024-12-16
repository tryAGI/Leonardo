
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptImproveRequest
    {
        /// <summary>
        /// The prompt to improve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The prompt is improved based on the given instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptInstructions")]
        public string? PromptInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to improve.
        /// </param>
        /// <param name="promptInstructions">
        /// The prompt is improved based on the given instructions.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptImproveRequest(
            string prompt,
            string? promptInstructions)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.PromptInstructions = promptInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveRequest" /> class.
        /// </summary>
        public PromptImproveRequest()
        {
        }
    }
}