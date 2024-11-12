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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateDatasetResponse> CreateDatasetAsync(
            global::Leonardo.CreateDatasetRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}