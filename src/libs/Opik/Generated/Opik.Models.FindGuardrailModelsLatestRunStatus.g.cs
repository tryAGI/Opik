
#nullable enable

namespace Opik
{
    /// <summary>
    /// Filter models by their latest run's status
    /// </summary>
    public enum FindGuardrailModelsLatestRunStatus
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
    public static class FindGuardrailModelsLatestRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindGuardrailModelsLatestRunStatus value)
        {
            return value switch
            {
                FindGuardrailModelsLatestRunStatus.Cancelled => "cancelled",
                FindGuardrailModelsLatestRunStatus.Completed => "completed",
                FindGuardrailModelsLatestRunStatus.Failed => "failed",
                FindGuardrailModelsLatestRunStatus.Queued => "queued",
                FindGuardrailModelsLatestRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindGuardrailModelsLatestRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => FindGuardrailModelsLatestRunStatus.Cancelled,
                "completed" => FindGuardrailModelsLatestRunStatus.Completed,
                "failed" => FindGuardrailModelsLatestRunStatus.Failed,
                "queued" => FindGuardrailModelsLatestRunStatus.Queued,
                "running" => FindGuardrailModelsLatestRunStatus.Running,
                _ => null,
            };
        }
    }
}