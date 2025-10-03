
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The end frame image. Supported only on Kling2.1 model when used in conjunction with an init image.
    /// </summary>
    public sealed partial class CreateImageToVideoGenerationRequestEndFrameImage
    {
        /// <summary>
        /// The ID of the end frame image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type indicating whether the end frame image is uploaded or generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateImageToVideoGenerationRequestEndFrameImageTypeJsonConverter))]
        public global::Leonardo.CreateImageToVideoGenerationRequestEndFrameImageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoGenerationRequestEndFrameImage" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the end frame image.
        /// </param>
        /// <param name="type">
        /// Type indicating whether the end frame image is uploaded or generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoGenerationRequestEndFrameImage(
            string? id,
            global::Leonardo.CreateImageToVideoGenerationRequestEndFrameImageType? type)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoGenerationRequestEndFrameImage" /> class.
        /// </summary>
        public CreateImageToVideoGenerationRequestEndFrameImage()
        {
        }
    }
}