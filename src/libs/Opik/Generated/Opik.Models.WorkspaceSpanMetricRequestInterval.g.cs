
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceSpanMetricRequestInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Total,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceSpanMetricRequestIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceSpanMetricRequestInterval value)
        {
            return value switch
            {
                WorkspaceSpanMetricRequestInterval.Daily => "DAILY",
                WorkspaceSpanMetricRequestInterval.Hourly => "HOURLY",
                WorkspaceSpanMetricRequestInterval.Total => "TOTAL",
                WorkspaceSpanMetricRequestInterval.Weekly => "WEEKLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceSpanMetricRequestInterval? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => WorkspaceSpanMetricRequestInterval.Daily,
                "HOURLY" => WorkspaceSpanMetricRequestInterval.Hourly,
                "TOTAL" => WorkspaceSpanMetricRequestInterval.Total,
                "WEEKLY" => WorkspaceSpanMetricRequestInterval.Weekly,
                _ => null,
            };
        }
    }
}