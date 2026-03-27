#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Append local runner job logs<br/>
        /// Append log entries for a running local runner job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task AppendJobLogsAsync(
            global::System.Guid jobId,

            global::System.Collections.Generic.IList<global::Opik.LocalRunnerLogEntry> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}