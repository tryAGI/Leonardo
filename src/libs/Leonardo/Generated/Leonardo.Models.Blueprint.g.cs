
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// A Blueprint object
    /// </summary>
    public sealed partial class Blueprint
    {
        /// <summary>
        /// Unique identifier for the Blueprint<br/>
        /// Example: c846413e-92ba-4302-84f8-47c667d4761f
        /// </summary>
        /// <example>c846413e-92ba-4302-84f8-47c667d4761f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        public string? AkUUID { get; set; }

        /// <summary>
        /// Creation timestamp<br/>
        /// Example: 2025-10-29T21:31:47.9990000+00:00
        /// </summary>
        /// <example>2025-10-29T21:31:47.9990000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp<br/>
        /// Example: 2025-12-19T02:34:44.7400000+00:00
        /// </summary>
        /// <example>2025-12-19T02:34:44.7400000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Name of the Blueprint<br/>
        /// Example: Golden Hour Relight
        /// </summary>
        /// <example>Golden Hour Relight</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the Blueprint<br/>
        /// Example: Relight an image with warm, golden tones of late afternoon sunlight for a soft and radiant glow.
        /// </summary>
        /// <example>Relight an image with warm, golden tones of late afternoon sunlight for a soft and radiant glow.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnails")]
        public global::System.Collections.Generic.IList<global::Leonardo.BlueprintThumbnail>? Thumbnails { get; set; }

        /// <summary>
        /// Team ID if Blueprint belongs to a team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Whether this is an official Blueprint<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("official")]
        public bool? Official { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Blueprint" /> class.
        /// </summary>
        /// <param name="akUUID">
        /// Unique identifier for the Blueprint<br/>
        /// Example: c846413e-92ba-4302-84f8-47c667d4761f
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp<br/>
        /// Example: 2025-10-29T21:31:47.9990000+00:00
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp<br/>
        /// Example: 2025-12-19T02:34:44.7400000+00:00
        /// </param>
        /// <param name="name">
        /// Name of the Blueprint<br/>
        /// Example: Golden Hour Relight
        /// </param>
        /// <param name="description">
        /// Description of the Blueprint<br/>
        /// Example: Relight an image with warm, golden tones of late afternoon sunlight for a soft and radiant glow.
        /// </param>
        /// <param name="thumbnails"></param>
        /// <param name="teamId">
        /// Team ID if Blueprint belongs to a team
        /// </param>
        /// <param name="official">
        /// Whether this is an official Blueprint<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Blueprint(
            string? akUUID,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::Leonardo.BlueprintThumbnail>? thumbnails,
            string? teamId,
            bool? official)
        {
            this.AkUUID = akUUID;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Description = description;
            this.Thumbnails = thumbnails;
            this.TeamId = teamId;
            this.Official = official;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Blueprint" /> class.
        /// </summary>
        public Blueprint()
        {
        }
    }
}