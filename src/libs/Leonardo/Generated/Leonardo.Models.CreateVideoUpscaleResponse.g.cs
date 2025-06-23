
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoUpscaleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motionVideoGenerationJob")]
        public global::Leonardo.CreateVideoUpscaleResponseMotionVideoGenerationJob? MotionVideoGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleResponse" /> class.
        /// </summary>
        /// <param name="motionVideoGenerationJob"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoUpscaleResponse(
            global::Leonardo.CreateVideoUpscaleResponseMotionVideoGenerationJob? motionVideoGenerationJob)
        {
            this.MotionVideoGenerationJob = motionVideoGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleResponse" /> class.
        /// </summary>
        public CreateVideoUpscaleResponse()
        {
        }
    }
}