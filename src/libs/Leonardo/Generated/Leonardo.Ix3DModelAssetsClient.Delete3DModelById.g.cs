#nullable enable

namespace Leonardo
{
    public partial interface Ix3DModelAssetsClient
    {
        /// <summary>
        /// Delete 3D Model by ID<br/>
        /// This endpoint deletes the specific 3D Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.Delete3DModelByIdResponse> Delete3DModelByIdAsync(
            string id,
            global::Leonardo.Delete3DModelByIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete 3D Model by ID<br/>
        /// This endpoint deletes the specific 3D Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.Delete3DModelByIdResponse> Delete3DModelByIdAsync(
            string id,
            string? requestId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}