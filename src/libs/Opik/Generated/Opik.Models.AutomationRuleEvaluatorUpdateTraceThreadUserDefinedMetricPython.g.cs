
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython : AutomationRuleEvaluatorUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.TraceThreadUserDefinedMetricPythonCode? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython(
            global::System.Collections.Generic.IList<global::Opik.TraceThreadFilter>? filters,
            global::Opik.TraceThreadUserDefinedMetricPythonCode? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython()
        {
        }
    }
}