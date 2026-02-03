
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextureGenerationResponseTextureGenerationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// API Credits Cost for Texture Generation. Available for Production API Users. Note: it will be deprecated. Please use the cost instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// The cost of the operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::Leonardo.Cost? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationResponseTextureGenerationJob" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cost">
        /// The cost of the operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextureGenerationResponseTextureGenerationJob(
            string? id,
            global::Leonardo.Cost? cost)
        {
            this.Id = id;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationResponseTextureGenerationJob" /> class.
        /// </summary>
        public CreateTextureGenerationResponseTextureGenerationJob()
        {
        }
    }
}