
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBlueprintsRequest
    {
        /// <summary>
        /// Number of items to return after the cursor (forward pagination)<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first")]
        public int? First { get; set; }

        /// <summary>
        /// Cursor to paginate forward from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public string? After { get; set; }

        /// <summary>
        /// Number of items to return before the cursor (backward pagination)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last")]
        public int? Last { get; set; }

        /// <summary>
        /// Cursor to paginate backward from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        public string? Before { get; set; }

        /// <summary>
        /// Filter Blueprints by platforms that they can be executed on<br/>
        /// Default Value: [API]<br/>
        /// Example: [API, Web]
        /// </summary>
        /// <example>[API, Web]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platforms")]
        public global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsRequestPlatform>? Platforms { get; set; }

        /// <summary>
        /// Filter Blueprints by category<br/>
        /// Example: [social-media]
        /// </summary>
        /// <example>[social-media]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsRequest" /> class.
        /// </summary>
        /// <param name="first">
        /// Number of items to return after the cursor (forward pagination)<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="after">
        /// Cursor to paginate forward from
        /// </param>
        /// <param name="last">
        /// Number of items to return before the cursor (backward pagination)
        /// </param>
        /// <param name="before">
        /// Cursor to paginate backward from
        /// </param>
        /// <param name="platforms">
        /// Filter Blueprints by platforms that they can be executed on<br/>
        /// Default Value: [API]<br/>
        /// Example: [API, Web]
        /// </param>
        /// <param name="categories">
        /// Filter Blueprints by category<br/>
        /// Example: [social-media]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBlueprintsRequest(
            int? first,
            string? after,
            int? last,
            string? before,
            global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsRequestPlatform>? platforms,
            global::System.Collections.Generic.IList<string>? categories)
        {
            this.First = first;
            this.After = after;
            this.Last = last;
            this.Before = before;
            this.Platforms = platforms;
            this.Categories = categories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlueprintsRequest" /> class.
        /// </summary>
        public ListBlueprintsRequest()
        {
        }
    }
}