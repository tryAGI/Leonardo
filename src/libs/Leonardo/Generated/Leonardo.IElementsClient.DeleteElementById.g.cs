#nullable enable

namespace Leonardo
{
    public partial interface IElementsClient
    {
        /// <summary>
        /// Delete a Single Custom Element by ID<br/>
        /// This endpoint will delete a specific custom model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.DeleteElementByIdResponse> DeleteElementByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}