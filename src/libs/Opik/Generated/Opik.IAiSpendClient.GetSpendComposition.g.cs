#nullable enable

namespace Opik
{
    public partial interface IAiSpendClient
    {
        /// <summary>
        /// Get spend composition<br/>
        /// Get coding-agent token-flow composition (Sankey)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.SpendCompositionResponse> GetSpendCompositionAsync(

            global::Opik.SpendMetricRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get spend composition<br/>
        /// Get coding-agent token-flow composition (Sankey)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.SpendCompositionResponse>> GetSpendCompositionAsResponseAsync(

            global::Opik.SpendMetricRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get spend composition<br/>
        /// Get coding-agent token-flow composition (Sankey)
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Opik.SpendCompositionResponse> GetSpendCompositionAsync(
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? userId = default,
            bool? startBeforeEnd = default,
            bool? projectProvided = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}