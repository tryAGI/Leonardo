
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoUpscaleRequest
    {
        /// <summary>
        /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateVideoUpscaleRequestResolutionJsonConverter))]
        public global::Leonardo.CreateVideoUpscaleRequestResolution Resolution { get; set; }

        /// <summary>
        /// The ID of the source video generation to upscale.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceGenerationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceGenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleRequest" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution of the upscaled video. RESOLUTION_720 is the only option for now.
        /// </param>
        /// <param name="sourceGenerationId">
        /// The ID of the source video generation to upscale.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoUpscaleRequest(
            string sourceGenerationId,
            global::Leonardo.CreateVideoUpscaleRequestResolution resolution)
        {
            this.SourceGenerationId = sourceGenerationId ?? throw new global::System.ArgumentNullException(nameof(sourceGenerationId));
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleRequest" /> class.
        /// </summary>
        public CreateVideoUpscaleRequest()
        {
        }
    }
}