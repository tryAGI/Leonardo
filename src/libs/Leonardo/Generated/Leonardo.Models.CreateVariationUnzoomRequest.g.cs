
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUnzoomRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVariation")]
        public bool? IsVariation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUnzoomRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVariationUnzoomRequest(
            string? id,
            bool? isVariation)
        {
            this.Id = id;
            this.IsVariation = isVariation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUnzoomRequest" /> class.
        /// </summary>
        public CreateVariationUnzoomRequest()
        {
        }
    }
}