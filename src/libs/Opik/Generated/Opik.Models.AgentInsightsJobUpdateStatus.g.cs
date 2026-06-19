
#nullable enable

namespace Opik
{
    /// <summary>
    /// New status for the job
    /// </summary>
    public enum AgentInsightsJobUpdateStatus
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
    public static class AgentInsightsJobUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightsJobUpdateStatus value)
        {
            return value switch
            {
                AgentInsightsJobUpdateStatus.Disabled => "disabled",
                AgentInsightsJobUpdateStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightsJobUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AgentInsightsJobUpdateStatus.Disabled,
                "enabled" => AgentInsightsJobUpdateStatus.Enabled,
                _ => null,
            };
        }
    }
}