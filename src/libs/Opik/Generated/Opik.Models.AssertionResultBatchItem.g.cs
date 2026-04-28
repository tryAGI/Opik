
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssertionResultBatchItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EntityId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AssertionResultBatchItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AssertionResultBatchItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AssertionResultBatchItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AssertionResultBatchItemSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionResultBatchItem" /> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="source"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssertionResultBatchItem(
            global::System.Guid entityId,
            string name,
            global::Opik.AssertionResultBatchItemStatus status,
            global::Opik.AssertionResultBatchItemSource source,
            string? projectName,
            global::System.Guid? projectId,
            string? reason)
        {
            this.EntityId = entityId;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Reason = reason;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionResultBatchItem" /> class.
        /// </summary>
        public AssertionResultBatchItem()
        {
        }
    }
}