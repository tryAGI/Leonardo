
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerationResponseSdGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// API Credits Cost for Image Generation. Available for Production API Users. Note: it will be deprecated. Please use the cost instead.
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
        /// Initializes a new instance of the <see cref="CreateGenerationResponseSdGenerationJob" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="cost">
        /// The cost of the operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerationResponseSdGenerationJob(
            string? generationId,
            global::Leonardo.Cost? cost)
        {
            this.GenerationId = generationId;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationResponseSdGenerationJob" /> class.
        /// </summary>
        public CreateGenerationResponseSdGenerationJob()
        {
        }
    }
}