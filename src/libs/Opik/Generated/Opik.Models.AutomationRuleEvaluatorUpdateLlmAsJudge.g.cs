
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUpdateLlmAsJudge : AutomationRuleEvaluatorUpdate
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
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateLlmAsJudge" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorUpdateLlmAsJudge(
            global::System.Collections.Generic.IList<global::Opik.TraceFilter>? filters,
            global::Opik.LlmAsJudgeCode? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateLlmAsJudge" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUpdateLlmAsJudge()
        {
        }
    }
}