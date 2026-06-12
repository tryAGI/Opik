
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReportCompleteRequestStatus
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
    public static class ReportCompleteRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportCompleteRequestStatus value)
        {
            return value switch
            {
                ReportCompleteRequestStatus.Completed => "completed",
                ReportCompleteRequestStatus.Failed => "failed",
                ReportCompleteRequestStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportCompleteRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ReportCompleteRequestStatus.Completed,
                "failed" => ReportCompleteRequestStatus.Failed,
                "pending" => ReportCompleteRequestStatus.Pending,
                _ => null,
            };
        }
    }
}