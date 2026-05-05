#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Create trace<br/>
        /// Get trace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateTraceAsync(

            global::Opik.TraceWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create trace<br/>
        /// Get trace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CreateTraceAsResponseAsync(

            global::Opik.TraceWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create trace<br/>
        /// Get trace
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="errorInfo"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="ttft">
        /// Time to first token in milliseconds
        /// </param>
        /// <param name="threadId"></param>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateTraceAsync(
            global::System.DateTime startTime,
            global::System.Guid? id = default,
            string? projectName = default,
            string? name = default,
            global::System.DateTime? endTime = default,
            global::Opik.JsonListStringWrite? input = default,
            global::Opik.JsonListStringWrite? output = default,
            global::Opik.JsonListStringWrite? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Opik.ErrorInfoWrite? errorInfo = default,
            global::System.DateTime? lastUpdatedAt = default,
            double? ttft = default,
            string? threadId = default,
            global::Opik.TraceWriteSource? source = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}