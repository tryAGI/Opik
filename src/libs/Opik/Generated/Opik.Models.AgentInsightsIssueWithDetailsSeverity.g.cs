
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentInsightsIssueWithDetailsSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentInsightsIssueWithDetailsSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightsIssueWithDetailsSeverity value)
        {
            return value switch
            {
                AgentInsightsIssueWithDetailsSeverity.Critical => "critical",
                AgentInsightsIssueWithDetailsSeverity.High => "high",
                AgentInsightsIssueWithDetailsSeverity.Low => "low",
                AgentInsightsIssueWithDetailsSeverity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightsIssueWithDetailsSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => AgentInsightsIssueWithDetailsSeverity.Critical,
                "high" => AgentInsightsIssueWithDetailsSeverity.High,
                "low" => AgentInsightsIssueWithDetailsSeverity.Low,
                "medium" => AgentInsightsIssueWithDetailsSeverity.Medium,
                _ => null,
            };
        }
    }
}