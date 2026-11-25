
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailTrainingRun
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public global::System.Guid ModelId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.GuardrailTrainingRunStatusJsonConverter))]
        public global::Opik.GuardrailTrainingRunStatus Status { get; set; } = default!;

        /// <summary>
        /// Why the run ended failed or cancelled; null otherwise<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Which attempt of one training the run is, 1 for the first<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        public int Attempt { get; set; } = default!;

        /// <summary>
        /// When the run reached completed, failed or cancelled; null while it is in flight<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime LastUpdatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string LastUpdatedBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailTrainingRun" /> class.
        /// </summary>
        /// <param name="statusMessage">
        /// Why the run ended failed or cancelled; null otherwise<br/>
        /// Included only in responses
        /// </param>
        /// <param name="finishedAt">
        /// When the run reached completed, failed or cancelled; null while it is in flight<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="modelId">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="attempt">
        /// Which attempt of one training the run is, 1 for the first<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailTrainingRun(
            string? statusMessage,
            global::System.DateTime? finishedAt,
            global::System.Guid id = default!,
            global::System.Guid modelId = default!,
            global::Opik.GuardrailTrainingRunStatus status = default!,
            int attempt = default!,
            global::System.DateTime createdAt = default!,
            string createdBy = default!,
            global::System.DateTime lastUpdatedAt = default!,
            string lastUpdatedBy = default!)
        {
            this.Id = id;
            this.ModelId = modelId;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Attempt = attempt;
            this.FinishedAt = finishedAt;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailTrainingRun" /> class.
        /// </summary>
        public GuardrailTrainingRun()
        {
        }

    }
}