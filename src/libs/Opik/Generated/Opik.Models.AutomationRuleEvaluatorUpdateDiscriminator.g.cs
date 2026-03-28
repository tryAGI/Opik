#pragma warning disable CS0108 // member hides inherited member
#pragma warning disable CS8618 // non-nullable field uninitialized

#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUpdateDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateDiscriminatorTypeJsonConverter))]
        public global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorUpdateDiscriminator(
            global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateDiscriminator" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUpdateDiscriminator()
        {
        }
    }
}
