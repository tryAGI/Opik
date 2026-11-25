
#nullable enable

namespace Opik
{
    /// <summary>
    /// disabled: the workspace is not opted in to topics. collecting: the project has no topics yet. ready: topics with counts. too_large: the project has too many traces in the window to count; a retry answers the same
    /// </summary>
    public enum ProjectTopicsStatus
    {
        /// <summary>
        /// the workspace is not opted in to topics. collecting: the project has no topics yet. ready: topics with counts. too_large: the project has too many traces in the window to count; a retry answers the same
        /// </summary>
        Collecting,
        /// <summary>
        /// the workspace is not opted in to topics. collecting: the project has no topics yet. ready: topics with counts. too_large: the project has too many traces in the window to count; a retry answers the same
        /// </summary>
        Disabled,
        /// <summary>
        /// the workspace is not opted in to topics. collecting: the project has no topics yet. ready: topics with counts. too_large: the project has too many traces in the window to count; a retry answers the same
        /// </summary>
        Ready,
        /// <summary>
        /// the workspace is not opted in to topics. collecting: the project has no topics yet. ready: topics with counts. too_large: the project has too many traces in the window to count; a retry answers the same
        /// </summary>
        TooLarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectTopicsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectTopicsStatus value)
        {
            return value switch
            {
                ProjectTopicsStatus.Collecting => "collecting",
                ProjectTopicsStatus.Disabled => "disabled",
                ProjectTopicsStatus.Ready => "ready",
                ProjectTopicsStatus.TooLarge => "too_large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectTopicsStatus? ToEnum(string value)
        {
            return value switch
            {
                "collecting" => ProjectTopicsStatus.Collecting,
                "disabled" => ProjectTopicsStatus.Disabled,
                "ready" => ProjectTopicsStatus.Ready,
                "too_large" => ProjectTopicsStatus.TooLarge,
                _ => null,
            };
        }
    }
}