
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextureGenerationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_rotation_offset")]
        public int? FrontRotationOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelAssetId")]
        public string? ModelAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_direction")]
        public string? PreviewDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd_version")]
        public string? SdVersion { get; set; }

        /// <summary>
        /// Apply a fixed seed to maintain consistency across generation sets. The maximum seed value is 2147483637 for Flux and 9999999998 for other models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationRequest" /> class.
        /// </summary>
        /// <param name="frontRotationOffset"></param>
        /// <param name="modelAssetId"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="preview"></param>
        /// <param name="previewDirection"></param>
        /// <param name="prompt"></param>
        /// <param name="sdVersion"></param>
        /// <param name="seed">
        /// Apply a fixed seed to maintain consistency across generation sets. The maximum seed value is 2147483637 for Flux and 9999999998 for other models
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextureGenerationRequest(
            int? frontRotationOffset,
            string? modelAssetId,
            string? negativePrompt,
            bool? preview,
            string? previewDirection,
            string? prompt,
            string? sdVersion,
            int? seed)
        {
            this.FrontRotationOffset = frontRotationOffset;
            this.ModelAssetId = modelAssetId;
            this.NegativePrompt = negativePrompt;
            this.Preview = preview;
            this.PreviewDirection = previewDirection;
            this.Prompt = prompt;
            this.SdVersion = sdVersion;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationRequest" /> class.
        /// </summary>
        public CreateTextureGenerationRequest()
        {
        }
    }
}