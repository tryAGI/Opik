#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete trace threads<br/>
        /// Delete trace threads
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceThreadsAsync(

            global::Opik.DeleteTraceThreads request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete trace threads<br/>
        /// Delete trace threads
        /// </summary>
        /// <param name="projectName">
        /// If null, project_id must be provided
        /// </param>
        /// <param name="projectId">
        /// If null, project_name must be provided
        /// </param>
        /// <param name="threadIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceThreadsAsync(
            global::System.Collections.Generic.IList<string> threadIds,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}