#nullable enable

namespace Leonardo
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// Create a Dataset<br/>
        /// This endpoint creates a new dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateDatasetResponse> CreateDatasetAsync(

            global::Leonardo.CreateDatasetRequest request,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Dataset<br/>
        /// This endpoint creates a new dataset
        /// </summary>
        /// <param name="name">
        /// The name of the dataset.
        /// </param>
        /// <param name="description">
        /// A description for the dataset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            string? description = default,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}