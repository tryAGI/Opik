#nullable enable

namespace Opik
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Update guardrail policy<br/>
        /// Replace a guardrail policy, rules included: a rule left out of the request is removed
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateGuardrailPolicyAsync(
            global::System.Guid id,

            global::Opik.GuardrailPolicyWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update guardrail policy<br/>
        /// Replace a guardrail policy, rules included: a rule left out of the request is removed
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> UpdateGuardrailPolicyAsResponseAsync(
            global::System.Guid id,

            global::Opik.GuardrailPolicyWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update guardrail policy<br/>
        /// Replace a guardrail policy, rules included: a rule left out of the request is removed
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId">
        /// Optional on create, generated when missing, as for prompts and datasets. Ignored on update, where the path names the policy
        /// </param>
        /// <param name="name">
        /// The SDK names policies by name, so it is unique in the workspace, ignoring case
        /// </param>
        /// <param name="description"></param>
        /// <param name="executionScope">
        /// on_request applies the policy when the SDK names it, global applies it to every guardrail built from stored policies in the workspace. Missing or null means on_request<br/>
        /// Default Value: on_request
        /// </param>
        /// <param name="rules">
        /// At most one rule per type
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateGuardrailPolicyAsync(
            global::System.Guid id,
            string name,
            global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRuleWrite> rules,
            global::System.Guid? requestId = default,
            string? description = default,
            global::Opik.GuardrailPolicyWriteExecutionScope? executionScope = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}