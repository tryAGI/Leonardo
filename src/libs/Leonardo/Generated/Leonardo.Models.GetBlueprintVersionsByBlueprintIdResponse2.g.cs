
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBlueprintVersionsByBlueprintIdResponse2
    {
        /// <summary>
        /// A Blueprint Version object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprintVersions")]
        public global::Leonardo.BlueprintVersion? BlueprintVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintVersionsByBlueprintIdResponse2" /> class.
        /// </summary>
        /// <param name="blueprintVersions">
        /// A Blueprint Version object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBlueprintVersionsByBlueprintIdResponse2(
            global::Leonardo.BlueprintVersion? blueprintVersions)
        {
            this.BlueprintVersions = blueprintVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintVersionsByBlueprintIdResponse2" /> class.
        /// </summary>
        public GetBlueprintVersionsByBlueprintIdResponse2()
        {
        }
    }
}