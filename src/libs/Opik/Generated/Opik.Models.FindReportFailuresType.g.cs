
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum FindReportFailuresType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentInsights,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FindReportFailuresTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindReportFailuresType value)
        {
            return value switch
            {
                FindReportFailuresType.AgentInsights => "agent_insights",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindReportFailuresType? ToEnum(string value)
        {
            return value switch
            {
                "agent_insights" => FindReportFailuresType.AgentInsights,
                _ => null,
            };
        }
    }
}