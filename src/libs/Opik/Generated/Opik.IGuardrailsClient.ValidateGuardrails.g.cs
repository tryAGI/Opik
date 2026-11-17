#nullable enable

namespace Opik
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Run guardrail checks on a text<br/>
        /// Runs the requested checks on the text through the Opik inference decision service and returns a verdict per check. Writes nothing: the SDK reports the results to the guardrails batch endpoint, as before.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.GuardrailsValidationResponse> ValidateGuardrailsAsync(

            global::Opik.GuardrailsValidationRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run guardrail checks on a text<br/>
        /// Runs the requested checks on the text through the Opik inference decision service and returns a verdict per check. Writes nothing: the SDK reports the results to the guardrails batch endpoint, as before.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.GuardrailsValidationResponse>> ValidateGuardrailsAsResponseAsync(

            global::Opik.GuardrailsValidationRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run guardrail checks on a text<br/>
        /// Runs the requested checks on the text through the Opik inference decision service and returns a verdict per check. Writes nothing: the SDK reports the results to the guardrails batch endpoint, as before.
        /// </summary>
        /// <param name="text">
        /// The text to check, at most 16384 characters as the decision service counts them: on the text's JSON encoding, so the two quotes count, a quote, backslash or line break counts as 2, and any other control or non-ASCII character as 6 (an emoji as 12). In practice about 16,380 characters of English text fit, about 2,730 of text in Cyrillic, Greek, Hebrew, Arabic, Chinese or Japanese, and about 1,365 emoji. A longer text is rejected rather than cut.
        /// </param>
        /// <param name="validations">
        /// The checks to run. Together they must fit in 64 questions to the decision service, asked in up to two calls of 32: each PII class and each topic list is one question, prompt injection is one
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.GuardrailsValidationResponse> ValidateGuardrailsAsync(
            string text,
            global::System.Collections.Generic.IList<global::Opik.ValidationDescriptor> validations,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}