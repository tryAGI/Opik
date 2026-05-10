
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.LocalRunnerStatusJsonConverter))]
        public global::Opik.LocalRunnerStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_at")]
        public global::System.DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::Opik.Agent>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::System.Collections.Generic.IList<string>? Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checklist")]
        public global::Opik.JsonNode? Checklist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.LocalRunnerTypeJsonConverter))]
        public global::Opik.LocalRunnerType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunner" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="status"></param>
        /// <param name="connectedAt"></param>
        /// <param name="agents"></param>
        /// <param name="capabilities"></param>
        /// <param name="checklist"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunner(
            global::System.Guid? id,
            string? name,
            global::System.Guid? projectId,
            global::Opik.LocalRunnerStatus? status,
            global::System.DateTime? connectedAt,
            global::System.Collections.Generic.IList<global::Opik.Agent>? agents,
            global::System.Collections.Generic.IList<string>? capabilities,
            global::Opik.JsonNode? checklist,
            global::Opik.LocalRunnerType? type)
        {
            this.Id = id;
            this.Name = name;
            this.ProjectId = projectId;
            this.Status = status;
            this.ConnectedAt = connectedAt;
            this.Agents = agents;
            this.Capabilities = capabilities;
            this.Checklist = checklist;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunner" /> class.
        /// </summary>
        public LocalRunner()
        {
        }

    }
}