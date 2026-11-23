#nullable enable

namespace Opik
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Create view version<br/>
        /// Add a version to a view and make it current
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ViewVersion> CreateViewVersionAsync(
            global::System.Guid id,

            global::Opik.ViewVersionCreate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create view version<br/>
        /// Add a version to a view and make it current
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ViewVersion>> CreateViewVersionAsResponseAsync(
            global::System.Guid id,

            global::Opik.ViewVersionCreate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create view version<br/>
        /// Add a version to a view and make it current
        /// </summary>
        /// <param name="id"></param>
        /// <param name="summary">
        /// What changed, one line
        /// </param>
        /// <param name="author">
        /// Who produced the version: user (default), ollie or agent. Informational only
        /// </param>
        /// <param name="type">
        /// View type
        /// </param>
        /// <param name="engineVersion">
        /// HTML contract version the view was written against
        /// </param>
        /// <param name="libraries">
        /// Libraries the host loads before the view runs; none when omitted
        /// </param>
        /// <param name="inputs">
        /// Input name to data source, one or several; the view receives one data object with a key per input
        /// </param>
        /// <param name="html">
        /// The view: HTML, CSS and script rendered in a sandboxed iframe
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ViewVersion> CreateViewVersionAsync(
            global::System.Guid id,
            int engineVersion,
            global::System.Collections.Generic.Dictionary<string, global::Opik.ViewInput> inputs,
            string html,
            string? summary = default,
            global::Opik.ViewVersionCreateAuthor? author = default,
            global::Opik.ViewVersionCreateType type = default,
            global::System.Collections.Generic.IList<string>? libraries = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}