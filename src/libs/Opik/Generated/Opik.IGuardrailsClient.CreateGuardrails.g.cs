#nullable enable

namespace Opik
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Create guardrails for traces in a batch<br/>
        /// Batch guardrails for traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateGuardrailsAsync(

            global::Opik.GuardrailBatchWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create guardrails for traces in a batch<br/>
        /// Batch guardrails for traces
        /// </summary>
        /// <param name="guardrails"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateGuardrailsAsync(
            global::System.Collections.Generic.IList<global::Opik.GuardrailWrite> guardrails,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}