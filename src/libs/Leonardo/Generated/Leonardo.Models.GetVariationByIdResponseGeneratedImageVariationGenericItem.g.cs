
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "generated_image_variation_generic"
    /// </summary>
    public sealed partial class GetVariationByIdResponseGeneratedImageVariationGenericItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.JobStatusJsonConverter))]
        public global::Leonardo.JobStatus? Status { get; set; }

        /// <summary>
        /// The type of variation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.VARIATIONTYPEJsonConverter))]
        public global::Leonardo.VARIATIONTYPE? TransformType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariationByIdResponseGeneratedImageVariationGenericItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        /// <param name="transformType">
        /// The type of variation.
        /// </param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetVariationByIdResponseGeneratedImageVariationGenericItem(
            string? createdAt,
            string? id,
            global::Leonardo.JobStatus? status,
            global::Leonardo.VARIATIONTYPE? transformType,
            string? url)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Status = status;
            this.TransformType = transformType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariationByIdResponseGeneratedImageVariationGenericItem" /> class.
        /// </summary>
        public GetVariationByIdResponseGeneratedImageVariationGenericItem()
        {
        }
    }
}