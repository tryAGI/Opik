#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Delete span feedback score<br/>
        /// Delete span feedback score
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpanFeedbackScoreAsync(
            global::System.Guid id,

            global::Opik.DeleteFeedbackScore request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete span feedback score<br/>
        /// Delete span feedback score
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteSpanFeedbackScoreAsync(
            global::System.Guid id,
            string name,
            string? author = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}