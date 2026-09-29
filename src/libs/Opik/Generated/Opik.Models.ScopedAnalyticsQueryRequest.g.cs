
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScopedAnalyticsQueryRequest
    {
        /// <summary>
        /// Read-only ClickHouse SQL. Must return exactly one column named `result` produced via toJSONString(...)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Restrict query to this project. Omit to query the whole workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedAnalyticsQueryRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Read-only ClickHouse SQL. Must return exactly one column named `result` produced via toJSONString(...)
        /// </param>
        /// <param name="projectId">
        /// Restrict query to this project. Omit to query the whole workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScopedAnalyticsQueryRequest(
            string query,
            global::System.Guid? projectId)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedAnalyticsQueryRequest" /> class.
        /// </summary>
        public ScopedAnalyticsQueryRequest()
        {
        }

    }
}