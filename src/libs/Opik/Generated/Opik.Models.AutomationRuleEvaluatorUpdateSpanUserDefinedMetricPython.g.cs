
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython : AutomationRuleEvaluatorUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.SpanFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.SpanUserDefinedMetricPythonCode? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython(
            global::System.Collections.Generic.IList<global::Opik.SpanFilter>? filters,
            global::Opik.SpanUserDefinedMetricPythonCode? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython()
        {
        }
    }
}