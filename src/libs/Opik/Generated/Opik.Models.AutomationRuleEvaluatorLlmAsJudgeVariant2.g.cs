#pragma warning disable CS0108 // member hides inherited member
#pragma warning disable CS8618 // non-nullable field uninitialized

#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorLlmAsJudgeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.TraceFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.LlmAsJudgeCode? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudgeVariant2" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorLlmAsJudgeVariant2(
            global::System.Collections.Generic.IList<global::Opik.TraceFilter>? filters,
            global::Opik.LlmAsJudgeCode? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudgeVariant2" /> class.
        /// </summary>
        public AutomationRuleEvaluatorLlmAsJudgeVariant2()
        {
        }
    }
}
