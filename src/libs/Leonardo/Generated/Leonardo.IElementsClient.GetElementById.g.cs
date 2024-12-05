#nullable enable

namespace Leonardo
{
    public partial interface IElementsClient
    {
        /// <summary>
        /// Get a Single Custom Element by ID<br/>
        /// This endpoint gets the specific custom element.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetElementByIdResponse> GetElementByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}