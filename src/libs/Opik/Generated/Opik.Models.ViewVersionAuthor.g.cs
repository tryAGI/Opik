
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ViewVersionAuthor
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
    public static class ViewVersionAuthorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewVersionAuthor value)
        {
            return value switch
            {
                ViewVersionAuthor.Agent => "agent",
                ViewVersionAuthor.Ollie => "ollie",
                ViewVersionAuthor.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewVersionAuthor? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ViewVersionAuthor.Agent,
                "ollie" => ViewVersionAuthor.Ollie,
                "user" => ViewVersionAuthor.User,
                _ => null,
            };
        }
    }
}