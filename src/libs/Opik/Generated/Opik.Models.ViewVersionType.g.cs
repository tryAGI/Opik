
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ViewVersionType
    {
        /// <summary>
        ///
        /// </summary>
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewVersionType value)
        {
            return value switch
            {
                ViewVersionType.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewVersionType? ToEnum(string value)
        {
            return value switch
            {
                "html" => ViewVersionType.Html,
                _ => null,
            };
        }
    }
}