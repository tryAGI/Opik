#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Find Trace Threads Feedback Score names<br/>
        /// Find Trace Threads Feedback Score names
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.FeedbackScoreNamesPublic> FindTraceThreadsFeedbackScoreNamesAsync(
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}