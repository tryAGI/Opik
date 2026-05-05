#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Expand dataset with synthetic samples<br/>
        /// Generate synthetic dataset samples using LLM based on existing data patterns
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetExpansionResponse> ExpandDatasetAsync(
            global::System.Guid id,

            global::Opik.DatasetExpansionWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Expand dataset with synthetic samples<br/>
        /// Generate synthetic dataset samples using LLM based on existing data patterns
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.DatasetExpansionResponse>> ExpandDatasetAsResponseAsync(
            global::System.Guid id,

            global::Opik.DatasetExpansionWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Expand dataset with synthetic samples<br/>
        /// Generate synthetic dataset samples using LLM based on existing data patterns
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model">
        /// The model to use for synthetic data generation<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="sampleCount">
        /// Number of synthetic samples to generate<br/>
        /// Example: 10
        /// </param>
        /// <param name="preserveFields">
        /// Fields to preserve patterns from original data<br/>
        /// Example: [input, expected_output]
        /// </param>
        /// <param name="variationInstructions">
        /// Additional instructions for data variation<br/>
        /// Example: Create variations that test edge cases
        /// </param>
        /// <param name="customPrompt">
        /// Custom prompt to use for generation instead of auto-generated one
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of tokens for the LLM response. Required by Anthropic, used as maxOutputTokens for Gemini. If not provided, defaults to 4000 for Anthropic models only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetExpansionResponse> ExpandDatasetAsync(
            global::System.Guid id,
            string model,
            int? sampleCount = default,
            global::System.Collections.Generic.IList<string>? preserveFields = default,
            string? variationInstructions = default,
            string? customPrompt = default,
            int? maxCompletionTokens = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}