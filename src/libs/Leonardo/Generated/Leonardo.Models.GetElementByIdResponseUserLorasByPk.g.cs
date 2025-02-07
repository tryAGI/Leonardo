
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "user_loras".
    /// </summary>
    public sealed partial class GetElementByIdResponseUserLorasByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancePrompt")]
        public string? InstancePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learningRate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingEpoch")]
        public int? TrainingEpoch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainTextEncoder")]
        public bool? TrainTextEncoder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.JobStatusJsonConverter))]
        public global::Leonardo.JobStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus")]
        public string? Focus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetElementByIdResponseUserLorasByPk" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="instancePrompt"></param>
        /// <param name="resolution"></param>
        /// <param name="learningRate"></param>
        /// <param name="trainingEpoch"></param>
        /// <param name="name"></param>
        /// <param name="trainTextEncoder"></param>
        /// <param name="baseModel"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        /// <param name="focus"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetElementByIdResponseUserLorasByPk(
            string? createdAt,
            string? description,
            int? id,
            string? instancePrompt,
            int? resolution,
            double? learningRate,
            int? trainingEpoch,
            string? name,
            bool? trainTextEncoder,
            string? baseModel,
            global::Leonardo.JobStatus? status,
            string? focus,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id;
            this.InstancePrompt = instancePrompt;
            this.Resolution = resolution;
            this.LearningRate = learningRate;
            this.TrainingEpoch = trainingEpoch;
            this.Name = name;
            this.TrainTextEncoder = trainTextEncoder;
            this.BaseModel = baseModel;
            this.Status = status;
            this.Focus = focus;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetElementByIdResponseUserLorasByPk" /> class.
        /// </summary>
        public GetElementByIdResponseUserLorasByPk()
        {
        }
    }
}