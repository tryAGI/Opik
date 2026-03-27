#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Find Feedback Score names<br/>
        /// Find Feedback Score names
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.FeedbackScoreNamesPublic> FindFeedbackScoreNames1Async(
            global::System.Guid? projectId = default,
            global::Opik.FindFeedbackScoreNames1Type? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}