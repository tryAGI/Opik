
#nullable enable

namespace Opik
{
    public partial class DatasetsClient
    {


        private static readonly global::Opik.EndPointSecurityRequirement s_FindDatasetsSecurityRequirement0 =
            new global::Opik.EndPointSecurityRequirement
            {
                Authorizations = new global::Opik.EndPointAuthorizationRequirement[]
                {                    new global::Opik.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Opik.EndPointSecurityRequirement[] s_FindDatasetsSecurityRequirements =
            new global::Opik.EndPointSecurityRequirement[]
            {                s_FindDatasetsSecurityRequirement0,
            };
        partial void PrepareFindDatasetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? size,
            ref bool? withExperimentsOnly,
            ref bool? withOptimizationsOnly,
            ref global::System.Guid? promptId,
            ref global::System.Guid? projectId,
            ref string? name,
            ref string? sorting,
            ref string? filters);
        partial void PrepareFindDatasetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? size,
            bool? withExperimentsOnly,
            bool? withOptimizationsOnly,
            global::System.Guid? promptId,
            global::System.Guid? projectId,
            string? name,
            string? sorting,
            string? filters);
        partial void ProcessFindDatasetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFindDatasetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Find datasets<br/>
        /// Find datasets
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="withExperimentsOnly"></param>
        /// <param name="withOptimizationsOnly"></param>
        /// <param name="promptId"></param>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Filter datasets by name (partial match, case insensitive)
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Opik.DatasetPagePublic> FindDatasetsAsync(
            int? page = default,
            int? size = default,
            bool? withExperimentsOnly = default,
            bool? withOptimizationsOnly = default,
            global::System.Guid? promptId = default,
            global::System.Guid? projectId = default,
            string? name = default,
            string? sorting = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFindDatasetsArguments(
                httpClient: HttpClient,
                page: ref page,
                size: ref size,
                withExperimentsOnly: ref withExperimentsOnly,
                withOptimizationsOnly: ref withOptimizationsOnly,
                promptId: ref promptId,
                projectId: ref projectId,
                name: ref name,
                sorting: ref sorting,
                filters: ref filters);


            var __authorizations = global::Opik.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_FindDatasetsSecurityRequirements,
                operationName: "FindDatasetsAsync");

            var __pathBuilder = new global::Opik.PathBuilder(
                path: "/v1/private/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("size", size?.ToString())
                .AddOptionalParameter("with_experiments_only", withExperimentsOnly?.ToString().ToLowerInvariant())
                .AddOptionalParameter("with_optimizations_only", withOptimizationsOnly?.ToString().ToLowerInvariant())
                .AddOptionalParameter("prompt_id", promptId?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("sorting", sorting)
                .AddOptionalParameter("filters", filters) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFindDatasetsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                size: size,
                withExperimentsOnly: withExperimentsOnly,
                withOptimizationsOnly: withOptimizationsOnly,
                promptId: promptId,
                projectId: projectId,
                name: name,
                sorting: sorting,
                filters: filters);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFindDatasetsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessFindDatasetsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Opik.DatasetPagePublic.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Opik.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Opik.DatasetPagePublic.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Opik.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}