
#nullable enable

namespace Opik
{
    /// <summary>
    /// running: the run started and has not ended. failed: it ended without saving
    /// </summary>
    public enum AttemptStatus
    {
        /// <summary>
        /// the run started and has not ended. failed: it ended without saving
        /// </summary>
        Failed,
        /// <summary>
        /// the run started and has not ended. failed: it ended without saving
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AttemptStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttemptStatus value)
        {
            return value switch
            {
                AttemptStatus.Failed => "failed",
                AttemptStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttemptStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AttemptStatus.Failed,
                "running" => AttemptStatus.Running,
                _ => null,
            };
        }
    }
}