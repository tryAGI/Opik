
#nullable enable

namespace Opik
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum GuardrailTrainingRunStatus
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
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailTrainingRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailTrainingRunStatus value)
        {
            return value switch
            {
                GuardrailTrainingRunStatus.Cancelled => "cancelled",
                GuardrailTrainingRunStatus.Completed => "completed",
                GuardrailTrainingRunStatus.Failed => "failed",
                GuardrailTrainingRunStatus.Queued => "queued",
                GuardrailTrainingRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailTrainingRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => GuardrailTrainingRunStatus.Cancelled,
                "completed" => GuardrailTrainingRunStatus.Completed,
                "failed" => GuardrailTrainingRunStatus.Failed,
                "queued" => GuardrailTrainingRunStatus.Queued,
                "running" => GuardrailTrainingRunStatus.Running,
                _ => null,
            };
        }
    }
}