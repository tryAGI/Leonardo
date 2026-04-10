#nullable enable

namespace Leonardo
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Get a Single Generation<br/>
        /// This endpoint will provide information about a specific generation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetGenerationByIdResponse> GetGenerationByIdAsync(
            string id,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}