
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Successful response with Blueprint data
    /// </summary>
    public sealed partial class ListBlueprintsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.ListBlueprintsResponseBlueprints Blueprints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsResponse2" /> class.
        /// </summary>
        /// <param name="blueprints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBlueprintsResponse2(
            global::Leonardo.ListBlueprintsResponseBlueprints blueprints)
        {
            this.Blueprints = blueprints ?? throw new global::System.ArgumentNullException(nameof(blueprints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsResponse2" /> class.
        /// </summary>
        public ListBlueprintsResponse2()
        {
        }
    }
}