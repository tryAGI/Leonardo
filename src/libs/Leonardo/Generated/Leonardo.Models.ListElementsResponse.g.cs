
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListElementsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loras")]
        public global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? Loras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponse" /> class.
        /// </summary>
        /// <param name="loras"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListElementsResponse(
            global::System.Collections.Generic.IList<global::Leonardo.ListElementsResponseLora>? loras)
        {
            this.Loras = loras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponse" /> class.
        /// </summary>
        public ListElementsResponse()
        {
        }
    }
}