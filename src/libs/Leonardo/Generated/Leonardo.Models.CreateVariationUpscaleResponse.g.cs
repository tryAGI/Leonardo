
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUpscaleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdUpscaleJob")]
        public global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? SdUpscaleJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponse" /> class.
        /// </summary>
        /// <param name="sdUpscaleJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateVariationUpscaleResponse(
            global::Leonardo.CreateVariationUpscaleResponseSdUpscaleJob? sdUpscaleJob)
        {
            this.SdUpscaleJob = sdUpscaleJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponse" /> class.
        /// </summary>
        public CreateVariationUpscaleResponse()
        {
        }
    }
}