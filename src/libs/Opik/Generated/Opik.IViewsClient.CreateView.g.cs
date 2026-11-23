#nullable enable

namespace Opik
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Create view<br/>
        /// Create a view with its first version
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.View> CreateViewAsync(

            global::Opik.ViewCreate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create view<br/>
        /// Create a view with its first version
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.View>> CreateViewAsResponseAsync(

            global::Opik.ViewCreate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create view<br/>
        /// Create a view with its first version
        /// </summary>
        /// <param name="area">
        /// The content area the view is written for; fixed after creation
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="summary">
        /// What the first version shows, one line
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
        global::System.Threading.Tasks.Task<global::Opik.View> CreateViewAsync(
            string name,
            int engineVersion,
            global::System.Collections.Generic.Dictionary<string, global::Opik.ViewInput> inputs,
            string html,
            global::Opik.ViewCreateArea area = default,
            string? description = default,
            string? summary = default,
            global::Opik.ViewCreateAuthor? author = default,
            global::Opik.ViewCreateType type = default,
            global::System.Collections.Generic.IList<string>? libraries = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}