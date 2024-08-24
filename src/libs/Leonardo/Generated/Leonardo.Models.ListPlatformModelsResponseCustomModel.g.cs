
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "custom_models"
    /// </summary>
    public sealed partial class ListPlatformModelsResponseCustomModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        public bool Featured { get; set; }

        /// <summary>
        /// columns and relationships of "generated_images"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_image")]
        public global::Leonardo.ListPlatformModelsResponseCustomModelGeneratedImage? GeneratedImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw")]
        public bool Nsfw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}