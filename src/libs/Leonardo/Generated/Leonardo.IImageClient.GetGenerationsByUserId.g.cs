#nullable enable

namespace Leonardo
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Get generations by user ID<br/>
        /// This endpoint returns all generations by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetGenerationsByUserIdResponse> GetGenerationsByUserIdAsync(
            string userId,
            int? offset = default,
            int? limit = default,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}