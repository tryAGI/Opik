#nullable enable

namespace Opik
{
    public partial interface ILlmModelsClient
    {
        /// <summary>
        /// Get LLM models<br/>
        /// Get the list of supported LLM models grouped by provider
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetLlmModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}