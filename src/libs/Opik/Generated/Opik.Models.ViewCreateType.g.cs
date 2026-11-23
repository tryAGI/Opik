
#nullable enable

namespace Opik
{
    /// <summary>
    /// View type
    /// </summary>
    public enum ViewCreateType
    {
        /// <summary>
        ///
        /// </summary>
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewCreateType value)
        {
            return value switch
            {
                ViewCreateType.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewCreateType? ToEnum(string value)
        {
            return value switch
            {
                "html" => ViewCreateType.Html,
                _ => null,
            };
        }
    }
}