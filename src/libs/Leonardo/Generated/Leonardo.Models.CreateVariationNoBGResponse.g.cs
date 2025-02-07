
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationNoBGResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdNobgJob")]
        public global::Leonardo.CreateVariationNoBGResponseSdNobgJob? SdNobgJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGResponse" /> class.
        /// </summary>
        /// <param name="sdNobgJob"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVariationNoBGResponse(
            global::Leonardo.CreateVariationNoBGResponseSdNobgJob? sdNobgJob)
        {
            this.SdNobgJob = sdNobgJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGResponse" /> class.
        /// </summary>
        public CreateVariationNoBGResponse()
        {
        }
    }
}