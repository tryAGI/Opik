#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create prompt<br/>
        /// Create prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePromptAsync(

            global::Opik.PromptWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create prompt<br/>
        /// Create prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the prompt is created at workspace level.
        /// </param>
        /// <param name="description"></param>
        /// <param name="template"></param>
        /// <param name="metadata"></param>
        /// <param name="changeDescription"></param>
        /// <param name="type"></param>
        /// <param name="templateStructure">
        /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreatePromptAsync(
            string name,
            global::System.Guid? id = default,
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? description = default,
            string? template = default,
            global::Opik.JsonNodeWrite? metadata = default,
            string? changeDescription = default,
            global::Opik.PromptWriteType? type = default,
            global::Opik.PromptWriteTemplateStructure? templateStructure = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}