
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorLlmAsJudgeWrite : AutomationRuleEvaluatorWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterWrite>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.LlmAsJudgeCodeWrite? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudgeWrite" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorLlmAsJudgeWrite(
            global::System.Collections.Generic.IList<global::Opik.TraceFilterWrite>? filters,
            global::Opik.LlmAsJudgeCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudgeWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorLlmAsJudgeWrite()
        {
        }
    }
}