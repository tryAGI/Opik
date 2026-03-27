#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Apply changes to dataset items<br/>
        /// Apply delta changes (add, edit, delete) to a dataset version with conflict detection.<br/>
        /// This endpoint:<br/>
        /// - Creates a new version with the applied changes<br/>
        /// - Validates that baseVersion matches the latest version (unless override=true)<br/>
        /// - Returns 409 Conflict if baseVersion is stale and override is not set<br/>
        /// Use `override=true` query parameter to force version creation even with stale baseVersion.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="override">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetVersionPublic> ApplyDatasetItemChangesAsync(
            global::System.Guid id,

            object request,
            bool? @override = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply changes to dataset items<br/>
        /// Apply delta changes (add, edit, delete) to a dataset version with conflict detection.<br/>
        /// This endpoint:<br/>
        /// - Creates a new version with the applied changes<br/>
        /// - Validates that baseVersion matches the latest version (unless override=true)<br/>
        /// - Returns 409 Conflict if baseVersion is stale and override is not set<br/>
        /// Use `override=true` query parameter to force version creation even with stale baseVersion.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="override">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetVersionPublic> ApplyDatasetItemChangesAsync(
            global::System.Guid id,
            bool? @override = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}