#nullable enable

namespace Leonardo
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Improve a Prompt<br/>
        /// This endpoint returns a improved prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.PromptImproveResponse> PromptImproveAsync(
            global::Leonardo.PromptImproveRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Improve a Prompt<br/>
        /// This endpoint returns a improved prompt
        /// </summary>
        /// <param name="prompt">
        /// The prompt to improve.
        /// </param>
        /// <param name="promptInstructions">
        /// The prompt is improved based on the given instructions.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.PromptImproveResponse> PromptImproveAsync(
            string prompt,
            string? promptInstructions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}