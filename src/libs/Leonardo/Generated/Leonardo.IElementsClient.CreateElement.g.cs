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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateElementResponse> CreateElementAsync(
            string name,
            string datasetId,
            string instancePrompt,
            string loraFocus,
            bool trainTextEncoder,
            global::Leonardo.SdVersions sdVersion,
            int numTrainEpochs,
            double learningRate,
            string? description = default,
            int? resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}