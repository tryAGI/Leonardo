
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// A Blueprint Version object
    /// </summary>
    public sealed partial class BlueprintVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdge>? Edges { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageInfo")]
        public global::Leonardo.BlueprintVersionPageInfo? PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersion" /> class.
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="totalCount">
        /// Example: 2
        /// </param>
        /// <param name="pageInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintVersion(
            global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdge>? edges,
            int? totalCount,
            global::Leonardo.BlueprintVersionPageInfo? pageInfo)
        {
            this.Edges = edges;
            this.TotalCount = totalCount;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersion" /> class.
        /// </summary>
        public BlueprintVersion()
        {
        }
    }
}