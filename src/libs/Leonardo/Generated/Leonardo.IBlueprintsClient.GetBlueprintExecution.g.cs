#nullable enable

namespace Leonardo
{
    public partial interface IBlueprintsClient
    {
        /// <summary>
        /// Get Blueprint Execution by ID<br/>
        /// Retrieves details of a specific Blueprint Execution by its akUUID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>> GetBlueprintExecutionAsync(
            string? id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}