#nullable enable

namespace Leonardo
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Get motion variation by ID<br/>
        /// This endpoint will get the motion variation by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.GetMotionVariationByIdResponse> GetMotionVariationByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}