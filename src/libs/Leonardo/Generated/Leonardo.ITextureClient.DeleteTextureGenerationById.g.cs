#nullable enable

namespace Leonardo
{
    public partial interface ITextureClient
    {
        /// <summary>
        /// Delete Texture Generation by ID<br/>
        /// This endpoint deletes the specific texture generation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.DeleteTextureGenerationByIdResponse> DeleteTextureGenerationByIdAsync(
            string id,
            global::Leonardo.DeleteTextureGenerationByIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Texture Generation by ID<br/>
        /// This endpoint deletes the specific texture generation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.DeleteTextureGenerationByIdResponse> DeleteTextureGenerationByIdAsync(
            string id,
            string? requestId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}