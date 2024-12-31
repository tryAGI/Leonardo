#nullable enable

namespace Leonardo
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get a list of Custom Models by User ID<br/>
        /// This endpoint gets the list of custom models belongs to the user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetCustomModelsByUserIdResponse> GetCustomModelsByUserIdAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}