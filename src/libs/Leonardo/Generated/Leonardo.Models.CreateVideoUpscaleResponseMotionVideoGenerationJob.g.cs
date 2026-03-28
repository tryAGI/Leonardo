
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoUpscaleResponseMotionVideoGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// The ID of the upscale variation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variationId")]
        public string? VariationId { get; set; }

        /// <summary>
        /// API credits cost, available for Production API users. Note: it will be deprecated. Please use the cost instead.
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
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleResponseMotionVideoGenerationJob" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="variationId">
        /// The ID of the upscale variation.
        /// </param>
        /// <param name="cost">
        /// The cost of the operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoUpscaleResponseMotionVideoGenerationJob(
            string? generationId,
            string? variationId,
            global::Leonardo.Cost? cost)
        {
            this.GenerationId = generationId;
            this.VariationId = variationId;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleResponseMotionVideoGenerationJob" /> class.
        /// </summary>
        public CreateVideoUpscaleResponseMotionVideoGenerationJob()
        {
        }
    }
}