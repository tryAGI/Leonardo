
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptRandomResponsePromptGeneration
    {
        /// <summary>
        /// The random prompt generated.<br/>
        /// Default Value: The random prompt generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// API Credits Cost for Random Prompt Generation. Available for Production API Users. Note: it will be deprecated. Please use the cost instead.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// The cost of the operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::Leonardo.Cost? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRandomResponsePromptGeneration" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The random prompt generated.<br/>
        /// Default Value: The random prompt generated.
        /// </param>
        /// <param name="cost">
        /// The cost of the operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptRandomResponsePromptGeneration(
            string? prompt,
            global::Leonardo.Cost? cost)
        {
            this.Prompt = prompt;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRandomResponsePromptGeneration" /> class.
        /// </summary>
        public PromptRandomResponsePromptGeneration()
        {
        }
    }
}