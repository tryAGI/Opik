
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum OllieReportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OllieReportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OllieReportStatus value)
        {
            return value switch
            {
                OllieReportStatus.Completed => "completed",
                OllieReportStatus.Failed => "failed",
                OllieReportStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OllieReportStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OllieReportStatus.Completed,
                "failed" => OllieReportStatus.Failed,
                "pending" => OllieReportStatus.Pending,
                _ => null,
            };
        }
    }
}