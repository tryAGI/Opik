
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentInsightsIssueSeverity
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
    public static class AgentInsightsIssueSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightsIssueSeverity value)
        {
            return value switch
            {
                AgentInsightsIssueSeverity.Critical => "critical",
                AgentInsightsIssueSeverity.High => "high",
                AgentInsightsIssueSeverity.Low => "low",
                AgentInsightsIssueSeverity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightsIssueSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => AgentInsightsIssueSeverity.Critical,
                "high" => AgentInsightsIssueSeverity.High,
                "low" => AgentInsightsIssueSeverity.Low,
                "medium" => AgentInsightsIssueSeverity.Medium,
                _ => null,
            };
        }
    }
}