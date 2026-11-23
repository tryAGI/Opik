
#nullable enable

namespace Opik
{
    /// <summary>
    /// Source type
    /// </summary>
    public enum ViewInputKind
    {
        /// <summary>
        ///
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewInputKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewInputKind value)
        {
            return value switch
            {
                ViewInputKind.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewInputKind? ToEnum(string value)
        {
            return value switch
            {
                "query" => ViewInputKind.Query,
                _ => null,
            };
        }
    }
}