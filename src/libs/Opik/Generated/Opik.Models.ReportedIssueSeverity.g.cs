
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReportedIssueSeverity
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
    public static class ReportedIssueSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportedIssueSeverity value)
        {
            return value switch
            {
                ReportedIssueSeverity.Critical => "critical",
                ReportedIssueSeverity.High => "high",
                ReportedIssueSeverity.Low => "low",
                ReportedIssueSeverity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportedIssueSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ReportedIssueSeverity.Critical,
                "high" => ReportedIssueSeverity.High,
                "low" => ReportedIssueSeverity.Low,
                "medium" => ReportedIssueSeverity.Medium,
                _ => null,
            };
        }
    }
}