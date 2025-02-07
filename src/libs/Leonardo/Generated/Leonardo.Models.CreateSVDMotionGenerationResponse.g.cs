
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSVDMotionGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motionSvdGenerationJob")]
        public global::Leonardo.CreateSVDMotionGenerationResponseMotionSvdGenerationJob? MotionSvdGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSVDMotionGenerationResponse" /> class.
        /// </summary>
        /// <param name="motionSvdGenerationJob"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSVDMotionGenerationResponse(
            global::Leonardo.CreateSVDMotionGenerationResponseMotionSvdGenerationJob? motionSvdGenerationJob)
        {
            this.MotionSvdGenerationJob = motionSvdGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSVDMotionGenerationResponse" /> class.
        /// </summary>
        public CreateSVDMotionGenerationResponse()
        {
        }
    }
}