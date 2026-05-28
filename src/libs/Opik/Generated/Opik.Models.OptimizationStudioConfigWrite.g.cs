
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationStudioConfigWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.StudioPromptWrite Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.StudioLlmModelWrite LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.StudioEvaluationWrite Evaluation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.StudioOptimizerWrite Optimizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioConfigWrite" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="prompt"></param>
        /// <param name="llmModel"></param>
        /// <param name="evaluation"></param>
        /// <param name="optimizer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizationStudioConfigWrite(
            string datasetName,
            global::Opik.StudioPromptWrite prompt,
            global::Opik.StudioLlmModelWrite llmModel,
            global::Opik.StudioEvaluationWrite evaluation,
            global::Opik.StudioOptimizerWrite optimizer)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.LlmModel = llmModel ?? throw new global::System.ArgumentNullException(nameof(llmModel));
            this.Evaluation = evaluation ?? throw new global::System.ArgumentNullException(nameof(evaluation));
            this.Optimizer = optimizer ?? throw new global::System.ArgumentNullException(nameof(optimizer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioConfigWrite" /> class.
        /// </summary>
        public OptimizationStudioConfigWrite()
        {
        }

    }
}