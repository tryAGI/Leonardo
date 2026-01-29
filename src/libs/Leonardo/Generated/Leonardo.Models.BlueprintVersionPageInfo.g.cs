
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintVersionPageInfo
    {
        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        public bool? HasNextPage { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasPreviousPage")]
        public bool? HasPreviousPage { get; set; }

        /// <summary>
        /// Example: eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==
        /// </summary>
        /// <example>eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startCursor")]
        public string? StartCursor { get; set; }

        /// <summary>
        /// Example: eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==
        /// </summary>
        /// <example>eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCursor")]
        public string? EndCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintVersionPageInfo" /> class.
        /// </summary>
        /// <param name="hasNextPage">
        /// Example: false
        /// </param>
        /// <param name="hasPreviousPage">
        /// Example: false
        /// </param>
        /// <param name="startCursor">
        /// Example: eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==
        /// </param>
        /// <param name="endCursor">
        /// Example: eyJjcmVhdGVkQXQiOiIyMDI1LTExLTI3VDA1OjEzOjIxLjg5NloiLCJha1VVSUQiOiI5NTZlOTU2NC0xOWY3LTQ5NjgtYjU2ZC0wNWMyYzU2NzcyNmYifQ==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintVersionPageInfo(
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
        /// Initializes a new instance of the <see cref="BlueprintVersionPageInfo" /> class.
        /// </summary>
        public BlueprintVersionPageInfo()
        {
        }
    }
}