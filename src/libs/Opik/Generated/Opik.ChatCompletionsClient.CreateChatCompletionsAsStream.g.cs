
#nullable enable

namespace Opik
{
    public partial class ChatCompletionsClient
    {


        private static readonly global::Opik.EndPointSecurityRequirement s_CreateChatCompletionsAsStreamSecurityRequirement0 =
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
        private static readonly global::Opik.EndPointSecurityRequirement[] s_CreateChatCompletionsAsStreamSecurityRequirements =
            new global::Opik.EndPointSecurityRequirement[]
            {                s_CreateChatCompletionsAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateChatCompletionsAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Opik.ChatCompletionRequest request);
        partial void PrepareCreateChatCompletionsAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Opik.ChatCompletionRequest request);
        partial void ProcessCreateChatCompletionsAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create chat completions<br/>
        /// Create chat completions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>> CreateChatCompletionsAsStreamAsync(

            global::Opik.ChatCompletionRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Opik.ChatCompletionRequest
            {
                Model = request.Model,
                Messages = request.Messages,
                Temperature = request.Temperature,
                TopP = request.TopP,
                N = request.N,
                Stream = true,
                StreamOptions = request.StreamOptions,
                Stop = request.Stop,
                MaxTokens = request.MaxTokens,
                MaxCompletionTokens = request.MaxCompletionTokens,
                PresencePenalty = request.PresencePenalty,
                FrequencyPenalty = request.FrequencyPenalty,
                LogitBias = request.LogitBias,
                User = request.User,
                ResponseFormat = request.ResponseFormat,
                Seed = request.Seed,
                Tools = request.Tools,
                ToolChoice = request.ToolChoice,
                ParallelToolCalls = request.ParallelToolCalls,
                Store = request.Store,
                Metadata = request.Metadata,
                ReasoningEffort = request.ReasoningEffort,
                ServiceTier = request.ServiceTier,
                Functions = request.Functions,
                FunctionCall = request.FunctionCall,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionsAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Opik.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateChatCompletionsAsStreamSecurityRequirements,
                operationName: "CreateChatCompletionsAsStreamAsync");

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
                                path: "/v1/private/chat/completions",
                                baseUri: HttpClient.BaseAddress);
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
                PrepareCreateChatCompletionsAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "CreateChatCompletionsAsStream",
                                methodName: "CreateChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/v1/private/chat/completions\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Opik.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletionsAsStream",
                                methodName: "CreateChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/v1/private/chat/completions\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Opik.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Opik.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Opik.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletionsAsStream",
                                methodName: "CreateChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/v1/private/chat/completions\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Opik.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessCreateChatCompletionsAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Opik.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletionsAsStream",
                                methodName: "CreateChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/v1/private/chat/completions\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Opik.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Opik.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletionsAsStream",
                                methodName: "CreateChatCompletionsAsStreamAsync",
                                pathTemplate: "\"/v1/private/chat/completions\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>.FromJson(__content, JsonSerializerContext) ??
                                                       throw new global::Opik.ApiException(
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           statusCode: __response.StatusCode)
                                                       {
                                                           ResponseBody = __content,
                                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value),
                                                       };

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create chat completions<br/>
        /// Create chat completions
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="streamOptions"></param>
        /// <param name="stop"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="user"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="store"></param>
        /// <param name="metadata"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="serviceTier"></param>
        /// <param name="functions"></param>
        /// <param name="functionCall"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>> CreateChatCompletionsAsStreamAsync(
            string? model = default,
            global::System.Collections.Generic.IList<global::Opik.Message>? messages = default,
            double? temperature = default,
            double? topP = default,
            int? n = default,
            global::Opik.StreamOptions? streamOptions = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            int? maxTokens = default,
            int? maxCompletionTokens = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
            string? user = default,
            global::Opik.ResponseFormat? responseFormat = default,
            int? seed = default,
            global::System.Collections.Generic.IList<global::Opik.Tool>? tools = default,
            object? toolChoice = default,
            bool? parallelToolCalls = default,
            bool? store = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? reasoningEffort = default,
            string? serviceTier = default,
            global::System.Collections.Generic.IList<global::Opik.Function>? functions = default,
            global::Opik.FunctionCall? functionCall = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Opik.ChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Temperature = temperature,
                TopP = topP,
                N = n,
                Stream = true,
                StreamOptions = streamOptions,
                Stop = stop,
                MaxTokens = maxTokens,
                MaxCompletionTokens = maxCompletionTokens,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                User = user,
                ResponseFormat = responseFormat,
                Seed = seed,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                Store = store,
                Metadata = metadata,
                ReasoningEffort = reasoningEffort,
                ServiceTier = serviceTier,
                Functions = functions,
                FunctionCall = functionCall,
            };

            var __enumerable = CreateChatCompletionsAsStreamAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}