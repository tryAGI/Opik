
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite : global::Opik.AutomationRuleEvaluatorWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterWrite>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.TraceThreadUserDefinedMetricPythonCodeWrite? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite(
            string name,
            global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterWrite>? filters,
            global::Opik.TraceThreadUserDefinedMetricPythonCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite()
        {
        }

    }
}