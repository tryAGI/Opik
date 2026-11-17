
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailPolicyWrite
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.GuardrailPolicyWriteExecutionScopeJsonConverter))]
        public global::Opik.GuardrailPolicyWriteExecutionScope? ExecutionScope { get; set; }

        /// <summary>
        /// At most one rule per type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRuleWrite> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPolicyWrite" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailPolicyWrite(
            string name,
            global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRuleWrite> rules,
            global::System.Guid? id,
            string? description,
            global::Opik.GuardrailPolicyWriteExecutionScope? executionScope)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ExecutionScope = executionScope;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPolicyWrite" /> class.
        /// </summary>
        public GuardrailPolicyWrite()
        {
        }

    }
}