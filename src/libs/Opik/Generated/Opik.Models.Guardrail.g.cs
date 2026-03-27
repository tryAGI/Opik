
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Guardrail
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SecondaryId { get; set; }

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.GuardrailNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.GuardrailName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.GuardrailResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.GuardrailResult Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Guardrail" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="entityId"></param>
        /// <param name="secondaryId"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="result"></param>
        /// <param name="config"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Guardrail(
            global::System.Guid entityId,
            global::System.Guid secondaryId,
            global::Opik.GuardrailName name,
            global::Opik.GuardrailResult result,
            object config,
            object details,
            global::System.Guid? id,
            string? projectName,
            global::System.Guid? projectId)
        {
            this.EntityId = entityId;
            this.SecondaryId = secondaryId;
            this.Name = name;
            this.Result = result;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.Id = id;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guardrail" /> class.
        /// </summary>
        public Guardrail()
        {
        }
    }
}