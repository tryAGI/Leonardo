
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformInstantRefineResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lcmGenerationJob")]
        public global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? LcmGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInstantRefineResponse" /> class.
        /// </summary>
        /// <param name="lcmGenerationJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PerformInstantRefineResponse(
            global::Leonardo.PerformInstantRefineResponseLcmGenerationJob? lcmGenerationJob)
        {
            this.LcmGenerationJob = lcmGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInstantRefineResponse" /> class.
        /// </summary>
        public PerformInstantRefineResponse()
        {
        }
    }
}