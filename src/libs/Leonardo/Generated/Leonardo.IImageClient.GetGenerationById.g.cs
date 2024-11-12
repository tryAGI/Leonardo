#nullable enable

namespace Leonardo
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Get a Single Generation<br/>
        /// This endpoint will provide information about a specific generation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetGenerationByIdResponse> GetGenerationByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}