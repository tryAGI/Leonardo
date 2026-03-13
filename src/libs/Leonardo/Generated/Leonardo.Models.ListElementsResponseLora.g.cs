
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "elements".
    /// </summary>
    public sealed partial class ListElementsResponseLora
    {
        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.SdVersionsJsonConverter))]
        public global::Leonardo.SdVersions? BaseModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponseLora" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListElementsResponseLora(
            global::Leonardo.SdVersions? baseModel)
        {
            this.BaseModel = baseModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponseLora" /> class.
        /// </summary>
        public ListElementsResponseLora()
        {
        }
    }
}