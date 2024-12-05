
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateElementResponseSdTrainingJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLoraId")]
        public int? UserLoraId { get; set; }

        /// <summary>
        /// API Credits Cost for Model Training. Available for Production API Users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateElementResponseSdTrainingJob" /> class.
        /// </summary>
        /// <param name="userLoraId"></param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Model Training. Available for Production API Users.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateElementResponseSdTrainingJob(
            int? userLoraId,
            int? apiCreditCost)
        {
            this.UserLoraId = userLoraId;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateElementResponseSdTrainingJob" /> class.
        /// </summary>
        public CreateElementResponseSdTrainingJob()
        {
        }
    }
}