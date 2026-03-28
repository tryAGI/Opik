#pragma warning disable CS0108 // member hides inherited member
#pragma warning disable CS8618 // non-nullable field uninitialized

#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorPublicDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorPublicDiscriminatorTypeJsonConverter))]
        public global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorPublicDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorPublicDiscriminator(
            global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorPublicDiscriminator" /> class.
        /// </summary>
        public AutomationRuleEvaluatorPublicDiscriminator()
        {
        }
    }
}
