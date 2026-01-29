#nullable enable

namespace Leonardo
{
    public partial interface IBlueprintsClient
    {
        /// <summary>
        /// Execute a Blueprint<br/>
        /// Execute a Blueprint Version with custom node inputs. This endpoint triggers the execution of the specified Blueprint Version and returns a Blueprint Execution ID to track the job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>> ExecuteBlueprintAsync(
            global::Leonardo.ExecuteBlueprintRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute a Blueprint<br/>
        /// Execute a Blueprint Version with custom node inputs. This endpoint triggers the execution of the specified Blueprint Version and returns a Blueprint Execution ID to track the job.
        /// </summary>
        /// <param name="blueprintVersionId">
        /// The unique identifier of the Blueprint Version to execute<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="input"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>> ExecuteBlueprintAsync(
            global::System.Guid blueprintVersionId,
            global::Leonardo.ExecuteBlueprintRequestInput input,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}