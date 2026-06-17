
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum FindAgentInsightsIssuesStatus
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
    public static class FindAgentInsightsIssuesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindAgentInsightsIssuesStatus value)
        {
            return value switch
            {
                FindAgentInsightsIssuesStatus.Closed => "closed",
                FindAgentInsightsIssuesStatus.Open => "open",
                FindAgentInsightsIssuesStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindAgentInsightsIssuesStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => FindAgentInsightsIssuesStatus.Closed,
                "open" => FindAgentInsightsIssuesStatus.Open,
                "resolved" => FindAgentInsightsIssuesStatus.Resolved,
                _ => null,
            };
        }
    }
}