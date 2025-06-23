
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "generated_image_variation_motion"
    /// </summary>
    public sealed partial class GetMotionVariationByIdResponseGeneratedImageVariationMotionItem
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
        /// The type of motion variation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motionTransformType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.MOTIONVARIATIONTYPEJsonConverter))]
        public global::Leonardo.MOTIONVARIATIONTYPE? MotionTransformType { get; set; }

        /// <summary>
        /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.MOTIONRESOLUTIONJsonConverter))]
        public global::Leonardo.MOTIONRESOLUTION? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="GetMotionVariationByIdResponseGeneratedImageVariationMotionItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        /// <param name="motionTransformType">
        /// The type of motion variation.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMotionVariationByIdResponseGeneratedImageVariationMotionItem(
            string? createdAt,
            string? id,
            global::Leonardo.JobStatus? status,
            global::Leonardo.MOTIONVARIATIONTYPE? motionTransformType,
            global::Leonardo.MOTIONRESOLUTION? resolution,
            string? url)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Status = status;
            this.MotionTransformType = motionTransformType;
            this.Resolution = resolution;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMotionVariationByIdResponseGeneratedImageVariationMotionItem" /> class.
        /// </summary>
        public GetMotionVariationByIdResponseGeneratedImageVariationMotionItem()
        {
        }
    }
}