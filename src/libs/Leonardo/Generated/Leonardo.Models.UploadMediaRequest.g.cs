
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadMediaRequest
    {
        /// <summary>
        /// The file extension of the media file to upload. Supported extensions for video: `mp4`, `mov`. Supported for audio: `mp3`, `wav`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Extension { get; set; }

        /// <summary>
        /// Original file name for display. Required for audio uploads (`mp3`, `wav`). Optional for video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalFilename")]
        public string? OriginalFilename { get; set; }

        /// <summary>
        /// Optional team UUID. When set, the upload is associated with that team and the caller must be a member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest" /> class.
        /// </summary>
        /// <param name="extension">
        /// The file extension of the media file to upload. Supported extensions for video: `mp4`, `mov`. Supported for audio: `mp3`, `wav`.
        /// </param>
        /// <param name="originalFilename">
        /// Original file name for display. Required for audio uploads (`mp3`, `wav`). Optional for video.
        /// </param>
        /// <param name="teamId">
        /// Optional team UUID. When set, the upload is associated with that team and the caller must be a member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadMediaRequest(
            string extension,
            string? originalFilename,
            string? teamId)
        {
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
            this.OriginalFilename = originalFilename;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest" /> class.
        /// </summary>
        public UploadMediaRequest()
        {
        }

    }
}