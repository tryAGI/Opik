#nullable enable

namespace Opik
{
    public partial interface IRetentionRulesClient
    {
        /// <summary>
        /// Get retention rule by id<br/>
        /// Get a specific retention rule by id
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.RetentionRulePublic> GetRetentionRuleByIdAsync(
            global::System.Guid ruleId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}