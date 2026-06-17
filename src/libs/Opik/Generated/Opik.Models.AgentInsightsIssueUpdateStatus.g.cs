
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentInsightsIssueUpdateStatus
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
    public static class AgentInsightsIssueUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightsIssueUpdateStatus value)
        {
            return value switch
            {
                AgentInsightsIssueUpdateStatus.Closed => "closed",
                AgentInsightsIssueUpdateStatus.Open => "open",
                AgentInsightsIssueUpdateStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightsIssueUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => AgentInsightsIssueUpdateStatus.Closed,
                "open" => AgentInsightsIssueUpdateStatus.Open,
                "resolved" => AgentInsightsIssueUpdateStatus.Resolved,
                _ => null,
            };
        }
    }
}