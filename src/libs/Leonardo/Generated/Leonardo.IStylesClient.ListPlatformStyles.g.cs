#nullable enable

namespace Leonardo
{
    public partial interface IStylesClient
    {
        /// <summary>
        /// List Platform Styles<br/>
        /// Get a list of public Platform Styles available for use with generations.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.ListPlatformStylesResponse> ListPlatformStylesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}