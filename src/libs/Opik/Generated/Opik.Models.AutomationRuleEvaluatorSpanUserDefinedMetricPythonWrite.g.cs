
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite : AutomationRuleEvaluatorWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterWrite>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.SpanUserDefinedMetricPythonCodeWrite? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite(
            global::System.Collections.Generic.IList<global::Opik.SpanFilterWrite>? filters,
            global::Opik.SpanUserDefinedMetricPythonCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite()
        {
        }
    }
}