
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendUserRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_uuid")]
        public string? UserUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_display_name")]
        public string? UserDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public long? Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public long? Skills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcps")]
        public long? Mcps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_calls")]
        public long? McpCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<string>? Repositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public global::System.Collections.Generic.IList<string>? Flags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendUserRow" /> class.
        /// </summary>
        /// <param name="userUuid"></param>
        /// <param name="userEmail"></param>
        /// <param name="userDisplayName"></param>
        /// <param name="model"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="requests"></param>
        /// <param name="skills"></param>
        /// <param name="mcps"></param>
        /// <param name="mcpCalls"></param>
        /// <param name="repositories"></param>
        /// <param name="flags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendUserRow(
            string? userUuid,
            string? userEmail,
            string? userDisplayName,
            string? model,
            double? totalEstimatedCost,
            long? requests,
            long? skills,
            long? mcps,
            long? mcpCalls,
            global::System.Collections.Generic.IList<string>? repositories,
            global::System.Collections.Generic.IList<string>? flags)
        {
            this.UserUuid = userUuid;
            this.UserEmail = userEmail;
            this.UserDisplayName = userDisplayName;
            this.Model = model;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.Requests = requests;
            this.Skills = skills;
            this.Mcps = mcps;
            this.McpCalls = mcpCalls;
            this.Repositories = repositories;
            this.Flags = flags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendUserRow" /> class.
        /// </summary>
        public SpendUserRow()
        {
        }

    }
}