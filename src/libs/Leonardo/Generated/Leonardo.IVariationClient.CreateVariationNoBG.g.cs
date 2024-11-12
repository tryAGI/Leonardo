#nullable enable

namespace Leonardo
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create no background<br/>
        /// This endpoint will create a no background variation of the provided image ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVariationNoBGResponse> CreateVariationNoBGAsync(
            global::Leonardo.CreateVariationNoBGRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create no background<br/>
        /// This endpoint will create a no background variation of the provided image ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.CreateVariationNoBGResponse> CreateVariationNoBGAsync(
            string id,
            bool? isVariation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}