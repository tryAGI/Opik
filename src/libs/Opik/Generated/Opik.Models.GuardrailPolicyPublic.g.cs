
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailPolicyPublic
    {
        /// <summary>
        /// Optional on create, generated when missing, as for prompts and datasets. Ignored on update, where the path names the policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The SDK names policies by name, so it is unique in the workspace, ignoring case
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
        /// on_request applies the policy when the SDK names it, global applies it to every guardrail built from stored policies in the workspace. Missing or null means on_request<br/>
        /// Default Value: on_request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.GuardrailPolicyPublicExecutionScopeJsonConverter))]
        public global::Opik.GuardrailPolicyPublicExecutionScope? ExecutionScope { get; set; }

        /// <summary>
        /// At most one rule per type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRulePublic> Rules { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPolicyPublic" /> class.
        /// </summary>
        /// <param name="name">
        /// The SDK names policies by name, so it is unique in the workspace, ignoring case
        /// </param>
        /// <param name="rules">
        /// At most one rule per type
        /// </param>
        /// <param name="id">
        /// Optional on create, generated when missing, as for prompts and datasets. Ignored on update, where the path names the policy
        /// </param>
        /// <param name="description"></param>
        /// <param name="executionScope">
        /// on_request applies the policy when the SDK names it, global applies it to every guardrail built from stored policies in the workspace. Missing or null means on_request<br/>
        /// Default Value: on_request
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
        public GuardrailPolicyPublic(
            string name,
            global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRulePublic> rules,
            global::System.Guid? id,
            string? description,
            global::Opik.GuardrailPolicyPublicExecutionScope? executionScope,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ExecutionScope = executionScope;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPolicyPublic" /> class.
        /// </summary>
        public GuardrailPolicyPublic()
        {
        }

    }
}