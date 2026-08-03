
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchDeleteByProject
    {
        /// <summary>
        /// Ids of the traces to delete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Ids { get; set; }

        /// <summary>
        /// Optional. Scopes the deletion to this project. When omitted, each trace's owning project is resolved automatically and the trace is deleted under its full key, so a trace can be deleted without knowing its project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteByProject" /> class.
        /// </summary>
        /// <param name="ids">
        /// Ids of the traces to delete
        /// </param>
        /// <param name="projectId">
        /// Optional. Scopes the deletion to this project. When omitted, each trace's owning project is resolved automatically and the trace is deleted under its full key, so a trace can be deleted without knowing its project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeleteByProject(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Guid? projectId)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteByProject" /> class.
        /// </summary>
        public BatchDeleteByProject()
        {
        }

    }
}