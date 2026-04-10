#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Update span by id<br/>
        /// Update span by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateSpanAsync(
            global::System.Guid id,

            global::Opik.SpanUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update span by id<br/>
        /// Update span by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// If null and project_id not specified, Default Project is assumed
        /// </param>
        /// <param name="projectId">
        /// If null and project_name not specified, Default Project is assumed
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="tags">
        /// Tags
        /// </param>
        /// <param name="tagsToAdd">
        /// Tags to add
        /// </param>
        /// <param name="tagsToRemove">
        /// Tags to remove
        /// </param>
        /// <param name="usage"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="errorInfo"></param>
        /// <param name="ttft"></param>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateSpanAsync(
            global::System.Guid id,
            global::System.Guid traceId,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Guid? parentSpanId = default,
            string? name = default,
            global::Opik.SpanUpdateType? type = default,
            global::System.DateTime? endTime = default,
            global::Opik.JsonListString? input = default,
            global::Opik.JsonListString? output = default,
            global::Opik.JsonListString? metadata = default,
            string? model = default,
            string? provider = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? tagsToAdd = default,
            global::System.Collections.Generic.IList<string>? tagsToRemove = default,
            global::System.Collections.Generic.Dictionary<string, int>? usage = default,
            double? totalEstimatedCost = default,
            global::Opik.ErrorInfo? errorInfo = default,
            double? ttft = default,
            global::Opik.SpanUpdateSource? source = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}