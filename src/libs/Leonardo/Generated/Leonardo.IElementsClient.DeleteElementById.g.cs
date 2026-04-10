#nullable enable

namespace Leonardo
{
    public partial interface IElementsClient
    {
        /// <summary>
        /// Delete a Single Custom Element by ID<br/>
        /// This endpoint will delete a specific custom model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.DeleteElementByIdResponse> DeleteElementByIdAsync(
            int id,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}