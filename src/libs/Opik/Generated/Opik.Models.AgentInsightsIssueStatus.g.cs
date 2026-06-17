
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentInsightsIssueStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentInsightsIssueStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightsIssueStatus value)
        {
            return value switch
            {
                AgentInsightsIssueStatus.Closed => "closed",
                AgentInsightsIssueStatus.Open => "open",
                AgentInsightsIssueStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightsIssueStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => AgentInsightsIssueStatus.Closed,
                "open" => AgentInsightsIssueStatus.Open,
                "resolved" => AgentInsightsIssueStatus.Resolved,
                _ => null,
            };
        }
    }
}