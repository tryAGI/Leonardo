
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Pagination information following the Relay cursor pagination spec
    /// </summary>
    public sealed partial class PageInfo
    {
        /// <summary>
        /// Whether there is a next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        public bool? HasNextPage { get; set; }

        /// <summary>
        /// Whether there is a previous page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasPreviousPage")]
        public bool? HasPreviousPage { get; set; }

        /// <summary>
        /// Cursor for the first item in the result set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startCursor")]
        public string? StartCursor { get; set; }

        /// <summary>
        /// Cursor for the last item in the result set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCursor")]
        public string? EndCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo" /> class.
        /// </summary>
        /// <param name="hasNextPage">
        /// Whether there is a next page
        /// </param>
        /// <param name="hasPreviousPage">
        /// Whether there is a previous page
        /// </param>
        /// <param name="startCursor">
        /// Cursor for the first item in the result set
        /// </param>
        /// <param name="endCursor">
        /// Cursor for the last item in the result set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageInfo(
            bool? hasNextPage,
            bool? hasPreviousPage,
            string? startCursor,
            string? endCursor)
        {
            this.HasNextPage = hasNextPage;
            this.HasPreviousPage = hasPreviousPage;
            this.StartCursor = startCursor;
            this.EndCursor = endCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo" /> class.
        /// </summary>
        public PageInfo()
        {
        }
    }
}