#nullable enable

namespace Opik
{
    public partial interface IAiSpendClient
    {
        /// <summary>
        /// Get spend user leaderboard<br/>
        /// Get coding-agent spend per user
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 25
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="name">
        /// Filter users by name or email (partial match, case insensitive)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.SpendUserPage> GetSpendUsersAsync(

            global::Opik.SpendMetricRequest request,
            int? page = default,
            int? size = default,
            string? sorting = default,
            string? name = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get spend user leaderboard<br/>
        /// Get coding-agent spend per user
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 25
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="name">
        /// Filter users by name or email (partial match, case insensitive)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.SpendUserPage>> GetSpendUsersAsResponseAsync(

            global::Opik.SpendMetricRequest request,
            int? page = default,
            int? size = default,
            string? sorting = default,
            string? name = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get spend user leaderboard<br/>
        /// Get coding-agent spend per user
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 25
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="name">
        /// Filter users by name or email (partial match, case insensitive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="userId"></param>
        /// <param name="startBeforeEnd"></param>
        /// <param name="projectProvided"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.SpendUserPage> GetSpendUsersAsync(
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            int? page = default,
            int? size = default,
            string? sorting = default,
            string? name = default,
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? userId = default,
            bool? startBeforeEnd = default,
            bool? projectProvided = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}