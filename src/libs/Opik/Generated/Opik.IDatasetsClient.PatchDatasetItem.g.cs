#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Partially update dataset item by id<br/>
        /// Partially update dataset item by id. Only provided fields will be updated.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task PatchDatasetItemAsync(
            global::System.Guid itemId,

            global::Opik.DatasetItemWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update dataset item by id<br/>
        /// Partially update dataset item by id. Only provided fields will be updated.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="id">
        /// Stable item identifier.<br/>
        /// On write, used as the upsert key.<br/>
        /// If omitted, a new ID is generated.<br/>
        /// Remains the same across dataset versions
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="source"></param>
        /// <param name="data"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="evaluators"></param>
        /// <param name="executionPolicy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PatchDatasetItemAsync(
            global::System.Guid itemId,
            global::Opik.DatasetItemWriteSource source,
            object data,
            global::System.Guid? id = default,
            global::System.Guid? traceId = default,
            global::System.Guid? spanId = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::Opik.EvaluatorItemWrite>? evaluators = default,
            global::Opik.ExecutionPolicyWrite? executionPolicy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}