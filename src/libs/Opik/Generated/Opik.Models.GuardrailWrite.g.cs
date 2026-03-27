
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailWrite
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.GuardrailWriteNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.GuardrailWriteName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.GuardrailWriteResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.GuardrailWriteResult Result { get; set; }

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
        /// Initializes a new instance of the <see cref="GuardrailWrite" /> class.
        /// </summary>
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
        public GuardrailWrite(
            global::System.Guid entityId,
            global::System.Guid secondaryId,
            global::Opik.GuardrailWriteName name,
            global::Opik.GuardrailWriteResult result,
            object config,
            object details,
            string? projectName,
            global::System.Guid? projectId)
        {
            this.EntityId = entityId;
            this.SecondaryId = secondaryId;
            this.Name = name;
            this.Result = result;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.ProjectName = projectName;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailWrite" /> class.
        /// </summary>
        public GuardrailWrite()
        {
        }
    }
}