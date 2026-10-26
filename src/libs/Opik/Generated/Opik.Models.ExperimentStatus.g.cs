
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ExperimentStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
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
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentStatus value)
        {
            return value switch
            {
                ExperimentStatus.Cancelled => "cancelled",
                ExperimentStatus.Completed => "completed",
                ExperimentStatus.Failed => "failed",
                ExperimentStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ExperimentStatus.Cancelled,
                "completed" => ExperimentStatus.Completed,
                "failed" => ExperimentStatus.Failed,
                "running" => ExperimentStatus.Running,
                _ => null,
            };
        }
    }
}