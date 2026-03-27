#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Add trace comment<br/>
        /// Add trace comment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task AddTraceCommentAsync(
            global::System.Guid id,

            global::Opik.Comment request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add trace comment<br/>
        /// Add trace comment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AddTraceCommentAsync(
            global::System.Guid id,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}