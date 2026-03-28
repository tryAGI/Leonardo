
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformAlchemyUpscaleLCMResponseLcmGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageDataUrl")]
        public global::System.Collections.Generic.IList<string>? ImageDataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        public global::System.Collections.Generic.IList<string>? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variationId")]
        public global::System.Collections.Generic.IList<string>? VariationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedImageId")]
        public string? GeneratedImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestTimestamp")]
        public string? RequestTimestamp { get; set; }

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
        /// Initializes a new instance of the <see cref="PerformAlchemyUpscaleLCMResponseLcmGenerationJob" /> class.
        /// </summary>
        /// <param name="imageDataUrl"></param>
        /// <param name="generationId"></param>
        /// <param name="variationId"></param>
        /// <param name="generatedImageId"></param>
        /// <param name="requestTimestamp"></param>
        /// <param name="cost">
        /// The cost of the operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerformAlchemyUpscaleLCMResponseLcmGenerationJob(
            global::System.Collections.Generic.IList<string>? imageDataUrl,
            global::System.Collections.Generic.IList<string>? generationId,
            global::System.Collections.Generic.IList<string>? variationId,
            string? generatedImageId,
            string? requestTimestamp,
            global::Leonardo.Cost? cost)
        {
            this.ImageDataUrl = imageDataUrl;
            this.GenerationId = generationId;
            this.VariationId = variationId;
            this.GeneratedImageId = generatedImageId;
            this.RequestTimestamp = requestTimestamp;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformAlchemyUpscaleLCMResponseLcmGenerationJob" /> class.
        /// </summary>
        public PerformAlchemyUpscaleLCMResponseLcmGenerationJob()
        {
        }
    }
}