#nullable enable

namespace Leonardo
{
    public partial interface IElementsClient
    {
        /// <summary>
        /// Train a Custom Element<br/>
        /// This endpoint will train a new custom element.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateElementResponse> CreateElementAsync(
            global::Leonardo.CreateElementRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Train a Custom Element<br/>
        /// This endpoint will train a new custom element.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateElementResponse> CreateElementAsync(
            string name,
            string datasetId,
            string loraFocus,
            bool trainTextEncoder,
            global::Leonardo.CreateElementRequestSdVersion sdVersion,
            int numTrainEpochs,
            double learningRate,
            string? description = default,
            string? instancePrompt = default,
            int? resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}