
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCustomModelsByUserIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_models")]
        public global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>? CustomModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomModelsByUserIdResponse" /> class.
        /// </summary>
        /// <param name="customModels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCustomModelsByUserIdResponse(
            global::System.Collections.Generic.IList<global::Leonardo.GetCustomModelsByUserIdResponseCustomModel>? customModels)
        {
            this.CustomModels = customModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomModelsByUserIdResponse" /> class.
        /// </summary>
        public GetCustomModelsByUserIdResponse()
        {
        }
    }
}