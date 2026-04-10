#nullable enable

namespace Opik
{
    public partial interface IRetentionRulesClient
    {
        /// <summary>
        /// Deactivate retention rule<br/>
        /// Soft-deactivate a retention rule (sets enabled=false). Rules are never hard-deleted for audit trail.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeactivateRetentionRuleAsync(
            global::System.Guid ruleId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}