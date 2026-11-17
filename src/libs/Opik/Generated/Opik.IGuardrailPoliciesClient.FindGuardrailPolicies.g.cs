#nullable enable

namespace Opik
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Find guardrail policies<br/>
        /// Find guardrail policies in a workspace
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter policies by name (partial match, case insensitive)
        /// </param>
        /// <param name="names">
        /// Filter policies by exact names, ignoring case, as a JSON array of names
        /// </param>
        /// <param name="executionScope">
        /// Filter policies by execution scope
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.GuardrailPolicyPagePublic> FindGuardrailPoliciesAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? names = default,
            global::Opik.FindGuardrailPoliciesExecutionScope? executionScope = default,
            string? sorting = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find guardrail policies<br/>
        /// Find guardrail policies in a workspace
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter policies by name (partial match, case insensitive)
        /// </param>
        /// <param name="names">
        /// Filter policies by exact names, ignoring case, as a JSON array of names
        /// </param>
        /// <param name="executionScope">
        /// Filter policies by execution scope
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.GuardrailPolicyPagePublic>> FindGuardrailPoliciesAsResponseAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? names = default,
            global::Opik.FindGuardrailPoliciesExecutionScope? executionScope = default,
            string? sorting = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}