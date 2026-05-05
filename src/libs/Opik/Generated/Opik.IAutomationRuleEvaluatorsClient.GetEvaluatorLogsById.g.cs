#nullable enable

namespace Opik
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Get automation rule evaluator logs by id<br/>
        /// Get automation rule evaluator logs by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="size">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.LogPage> GetEvaluatorLogsByIdAsync(
            global::System.Guid id,
            int? size = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get automation rule evaluator logs by id<br/>
        /// Get automation rule evaluator logs by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="size">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.LogPage>> GetEvaluatorLogsByIdAsResponseAsync(
            global::System.Guid id,
            int? size = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}