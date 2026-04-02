#nullable enable

namespace Opik
{
    public partial interface IInsightsViewsClient
    {
        /// <summary>
        /// Create insights view<br/>
        /// Create a new insights view in a workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> CreateInsightsViewAsync(

            global::Opik.DashboardWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create insights view<br/>
        /// Create a new insights view in a workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.DashboardPublic>> CreateInsightsViewAsResponseAsync(

            global::Opik.DashboardWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create insights view<br/>
        /// Create a new insights view in a workspace
        /// </summary>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the dashboard is created at workspace level.
        /// </param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> CreateInsightsViewAsync(
            string name,
            global::Opik.JsonNodeWrite config,
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::Opik.DashboardWriteType? type = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}