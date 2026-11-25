
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailModel
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique in the workspace, ignoring case; never changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What the model flags: the question its adapter is trained and served on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serving_run")]
        public global::Opik.GuardrailTrainingRun? ServingRun { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_run")]
        public global::Opik.GuardrailTrainingRun? LatestRun { get; set; }

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
        /// Initializes a new instance of the <see cref="GuardrailModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique in the workspace, ignoring case; never changes
        /// </param>
        /// <param name="description">
        /// What the model flags: the question its adapter is trained and served on
        /// </param>
        /// <param name="servingRun"></param>
        /// <param name="latestRun"></param>
        /// <param name="id">
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
        public GuardrailModel(
            string name,
            string description,
            global::Opik.GuardrailTrainingRun? servingRun,
            global::Opik.GuardrailTrainingRun? latestRun,
            global::System.Guid id = default!,
            global::System.DateTime createdAt = default!,
            string createdBy = default!,
            global::System.DateTime lastUpdatedAt = default!,
            string lastUpdatedBy = default!)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ServingRun = servingRun;
            this.LatestRun = latestRun;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModel" /> class.
        /// </summary>
        public GuardrailModel()
        {
        }

    }
}