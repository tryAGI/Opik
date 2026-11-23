
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ViewArea
    {
        /// <summary>
        ///
        /// </summary>
        Widget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewAreaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewArea value)
        {
            return value switch
            {
                ViewArea.Widget => "widget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewArea? ToEnum(string value)
        {
            return value switch
            {
                "widget" => ViewArea.Widget,
                _ => null,
            };
        }
    }
}