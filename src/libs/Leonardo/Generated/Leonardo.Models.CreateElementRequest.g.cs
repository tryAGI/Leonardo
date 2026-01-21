
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateElementRequest
    {
        /// <summary>
        /// The name of the element.<br/>
        /// Default Value: placeholder
        /// </summary>
        /// <default>"placeholder"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; } = "placeholder";

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
        /// Use a word that is closely related to what you're training that isn't too common. For example, instead of 'dog,' try something unique like 'jackthedog' or 'magicdonut'. Required for all non-FLUX_DEV models and FLUX_DEV Character model training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_prompt")]
        public string? InstancePrompt { get; set; }

        /// <summary>
        /// The category determines how the element will be trained. Options are 'General' | 'Character' | 'Style' | 'Object'. FLUX_DEV doesn't support General category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_focus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LoraFocus { get; set; }

        /// <summary>
        /// Whether or not encode the train text.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_text_encoder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TrainTextEncoder { get; set; }

        /// <summary>
        /// The resolution for training. Must be 1024.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// The base version to use if not using a custom model.<br/>
        /// Default Value: FLUX_DEV
        /// </summary>
        /// <default>global::Leonardo.CreateElementRequestSdVersion.FLUXDEV</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CreateElementRequestSdVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.CreateElementRequestSdVersion SdVersion { get; set; } = global::Leonardo.CreateElementRequestSdVersion.FLUXDEV;

        /// <summary>
        /// The number of times the entire training dataset is passed through the element.&lt;table&gt;&lt;tr&gt;&lt;th&gt;Model Type&lt;/th&gt;&lt;th&gt;Lora Focus&lt;/th&gt;&lt;th&gt;Min&lt;/th&gt;&lt;th&gt;Max&lt;/th&gt;&lt;th&gt;Default&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Default&lt;/td&gt;&lt;td&gt;General | Style | Character | Object&lt;/td&gt;&lt;td&gt;1&lt;/td&gt;&lt;td&gt;250&lt;/td&gt;&lt;td&gt;100&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td rowspan='3'&gt;FLUX_DEV&lt;/td&gt;&lt;td&gt;Style&lt;/td&gt;&lt;td&gt;30&lt;/td&gt;&lt;td&gt;120&lt;/td&gt;&lt;td&gt;60&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Object&lt;/td&gt;&lt;td&gt;120&lt;/td&gt;&lt;td&gt;220&lt;/td&gt;&lt;td&gt;140&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Character&lt;/td&gt;&lt;td&gt;100&lt;/td&gt;&lt;td&gt;200&lt;/td&gt;&lt;td&gt;135&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;General&lt;/td&gt;&lt;td colspan='3'&gt;NA&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_train_epochs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTrainEpochs { get; set; }

        /// <summary>
        /// The speed at which the model learns during training.&lt;table&gt;&lt;tr&gt;&lt;th&gt;Model Type&lt;/th&gt;&lt;th&gt;Lora Focus&lt;/th&gt;&lt;th&gt;Min&lt;/th&gt;&lt;th&gt;Max&lt;/th&gt;&lt;th&gt;Default&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Default&lt;/td&gt;&lt;td&gt;General | Style | Character | Object&lt;/td&gt;&lt;td&gt;0.00000001&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.000001&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td rowspan='3'&gt;FLUX_DEV&lt;/td&gt;&lt;td&gt;Style&lt;/td&gt;&lt;td&gt;0.000001&lt;/td&gt;&lt;td&gt;0.00003&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Object&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.001&lt;/td&gt;&lt;td&gt;0.0004&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Character&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.001&lt;/td&gt;&lt;td&gt;0.0005&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;General&lt;/td&gt;&lt;td colspan='3'&gt;NA&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LearningRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateElementRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the element.<br/>
        /// Default Value: placeholder
        /// </param>
        /// <param name="description">
        /// The description of the element.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to train the element on.
        /// </param>
        /// <param name="instancePrompt">
        /// Use a word that is closely related to what you're training that isn't too common. For example, instead of 'dog,' try something unique like 'jackthedog' or 'magicdonut'. Required for all non-FLUX_DEV models and FLUX_DEV Character model training.
        /// </param>
        /// <param name="loraFocus">
        /// The category determines how the element will be trained. Options are 'General' | 'Character' | 'Style' | 'Object'. FLUX_DEV doesn't support General category.
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
        /// The base version to use if not using a custom model.<br/>
        /// Default Value: FLUX_DEV
        /// </param>
        /// <param name="numTrainEpochs">
        /// The number of times the entire training dataset is passed through the element.&lt;table&gt;&lt;tr&gt;&lt;th&gt;Model Type&lt;/th&gt;&lt;th&gt;Lora Focus&lt;/th&gt;&lt;th&gt;Min&lt;/th&gt;&lt;th&gt;Max&lt;/th&gt;&lt;th&gt;Default&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Default&lt;/td&gt;&lt;td&gt;General | Style | Character | Object&lt;/td&gt;&lt;td&gt;1&lt;/td&gt;&lt;td&gt;250&lt;/td&gt;&lt;td&gt;100&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td rowspan='3'&gt;FLUX_DEV&lt;/td&gt;&lt;td&gt;Style&lt;/td&gt;&lt;td&gt;30&lt;/td&gt;&lt;td&gt;120&lt;/td&gt;&lt;td&gt;60&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Object&lt;/td&gt;&lt;td&gt;120&lt;/td&gt;&lt;td&gt;220&lt;/td&gt;&lt;td&gt;140&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Character&lt;/td&gt;&lt;td&gt;100&lt;/td&gt;&lt;td&gt;200&lt;/td&gt;&lt;td&gt;135&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;General&lt;/td&gt;&lt;td colspan='3'&gt;NA&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </param>
        /// <param name="learningRate">
        /// The speed at which the model learns during training.&lt;table&gt;&lt;tr&gt;&lt;th&gt;Model Type&lt;/th&gt;&lt;th&gt;Lora Focus&lt;/th&gt;&lt;th&gt;Min&lt;/th&gt;&lt;th&gt;Max&lt;/th&gt;&lt;th&gt;Default&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Default&lt;/td&gt;&lt;td&gt;General | Style | Character | Object&lt;/td&gt;&lt;td&gt;0.00000001&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.000001&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td rowspan='3'&gt;FLUX_DEV&lt;/td&gt;&lt;td&gt;Style&lt;/td&gt;&lt;td&gt;0.000001&lt;/td&gt;&lt;td&gt;0.00003&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Object&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.001&lt;/td&gt;&lt;td&gt;0.0004&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Character&lt;/td&gt;&lt;td&gt;0.00001&lt;/td&gt;&lt;td&gt;0.001&lt;/td&gt;&lt;td&gt;0.0005&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;General&lt;/td&gt;&lt;td colspan='3'&gt;NA&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateElementRequest(
            string name,
            string datasetId,
            string loraFocus,
            bool trainTextEncoder,
            global::Leonardo.CreateElementRequestSdVersion sdVersion,
            int numTrainEpochs,
            double learningRate,
            string? description,
            string? instancePrompt,
            int? resolution)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.LoraFocus = loraFocus ?? throw new global::System.ArgumentNullException(nameof(loraFocus));
            this.TrainTextEncoder = trainTextEncoder;
            this.SdVersion = sdVersion;
            this.NumTrainEpochs = numTrainEpochs;
            this.LearningRate = learningRate;
            this.Description = description;
            this.InstancePrompt = instancePrompt;
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