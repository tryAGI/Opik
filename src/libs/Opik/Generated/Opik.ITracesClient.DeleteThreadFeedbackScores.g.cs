#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete thread feedback scores<br/>
        /// Delete thread feedback scores
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteThreadFeedbackScoresAsync(

            global::Opik.DeleteThreadFeedbackScores request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete thread feedback scores<br/>
        /// Delete thread feedback scores
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="threadId"></param>
        /// <param name="names"></param>
        /// <param name="author"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteThreadFeedbackScoresAsync(
            string projectName,
            string threadId,
            global::System.Collections.Generic.IList<string> names,
            string? author = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}