
#nullable enable

namespace Opik
{
    /// <summary>
    /// Who produced the version: user (default), ollie or agent. Informational only
    /// </summary>
    public enum ViewCreateAuthor
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
    public static class ViewCreateAuthorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewCreateAuthor value)
        {
            return value switch
            {
                ViewCreateAuthor.Agent => "agent",
                ViewCreateAuthor.Ollie => "ollie",
                ViewCreateAuthor.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewCreateAuthor? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ViewCreateAuthor.Agent,
                "ollie" => ViewCreateAuthor.Ollie,
                "user" => ViewCreateAuthor.User,
                _ => null,
            };
        }
    }
}