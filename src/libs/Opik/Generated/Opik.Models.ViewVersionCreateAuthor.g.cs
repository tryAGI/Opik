
#nullable enable

namespace Opik
{
    /// <summary>
    /// Who produced the version: user (default), ollie or agent. Informational only
    /// </summary>
    public enum ViewVersionCreateAuthor
    {
        /// <summary>
        /// user (default), ollie or agent. Informational only
        /// </summary>
        Agent,
        /// <summary>
        /// user (default), ollie or agent. Informational only
        /// </summary>
        Ollie,
        /// <summary>
        /// user (default), ollie or agent. Informational only
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewVersionCreateAuthorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewVersionCreateAuthor value)
        {
            return value switch
            {
                ViewVersionCreateAuthor.Agent => "agent",
                ViewVersionCreateAuthor.Ollie => "ollie",
                ViewVersionCreateAuthor.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewVersionCreateAuthor? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ViewVersionCreateAuthor.Agent,
                "ollie" => ViewVersionCreateAuthor.Ollie,
                "user" => ViewVersionCreateAuthor.User,
                _ => null,
            };
        }
    }
}