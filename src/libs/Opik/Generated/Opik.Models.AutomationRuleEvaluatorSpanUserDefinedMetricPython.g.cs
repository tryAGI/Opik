#pragma warning disable CS0108 // member hides inherited member
#pragma warning disable CS8618 // non-nullable field uninitialized

#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorSpanUserDefinedMetricPython : global::Opik.AutomationRuleEvaluator
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
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanUserDefinedMetricPython" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorSpanUserDefinedMetricPython(
            global::System.Collections.Generic.IList<global::Opik.SpanFilter>? filters,
            global::Opik.SpanUserDefinedMetricPythonCode? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanUserDefinedMetricPython" /> class.
        /// </summary>
        public AutomationRuleEvaluatorSpanUserDefinedMetricPython()
        {
        }
    }
}
