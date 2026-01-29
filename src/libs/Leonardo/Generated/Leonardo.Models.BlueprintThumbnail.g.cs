
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintThumbnail
    {
        /// <summary>
        /// Thumbnail type name (e.g., thumbnailUrl, videoUrl, thumbnailUrlBanner, thumbnailUrlLandscape, thumbnailUrlExtremePortrait)<br/>
        /// Example: thumbnailUrl
        /// </summary>
        /// <example>thumbnailUrl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the thumbnail<br/>
        /// Example: https://cdn.leonardo.ai/blueprint_assets/official/384ab5c8-55d8-47a1-be22-6a274913c324/thumbnails/goldenhour.jpg
        /// </summary>
        /// <example>https://cdn.leonardo.ai/blueprint_assets/official/384ab5c8-55d8-47a1-be22-6a274913c324/thumbnails/goldenhour.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintThumbnail" /> class.
        /// </summary>
        /// <param name="name">
        /// Thumbnail type name (e.g., thumbnailUrl, videoUrl, thumbnailUrlBanner, thumbnailUrlLandscape, thumbnailUrlExtremePortrait)<br/>
        /// Example: thumbnailUrl
        /// </param>
        /// <param name="url">
        /// URL of the thumbnail<br/>
        /// Example: https://cdn.leonardo.ai/blueprint_assets/official/384ab5c8-55d8-47a1-be22-6a274913c324/thumbnails/goldenhour.jpg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintThumbnail(
            string? name,
            string? url)
        {
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintThumbnail" /> class.
        /// </summary>
        public BlueprintThumbnail()
        {
        }
    }
}