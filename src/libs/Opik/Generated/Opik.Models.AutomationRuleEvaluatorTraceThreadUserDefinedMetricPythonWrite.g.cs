#pragma warning disable CS0108 // member hides inherited member
#pragma warning disable CS8618 // non-nullable field uninitialized

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
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite(
            global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterWrite>? filters,
            global::Opik.TraceThreadUserDefinedMetricPythonCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite()
        {
        }
    }
}
