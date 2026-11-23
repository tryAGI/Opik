
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ViewVersionSummaryAuthor
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Ollie,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewVersionSummaryAuthorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewVersionSummaryAuthor value)
        {
            return value switch
            {
                ViewVersionSummaryAuthor.Agent => "agent",
                ViewVersionSummaryAuthor.Ollie => "ollie",
                ViewVersionSummaryAuthor.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewVersionSummaryAuthor? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ViewVersionSummaryAuthor.Agent,
                "ollie" => ViewVersionSummaryAuthor.Ollie,
                "user" => ViewVersionSummaryAuthor.User,
                _ => null,
            };
        }
    }
}