#nullable enable

namespace Opik
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Get experiment item by id<br/>
        /// Get experiment item by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ExperimentItemPublic> GetExperimentItemByIdAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}