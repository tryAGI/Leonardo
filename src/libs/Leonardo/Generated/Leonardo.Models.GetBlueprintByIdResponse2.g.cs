
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBlueprintByIdResponse2
    {
        /// <summary>
        /// A Blueprint object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprint")]
        public global::Leonardo.Blueprint? Blueprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintByIdResponse2" /> class.
        /// </summary>
        /// <param name="blueprint">
        /// A Blueprint object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBlueprintByIdResponse2(
            global::Leonardo.Blueprint? blueprint)
        {
            this.Blueprint = blueprint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlueprintByIdResponse2" /> class.
        /// </summary>
        public GetBlueprintByIdResponse2()
        {
        }
    }
}