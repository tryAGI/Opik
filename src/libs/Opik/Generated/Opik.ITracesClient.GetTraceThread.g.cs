#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get trace thread<br/>
        /// Get trace thread
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.TraceThread> GetTraceThreadAsync(

            global::Opik.TraceThreadIdentifier request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get trace thread<br/>
        /// Get trace thread
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="threadId"></param>
        /// <param name="truncate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.TraceThread> GetTraceThreadAsync(
            string threadId,
            string? projectName = default,
            global::System.Guid? projectId = default,
            bool? truncate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}