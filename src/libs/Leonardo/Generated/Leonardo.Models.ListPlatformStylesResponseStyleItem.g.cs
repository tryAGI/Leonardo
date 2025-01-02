
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "style"
    /// </summary>
    public sealed partial class ListPlatformStylesResponseStyleItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        public string? AkUUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformStylesResponseStyleItem" /> class.
        /// </summary>
        /// <param name="akUUID"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListPlatformStylesResponseStyleItem(
            string? akUUID,
            string? name,
            string? description)
        {
            this.AkUUID = akUUID;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformStylesResponseStyleItem" /> class.
        /// </summary>
        public ListPlatformStylesResponseStyleItem()
        {
        }
    }
}