#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt version by id<br/>
        /// Get prompt version by id
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.PromptVersionDetail> GetPromptVersionByIdAsync(
            global::System.Guid versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}