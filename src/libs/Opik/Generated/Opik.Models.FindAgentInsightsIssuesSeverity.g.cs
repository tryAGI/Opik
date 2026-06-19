
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum FindAgentInsightsIssuesSeverity
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
    public static class FindAgentInsightsIssuesSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindAgentInsightsIssuesSeverity value)
        {
            return value switch
            {
                FindAgentInsightsIssuesSeverity.Critical => "critical",
                FindAgentInsightsIssuesSeverity.High => "high",
                FindAgentInsightsIssuesSeverity.Low => "low",
                FindAgentInsightsIssuesSeverity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindAgentInsightsIssuesSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => FindAgentInsightsIssuesSeverity.Critical,
                "high" => FindAgentInsightsIssuesSeverity.High,
                "low" => FindAgentInsightsIssuesSeverity.Low,
                "medium" => FindAgentInsightsIssuesSeverity.Medium,
                _ => null,
            };
        }
    }
}