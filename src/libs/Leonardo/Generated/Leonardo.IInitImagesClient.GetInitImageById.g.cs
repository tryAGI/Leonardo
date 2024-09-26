#nullable enable

namespace Leonardo
{
    public partial interface IInitImagesClient
    {
        /// <summary>
        /// Get single init image<br/>
        /// This endpoint will return a single init image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetInitImageByIdResponse> GetInitImageByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}