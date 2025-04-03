
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToVideoGenerationResponseMotionVideoGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// API credits cost, available for Production API users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoGenerationResponseMotionVideoGenerationJob" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="apiCreditCost">
        /// API credits cost, available for Production API users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoGenerationResponseMotionVideoGenerationJob(
            string? generationId,
            int? apiCreditCost)
        {
            this.GenerationId = generationId;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoGenerationResponseMotionVideoGenerationJob" /> class.
        /// </summary>
        public CreateTextToVideoGenerationResponseMotionVideoGenerationJob()
        {
        }
    }
}