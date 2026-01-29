#nullable enable

namespace Leonardo
{
    public partial interface IBlueprintsClient
    {
        /// <summary>
        /// Get Blueprint Execution Generations by Execution ID<br/>
        /// Retrieves paginated generations for a specific Blueprint Execution, including their statuses and any prompt moderation failure details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="first"></param>
        /// <param name="after">
        /// An opaque cursor used for pagination
        /// </param>
        /// <param name="last"></param>
        /// <param name="before">
        /// An opaque cursor used for pagination
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetBlueprintExecutionGenerationsResponse> GetBlueprintExecutionGenerationsAsync(
            string? id,
            int? first = default,
            string? after = default,
            int? last = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}