
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceTogglesConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pythonEvaluatorEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PythonEvaluatorEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceThreadPythonEvaluatorEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TraceThreadPythonEvaluatorEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanLlmAsJudgeEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SpanLlmAsJudgeEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanUserDefinedMetricPythonEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SpanUserDefinedMetricPythonEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrailsEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GuardrailsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opikAIEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OpikAIEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertsEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AlertsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("welcomeWizardEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WelcomeWizardEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExportEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizationStudioEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OptimizationStudioEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetVersioningEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DatasetVersioningEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetExportEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DatasetExportEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demoDataEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DemoDataEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openaiProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OpenaiProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropicProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AnthropicProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geminiProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GeminiProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouterProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OpenrouterProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertexaiProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VertexaiProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bedrockProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BedrockProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customllmProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CustomllmProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ollamaProviderEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OllamaProviderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v2WorkspaceAllowlistIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> V2WorkspaceAllowlistIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v1WorkspaceAllowlistIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> V1WorkspaceAllowlistIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forceWorkspaceVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForceWorkspaceVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPageSize")]
        public int? DefaultPageSize { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v2WorkspaceAllowlist")]
        public string? V2WorkspaceAllowlist { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v1WorkspaceAllowlist")]
        public string? V1WorkspaceAllowlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceTogglesConfig" /> class.
        /// </summary>
        /// <param name="pythonEvaluatorEnabled"></param>
        /// <param name="traceThreadPythonEvaluatorEnabled"></param>
        /// <param name="spanLlmAsJudgeEnabled"></param>
        /// <param name="spanUserDefinedMetricPythonEnabled"></param>
        /// <param name="guardrailsEnabled"></param>
        /// <param name="opikAIEnabled"></param>
        /// <param name="alertsEnabled"></param>
        /// <param name="welcomeWizardEnabled"></param>
        /// <param name="exportEnabled"></param>
        /// <param name="optimizationStudioEnabled"></param>
        /// <param name="datasetVersioningEnabled"></param>
        /// <param name="datasetExportEnabled"></param>
        /// <param name="demoDataEnabled"></param>
        /// <param name="openaiProviderEnabled"></param>
        /// <param name="anthropicProviderEnabled"></param>
        /// <param name="geminiProviderEnabled"></param>
        /// <param name="openrouterProviderEnabled"></param>
        /// <param name="vertexaiProviderEnabled"></param>
        /// <param name="bedrockProviderEnabled"></param>
        /// <param name="customllmProviderEnabled"></param>
        /// <param name="ollamaProviderEnabled"></param>
        /// <param name="v2WorkspaceAllowlistIds"></param>
        /// <param name="v1WorkspaceAllowlistIds"></param>
        /// <param name="forceWorkspaceVersion"></param>
        /// <param name="defaultPageSize"></param>
        /// <param name="v2WorkspaceAllowlist">
        /// Included only in requests
        /// </param>
        /// <param name="v1WorkspaceAllowlist">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceTogglesConfig(
            bool pythonEvaluatorEnabled,
            bool traceThreadPythonEvaluatorEnabled,
            bool spanLlmAsJudgeEnabled,
            bool spanUserDefinedMetricPythonEnabled,
            bool guardrailsEnabled,
            bool opikAIEnabled,
            bool alertsEnabled,
            bool welcomeWizardEnabled,
            bool exportEnabled,
            bool optimizationStudioEnabled,
            bool datasetVersioningEnabled,
            bool datasetExportEnabled,
            bool demoDataEnabled,
            bool openaiProviderEnabled,
            bool anthropicProviderEnabled,
            bool geminiProviderEnabled,
            bool openrouterProviderEnabled,
            bool vertexaiProviderEnabled,
            bool bedrockProviderEnabled,
            bool customllmProviderEnabled,
            bool ollamaProviderEnabled,
            global::System.Collections.Generic.IList<string> v2WorkspaceAllowlistIds,
            global::System.Collections.Generic.IList<string> v1WorkspaceAllowlistIds,
            string forceWorkspaceVersion,
            int? defaultPageSize,
            string? v2WorkspaceAllowlist,
            string? v1WorkspaceAllowlist)
        {
            this.PythonEvaluatorEnabled = pythonEvaluatorEnabled;
            this.TraceThreadPythonEvaluatorEnabled = traceThreadPythonEvaluatorEnabled;
            this.SpanLlmAsJudgeEnabled = spanLlmAsJudgeEnabled;
            this.SpanUserDefinedMetricPythonEnabled = spanUserDefinedMetricPythonEnabled;
            this.GuardrailsEnabled = guardrailsEnabled;
            this.OpikAIEnabled = opikAIEnabled;
            this.AlertsEnabled = alertsEnabled;
            this.WelcomeWizardEnabled = welcomeWizardEnabled;
            this.ExportEnabled = exportEnabled;
            this.OptimizationStudioEnabled = optimizationStudioEnabled;
            this.DatasetVersioningEnabled = datasetVersioningEnabled;
            this.DatasetExportEnabled = datasetExportEnabled;
            this.DemoDataEnabled = demoDataEnabled;
            this.OpenaiProviderEnabled = openaiProviderEnabled;
            this.AnthropicProviderEnabled = anthropicProviderEnabled;
            this.GeminiProviderEnabled = geminiProviderEnabled;
            this.OpenrouterProviderEnabled = openrouterProviderEnabled;
            this.VertexaiProviderEnabled = vertexaiProviderEnabled;
            this.BedrockProviderEnabled = bedrockProviderEnabled;
            this.CustomllmProviderEnabled = customllmProviderEnabled;
            this.OllamaProviderEnabled = ollamaProviderEnabled;
            this.V2WorkspaceAllowlistIds = v2WorkspaceAllowlistIds ?? throw new global::System.ArgumentNullException(nameof(v2WorkspaceAllowlistIds));
            this.V1WorkspaceAllowlistIds = v1WorkspaceAllowlistIds ?? throw new global::System.ArgumentNullException(nameof(v1WorkspaceAllowlistIds));
            this.ForceWorkspaceVersion = forceWorkspaceVersion ?? throw new global::System.ArgumentNullException(nameof(forceWorkspaceVersion));
            this.DefaultPageSize = defaultPageSize;
            this.V2WorkspaceAllowlist = v2WorkspaceAllowlist;
            this.V1WorkspaceAllowlist = v1WorkspaceAllowlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceTogglesConfig" /> class.
        /// </summary>
        public ServiceTogglesConfig()
        {
        }

    }
}