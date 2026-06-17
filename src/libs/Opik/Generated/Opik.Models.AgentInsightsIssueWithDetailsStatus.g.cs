
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentInsightsIssueWithDetailsStatus
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
    public static class AgentInsightsIssueWithDetailsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightsIssueWithDetailsStatus value)
        {
            return value switch
            {
                AgentInsightsIssueWithDetailsStatus.Closed => "closed",
                AgentInsightsIssueWithDetailsStatus.Open => "open",
                AgentInsightsIssueWithDetailsStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightsIssueWithDetailsStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => AgentInsightsIssueWithDetailsStatus.Closed,
                "open" => AgentInsightsIssueWithDetailsStatus.Open,
                "resolved" => AgentInsightsIssueWithDetailsStatus.Resolved,
                _ => null,
            };
        }
    }
}