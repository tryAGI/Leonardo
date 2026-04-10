#nullable enable

namespace Leonardo
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Generate a Random prompt<br/>
        /// This endpoint returns a random prompt
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.PromptRandomResponse> PromptRandomAsync(
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}