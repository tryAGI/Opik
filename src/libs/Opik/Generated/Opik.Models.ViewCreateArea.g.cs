
#nullable enable

namespace Opik
{
    /// <summary>
    /// The content area the view is written for; fixed after creation
    /// </summary>
    public enum ViewCreateArea
    {
        /// <summary>
        ///
        /// </summary>
        Widget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewCreateAreaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewCreateArea value)
        {
            return value switch
            {
                ViewCreateArea.Widget => "widget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewCreateArea? ToEnum(string value)
        {
            return value switch
            {
                "widget" => ViewCreateArea.Widget,
                _ => null,
            };
        }
    }
}