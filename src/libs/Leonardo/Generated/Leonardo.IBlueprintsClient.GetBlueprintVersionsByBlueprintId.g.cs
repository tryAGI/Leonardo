#nullable enable

namespace Leonardo
{
    public partial interface IBlueprintsClient
    {
        /// <summary>
        /// Get Blueprint Versions by Blueprint ID<br/>
        /// Returns all versions of a Blueprint by its akUUID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>> GetBlueprintVersionsByBlueprintIdAsync(
            global::System.Guid id,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}