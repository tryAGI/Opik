
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolsParamChatCompletions
    {
        /// <summary>
        ///
        /// </summary>
        EffortNoneOnly,
        /// <summary>
        ///
        /// </summary>
        Refused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsParamChatCompletionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsParamChatCompletions value)
        {
            return value switch
            {
                ToolsParamChatCompletions.EffortNoneOnly => "effortNoneOnly",
                ToolsParamChatCompletions.Refused => "refused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsParamChatCompletions? ToEnum(string value)
        {
            return value switch
            {
                "effortNoneOnly" => ToolsParamChatCompletions.EffortNoneOnly,
                "refused" => ToolsParamChatCompletions.Refused,
                _ => null,
            };
        }
    }
}