#nullable enable

namespace Leonardo
{
    public partial interface IElementsClient
    {
        /// <summary>
        /// Get a list of Custom Elements by User ID<br/>
        /// This endpoint gets the list of custom elements belongs to the user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetCustomElementsByUserIdResponse> GetCustomElementsByUserIdAsync(
            string userId,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}