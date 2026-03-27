
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorSpanLlmAsJudgePublic : AutomationRuleEvaluatorPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.SpanLlmAsJudgeCodePublic? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudgePublic" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorSpanLlmAsJudgePublic(
            global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? filters,
            global::Opik.SpanLlmAsJudgeCodePublic? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudgePublic" /> class.
        /// </summary>
        public AutomationRuleEvaluatorSpanLlmAsJudgePublic()
        {
        }
    }
}