#nullable enable

namespace Leonardo
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Get motion variation by ID<br/>
        /// This endpoint will get the motion variation by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetMotionVariationByIdResponse> GetMotionVariationByIdAsync(
            string id,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}