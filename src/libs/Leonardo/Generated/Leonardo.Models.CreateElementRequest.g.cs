
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateElementRequest
    {
        /// <summary>
        /// The name of the element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the dataset to train the element on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// The instance prompt to use during training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstancePrompt { get; set; }

        /// <summary>
        /// The category determines how the element will be trained. Options are 'General' | 'Character' | 'Style' | 'Object'.<br/>
        /// Default Value: General
        /// </summary>
        /// <default>"General"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_focus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LoraFocus { get; set; } = "General";

        /// <summary>
        /// Whether or not encode the train text.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_text_encoder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TrainTextEncoder { get; set; } = true;

        /// <summary>
        /// The resolution for training. Must be 1024.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.SdVersionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.SdVersions SdVersion { get; set; }

        /// <summary>
        /// The number of times the entire training dataset is passed through the element.<br/>
        /// Default Value: 100
        /// </summary>
        /// <default>100</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_train_epochs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTrainEpochs { get; set; } = 100;

        /// <summary>
        /// The speed of element learns.<br/>
        /// Default Value: 1E-06
        /// </summary>
        /// <default>1E-06</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LearningRate { get; set; } = 1E-06;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateElementRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the element.
        /// </param>
        /// <param name="description">
        /// The description of the element.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to train the element on.
        /// </param>
        /// <param name="instancePrompt">
        /// The instance prompt to use during training.
        /// </param>
        /// <param name="loraFocus">
        /// The category determines how the element will be trained. Options are 'General' | 'Character' | 'Style' | 'Object'.<br/>
        /// Default Value: General
        /// </param>
        /// <param name="trainTextEncoder">
        /// Whether or not encode the train text.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="resolution">
        /// The resolution for training. Must be 1024.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="sdVersion">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="numTrainEpochs">
        /// The number of times the entire training dataset is passed through the element.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="learningRate">
        /// The speed of element learns.<br/>
        /// Default Value: 1E-06
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateElementRequest(
            string name,
            string datasetId,
            string instancePrompt,
            string loraFocus,
            bool trainTextEncoder,
            global::Leonardo.SdVersions sdVersion,
            int numTrainEpochs,
            double learningRate,
            string? description,
            int? resolution)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.InstancePrompt = instancePrompt ?? throw new global::System.ArgumentNullException(nameof(instancePrompt));
            this.LoraFocus = loraFocus ?? throw new global::System.ArgumentNullException(nameof(loraFocus));
            this.TrainTextEncoder = trainTextEncoder;
            this.SdVersion = sdVersion;
            this.NumTrainEpochs = numTrainEpochs;
            this.LearningRate = learningRate;
            this.Description = description;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateElementRequest" /> class.
        /// </summary>
        public CreateElementRequest()
        {
        }
    }
}