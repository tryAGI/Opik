
#nullable enable

namespace Opik
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum AgentInsightsJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentInsightsJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightsJobStatus value)
        {
            return value switch
            {
                AgentInsightsJobStatus.Disabled => "disabled",
                AgentInsightsJobStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightsJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AgentInsightsJobStatus.Disabled,
                "enabled" => AgentInsightsJobStatus.Enabled,
                _ => null,
            };
        }
    }
}