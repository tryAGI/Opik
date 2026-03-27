#nullable enable

namespace Opik
{
    public partial interface ILlmProviderKeyClient
    {
        /// <summary>
        /// Find LLM Provider's ApiKeys<br/>
        /// Find LLM Provider's ApiKeys
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProviderApiKeyPagePublic> FindLlmProviderKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}