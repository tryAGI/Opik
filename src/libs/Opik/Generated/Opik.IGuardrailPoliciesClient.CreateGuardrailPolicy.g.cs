#nullable enable

namespace Opik
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Create guardrail policy<br/>
        /// Create a guardrail policy with its rules in a workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateGuardrailPolicyAsync(

            global::Opik.GuardrailPolicyWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create guardrail policy<br/>
        /// Create a guardrail policy with its rules in a workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CreateGuardrailPolicyAsResponseAsync(

            global::Opik.GuardrailPolicyWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create guardrail policy<br/>
        /// Create a guardrail policy with its rules in a workspace
        /// </summary>
        /// <param name="id">
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
        global::System.Threading.Tasks.Task CreateGuardrailPolicyAsync(
            string name,
            global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRuleWrite> rules,
            global::System.Guid? id = default,
            string? description = default,
            global::Opik.GuardrailPolicyWriteExecutionScope? executionScope = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}