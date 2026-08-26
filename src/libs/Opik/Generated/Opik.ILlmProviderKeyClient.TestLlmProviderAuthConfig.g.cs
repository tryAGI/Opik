#nullable enable

namespace Opik
{
    public partial interface ILlmProviderKeyClient
    {
        /// <summary>
        /// Test a provider's dynamic token auth<br/>
        /// Runs the token fetch once, backend-side, and reports the token lifetime. The token itself is never returned. Send provider_id to test the stored config, auth_config to test submitted values, or both to resolve secret sentinels against the stored config.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Result> TestLlmProviderAuthConfigAsync(

            global::Opik.ProviderAuthCheck request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test a provider's dynamic token auth<br/>
        /// Runs the token fetch once, backend-side, and reports the token lifetime. The token itself is never returned. Send provider_id to test the stored config, auth_config to test submitted values, or both to resolve secret sentinels against the stored config.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.Result>> TestLlmProviderAuthConfigAsResponseAsync(

            global::Opik.ProviderAuthCheck request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test a provider's dynamic token auth<br/>
        /// Runs the token fetch once, backend-side, and reports the token lifetime. The token itself is never returned. Send provider_id to test the stored config, auth_config to test submitted values, or both to resolve secret sentinels against the stored config.
        /// </summary>
        /// <param name="providerId">
        /// Test the stored auth config of this provider; also the sentinel-resolution target when auth_config is sent
        /// </param>
        /// <param name="authConfig">
        /// Dynamic token auth recipe. Send the '__SECRET__' sentinel as a credential value to keep the stored secret; send an empty object to clear the auth config.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Result> TestLlmProviderAuthConfigAsync(
            global::System.Guid? providerId = default,
            global::Opik.ProviderAuthConfig? authConfig = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}