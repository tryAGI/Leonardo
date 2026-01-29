#nullable enable

namespace Leonardo
{
    public partial interface IBlueprintsClient
    {
        /// <summary>
        /// List Blueprints<br/>
        /// Returns a list of Blueprints. Use either forward pagination (first/after) or backward pagination (last/before), but not both. Note: This endpoint uses a request body to support complex filtering parameters
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Leonardo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>> ListBlueprintsAsync(
            global::Leonardo.ListBlueprintsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// List Blueprints<br/>
        /// Returns a list of Blueprints. Use either forward pagination (first/after) or backward pagination (last/before), but not both. Note: This endpoint uses a request body to support complex filtering parameters
        /// </summary>
        /// <param name="first">
        /// Number of items to return after the cursor (forward pagination)<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="after">
        /// Cursor to paginate forward from
        /// </param>
        /// <param name="last">
        /// Number of items to return before the cursor (backward pagination)
        /// </param>
        /// <param name="before">
        /// Cursor to paginate backward from
        /// </param>
        /// <param name="platforms">
        /// Filter Blueprints by platforms that they can be executed on<br/>
        /// Default Value: [API]<br/>
        /// Example: [API, Web]
        /// </param>
        /// <param name="categories">
        /// Filter Blueprints by category<br/>
        /// Example: [social-media]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>> ListBlueprintsAsync(
            int? first = default,
            string? after = default,
            int? last = default,
            string? before = default,
            global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsRequestPlatform>? platforms = default,
            global::System.Collections.Generic.IList<string>? categories = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}