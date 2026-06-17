
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportedIssue
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        public string? Cause { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggested_fix")]
        public string? SuggestedFix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces_query")]
        public string? TracesQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_impacted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UsersImpacted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Opik.JsonNode? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportedIssue" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        /// <param name="totalCount"></param>
        /// <param name="usersImpacted"></param>
        /// <param name="totalUsers"></param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="cause"></param>
        /// <param name="suggestedFix"></param>
        /// <param name="tracesQuery"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportedIssue(
            string name,
            long count,
            long totalCount,
            long usersImpacted,
            long totalUsers,
            global::System.Guid? id,
            string? description,
            string? cause,
            string? suggestedFix,
            string? tracesQuery,
            global::Opik.JsonNode? metadata)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Cause = cause;
            this.SuggestedFix = suggestedFix;
            this.TracesQuery = tracesQuery;
            this.Count = count;
            this.TotalCount = totalCount;
            this.UsersImpacted = usersImpacted;
            this.TotalUsers = totalUsers;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportedIssue" /> class.
        /// </summary>
        public ReportedIssue()
        {
        }

    }
}