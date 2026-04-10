#nullable enable

namespace Leonardo
{
    public partial interface IPricingCalculatorClient
    {
        /// <summary>
        /// Calculating API Cost<br/>
        /// This endpoint returns the cost used for generating images using a particular service type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.PricingCalculatorResponse> PricingCalculatorAsync(

            global::Leonardo.PricingCalculatorRequest request,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calculating API Cost<br/>
        /// This endpoint returns the cost used for generating images using a particular service type.
        /// </summary>
        /// <param name="service">
        /// The services to be chosen for calculating the API credit cost.
        /// </param>
        /// <param name="serviceParams">
        /// Parameters for the service
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.PricingCalculatorResponse> PricingCalculatorAsync(
            global::Leonardo.PricingCalculatorServices? service = default,
            global::Leonardo.PricingCalculatorRequestServiceParams? serviceParams = default,
            global::Leonardo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}