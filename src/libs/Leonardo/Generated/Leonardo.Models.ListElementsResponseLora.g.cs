
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "elements"
    /// </summary>
    public sealed partial class ListElementsResponseLora
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        public global::Leonardo.Lora? AkUUID { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SdVersionsJsonConverter))]
        public global::Leonardo.SdVersions? BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorName")]
        public global::Leonardo.Lora? CreatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::Leonardo.Lora? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::Leonardo.Lora? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlImage")]
        public global::Leonardo.Lora? UrlImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightDefault")]
        public global::Leonardo.Lora? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMax")]
        public global::Leonardo.Lora? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMin")]
        public global::Leonardo.Lora? WeightMin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}