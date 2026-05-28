
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationStudioConfigPublic
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
        public required global::Opik.StudioPromptPublic Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.StudioLlmModelPublic LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.StudioEvaluationPublic Evaluation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.StudioOptimizerPublic Optimizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioConfigPublic" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="prompt"></param>
        /// <param name="llmModel"></param>
        /// <param name="evaluation"></param>
        /// <param name="optimizer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizationStudioConfigPublic(
            string datasetName,
            global::Opik.StudioPromptPublic prompt,
            global::Opik.StudioLlmModelPublic llmModel,
            global::Opik.StudioEvaluationPublic evaluation,
            global::Opik.StudioOptimizerPublic optimizer)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.LlmModel = llmModel ?? throw new global::System.ArgumentNullException(nameof(llmModel));
            this.Evaluation = evaluation ?? throw new global::System.ArgumentNullException(nameof(evaluation));
            this.Optimizer = optimizer ?? throw new global::System.ArgumentNullException(nameof(optimizer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioConfigPublic" /> class.
        /// </summary>
        public OptimizationStudioConfigPublic()
        {
        }

    }
}