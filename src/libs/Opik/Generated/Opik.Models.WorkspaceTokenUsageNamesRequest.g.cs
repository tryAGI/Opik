
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceTokenUsageNamesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceTokenUsageNamesRequest" /> class.
        /// </summary>
        /// <param name="projectIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceTokenUsageNamesRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds)
        {
            this.ProjectIds = projectIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceTokenUsageNamesRequest" /> class.
        /// </summary>
        public WorkspaceTokenUsageNamesRequest()
        {
        }

    }
}