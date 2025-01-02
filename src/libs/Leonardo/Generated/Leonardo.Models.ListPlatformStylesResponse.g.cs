
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPlatformStylesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::System.Collections.Generic.IList<global::Leonardo.ListPlatformStylesResponseStyleItem>? Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformStylesResponse" /> class.
        /// </summary>
        /// <param name="style"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListPlatformStylesResponse(
            global::System.Collections.Generic.IList<global::Leonardo.ListPlatformStylesResponseStyleItem>? style)
        {
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformStylesResponse" /> class.
        /// </summary>
        public ListPlatformStylesResponse()
        {
        }
    }
}