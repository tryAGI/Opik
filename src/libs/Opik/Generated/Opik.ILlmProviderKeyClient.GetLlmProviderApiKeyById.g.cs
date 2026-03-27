#nullable enable

namespace Opik
{
    public partial interface ILlmProviderKeyClient
    {
        /// <summary>
        /// Get LLM Provider's ApiKey by id<br/>
        /// Get LLM Provider's ApiKey by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProviderApiKeyPublic> GetLlmProviderApiKeyByIdAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}