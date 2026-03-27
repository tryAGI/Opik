#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt by commit<br/>
        /// Get prompt by commit
        /// </summary>
        /// <param name="commit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.PromptDetail> GetPromptByCommitAsync(
            string commit,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}