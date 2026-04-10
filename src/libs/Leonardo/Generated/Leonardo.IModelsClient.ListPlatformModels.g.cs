#nullable enable

namespace Leonardo
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Platform Models<br/>
        /// Get a list of public Platform Models available for use with generations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.ListPlatformModelsResponse> ListPlatformModelsAsync(
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}