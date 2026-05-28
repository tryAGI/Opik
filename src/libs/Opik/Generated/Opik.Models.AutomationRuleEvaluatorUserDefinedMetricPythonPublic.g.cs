
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUserDefinedMetricPythonPublic : global::Opik.AutomationRuleEvaluatorPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::Opik.UserDefinedMetricPythonCodePublic? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUserDefinedMetricPythonPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorUserDefinedMetricPythonPublic(
            string name,
            global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? filters,
            global::Opik.UserDefinedMetricPythonCodePublic? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUserDefinedMetricPythonPublic" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUserDefinedMetricPythonPublic()
        {
        }

    }
}