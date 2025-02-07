
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateElementResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdTrainingJob")]
        public global::Leonardo.CreateElementResponseSdTrainingJob? SdTrainingJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateElementResponse" /> class.
        /// </summary>
        /// <param name="sdTrainingJob"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateElementResponse(
            global::Leonardo.CreateElementResponseSdTrainingJob? sdTrainingJob)
        {
            this.SdTrainingJob = sdTrainingJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateElementResponse" /> class.
        /// </summary>
        public CreateElementResponse()
        {
        }
    }
}