
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCustomElementsByUserIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_loras")]
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>? UserLoras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomElementsByUserIdResponse" /> class.
        /// </summary>
        /// <param name="userLoras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCustomElementsByUserIdResponse(
            global::System.Collections.Generic.IList<global::Leonardo.GetCustomElementsByUserIdResponseUserLora>? userLoras)
        {
            this.UserLoras = userLoras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomElementsByUserIdResponse" /> class.
        /// </summary>
        public GetCustomElementsByUserIdResponse()
        {
        }
    }
}