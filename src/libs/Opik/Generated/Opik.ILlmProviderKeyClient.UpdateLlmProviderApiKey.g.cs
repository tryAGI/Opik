#nullable enable

namespace Opik
{
    public partial interface ILlmProviderKeyClient
    {
        /// <summary>
        /// Update LLM Provider's ApiKey<br/>
        /// Update LLM Provider's ApiKey. api_key and auth_config are mutually exclusive: setting a valid auth_config on a provider that holds a static api_key clears the stored key; send auth_config as an empty object to clear the recipe and switch back to a static key
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateLlmProviderApiKeyAsync(
            global::System.Guid id,

            global::Opik.ProviderApiKeyUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update LLM Provider's ApiKey<br/>
        /// Update LLM Provider's ApiKey. api_key and auth_config are mutually exclusive: setting a valid auth_config on a provider that holds a static api_key clears the stored key; send auth_config as an empty object to clear the recipe and switch back to a static key
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> UpdateLlmProviderApiKeyAsResponseAsync(
            global::System.Guid id,

            global::Opik.ProviderApiKeyUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update LLM Provider's ApiKey<br/>
        /// Update LLM Provider's ApiKey. api_key and auth_config are mutually exclusive: setting a valid auth_config on a provider that holds a static api_key clears the stored key; send auth_config as an empty object to clear the recipe and switch back to a static key
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiKey"></param>
        /// <param name="name"></param>
        /// <param name="providerName">
        /// Provider name - can be set to migrate legacy custom LLM or Bedrock providers to the new multi-provider format. Once set, it cannot be changed. Should only be set for custom LLM and Bedrock providers.<br/>
        /// Example: ollama
        /// </param>
        /// <param name="headers"></param>
        /// <param name="configuration"></param>
        /// <param name="baseUrl"></param>
        /// <param name="authConfig">
        /// Dynamic token auth recipe. Send the '__SECRET__' sentinel as a credential value to keep the stored secret; send an empty object to clear the auth config.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateLlmProviderApiKeyAsync(
            global::System.Guid id,
            string? apiKey = default,
            string? name = default,
            string? providerName = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::System.Collections.Generic.Dictionary<string, string>? configuration = default,
            string? baseUrl = default,
            global::Opik.ProviderAuthConfig? authConfig = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}