
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorObjectObjectPublicDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeJsonConverter))]
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorObjectObjectPublicDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorObjectObjectPublicDiscriminator(
            global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorObjectObjectPublicDiscriminator" /> class.
        /// </summary>
        public AutomationRuleEvaluatorObjectObjectPublicDiscriminator()
        {
        }
    }
}