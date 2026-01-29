
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBlueprintsResponseBlueprints
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>? Edges { get; set; }

        /// <summary>
        /// Total number of results available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Pagination information following the Relay cursor pagination spec
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageInfo")]
        public global::Leonardo.PageInfo? PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsResponseBlueprints" /> class.
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="totalCount">
        /// Total number of results available
        /// </param>
        /// <param name="pageInfo">
        /// Pagination information following the Relay cursor pagination spec
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBlueprintsResponseBlueprints(
            global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>? edges,
            int? totalCount,
            global::Leonardo.PageInfo? pageInfo)
        {
            this.Edges = edges;
            this.TotalCount = totalCount;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsResponseBlueprints" /> class.
        /// </summary>
        public ListBlueprintsResponseBlueprints()
        {
        }
    }
}