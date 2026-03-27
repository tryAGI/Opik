#nullable enable

namespace Opik
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Delete experiment items<br/>
        /// Delete experiment items
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteExperimentItemsAsync(

            global::Opik.ExperimentItemsDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete experiment items<br/>
        /// Delete experiment items
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteExperimentItemsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}