
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUploadedMediaByIdResponseUploadedMediaByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        public string? MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_fps")]
        public double? VideoFps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadedMediaByIdResponseUploadedMediaByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="url"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="status"></param>
        /// <param name="statusReason"></param>
        /// <param name="mediaType"></param>
        /// <param name="duration"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="videoFps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUploadedMediaByIdResponseUploadedMediaByPk(
            string? id,
            string? createdAt,
            string? url,
            string? thumbnailUrl,
            string? status,
            string? statusReason,
            string? mediaType,
            double? duration,
            int? width,
            int? height,
            double? videoFps)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Url = url;
            this.ThumbnailUrl = thumbnailUrl;
            this.Status = status;
            this.StatusReason = statusReason;
            this.MediaType = mediaType;
            this.Duration = duration;
            this.Width = width;
            this.Height = height;
            this.VideoFps = videoFps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadedMediaByIdResponseUploadedMediaByPk" /> class.
        /// </summary>
        public GetUploadedMediaByIdResponseUploadedMediaByPk()
        {
        }
    }
}