#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete prompts<br/>
        /// Delete prompts batch
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptsBatchAsync(

            global::Opik.BatchDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete prompts<br/>
        /// Delete prompts batch
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeletePromptsBatchAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}