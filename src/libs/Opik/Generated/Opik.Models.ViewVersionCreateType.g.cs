
#nullable enable

namespace Opik
{
    /// <summary>
    /// View type
    /// </summary>
    public enum ViewVersionCreateType
    {
        /// <summary>
        ///
        /// </summary>
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewVersionCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewVersionCreateType value)
        {
            return value switch
            {
                ViewVersionCreateType.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewVersionCreateType? ToEnum(string value)
        {
            return value switch
            {
                "html" => ViewVersionCreateType.Html,
                _ => null,
            };
        }
    }
}