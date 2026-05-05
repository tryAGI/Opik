
#nullable enable

namespace Opik
{
    public partial class RunnersClient
    {

        private static readonly global::Opik.AutoSDKServer[] s_ReportBridgeResultServers = new global::Opik.AutoSDKServer[]
        {            new global::Opik.AutoSDKServer(
                id: "http-localhost-api",
                name: "Local server",
                url: "http://localhost:5173/api",
                description: "Local server"),
            new global::Opik.AutoSDKServer(
                id: "https-www-comet-com-opik-api",
                name: "Opik Cloud",
                url: "https://www.comet.com/opik/api",
                description: "Opik Cloud"),
        };


        private static readonly global::Opik.EndPointSecurityRequirement s_ReportBridgeResultSecurityRequirement0 =
            new global::Opik.EndPointSecurityRequirement
            {
                Authorizations = new global::Opik.EndPointAuthorizationRequirement[]
                {                    new global::Opik.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Opik.EndPointSecurityRequirement[] s_ReportBridgeResultSecurityRequirements =
            new global::Opik.EndPointSecurityRequirement[]
            {                s_ReportBridgeResultSecurityRequirement0,
            };
        partial void PrepareReportBridgeResultArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid runnerId,
            ref global::System.Guid commandId,
            global::Opik.BridgeCommandResultRequest request);
        partial void PrepareReportBridgeResultRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid runnerId,
            global::System.Guid commandId,
            global::Opik.BridgeCommandResultRequest request);
        partial void ProcessReportBridgeResultResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Report bridge command result<br/>
        /// Report bridge command completion or failure
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ReportBridgeResultAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,

            global::Opik.BridgeCommandResultRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await ReportBridgeResultAsResponseAsync(
                runnerId: runnerId,
                commandId: commandId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Report bridge command result<br/>
        /// Report bridge command completion or failure
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> ReportBridgeResultAsResponseAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,

            global::Opik.BridgeCommandResultRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReportBridgeResultArguments(
                httpClient: HttpClient,
                runnerId: ref runnerId,
                commandId: ref commandId,
                request: request);


            var __authorizations = global::Opik.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ReportBridgeResultSecurityRequirements,
                operationName: "ReportBridgeResultAsync");

            using var __timeoutCancellationTokenSource = global::Opik.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Opik.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Opik.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Opik.PathBuilder(
                                path: $"/v1/private/local-runners/{runnerId}/bridge/commands/{commandId}/results",
                                baseUri: ResolveBaseUri(
                                servers: s_ReportBridgeResultServers,
                                defaultBaseUrl: "http://localhost:5173/api"));
                            var __path = __pathBuilder.ToString();
                __path = global::Opik.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Opik.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareReportBridgeResultRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    runnerId: runnerId!,
                    commandId: commandId!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Opik.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReportBridgeResult",
                                methodName: "ReportBridgeResultAsync",
                                pathTemplate: "$\"/v1/private/local-runners/{runnerId}/bridge/commands/{commandId}/results\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Opik.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Opik.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReportBridgeResult",
                                methodName: "ReportBridgeResultAsync",
                                pathTemplate: "$\"/v1/private/local-runners/{runnerId}/bridge/commands/{commandId}/results\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Opik.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Opik.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Opik.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Opik.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReportBridgeResult",
                                methodName: "ReportBridgeResultAsync",
                                pathTemplate: "$\"/v1/private/local-runners/{runnerId}/bridge/commands/{commandId}/results\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Opik.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessReportBridgeResultResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Opik.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReportBridgeResult",
                                methodName: "ReportBridgeResultAsync",
                                pathTemplate: "$\"/v1/private/local-runners/{runnerId}/bridge/commands/{commandId}/results\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Opik.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReportBridgeResult",
                                methodName: "ReportBridgeResultAsync",
                                pathTemplate: "$\"/v1/private/local-runners/{runnerId}/bridge/commands/{commandId}/results\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Command not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Opik.ErrorMessage? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Opik.ErrorMessage.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Opik.ErrorMessage.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }

                                throw new global::Opik.ApiException<global::Opik.ErrorMessage>(
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_404,
                                    ResponseObject = __value_404,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Already completed
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::Opik.ErrorMessage? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = global::Opik.ErrorMessage.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = global::Opik.ErrorMessage.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }

                                throw new global::Opik.ApiException<global::Opik.ErrorMessage>(
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_409,
                                    ResponseObject = __value_409,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::Opik.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Opik.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
                                    return new global::Opik.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Opik.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Report bridge command result<br/>
        /// Report bridge command completion or failure
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="durationMs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReportBridgeResultAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,
            global::Opik.BridgeCommandResultRequestStatus status,
            global::Opik.JsonNode? result = default,
            global::Opik.JsonNode? error = default,
            long? durationMs = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Opik.BridgeCommandResultRequest
            {
                Status = status,
                Result = result,
                Error = error,
                DurationMs = durationMs,
            };

            await ReportBridgeResultAsync(
                runnerId: runnerId,
                commandId: commandId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}