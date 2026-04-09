
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionType
    {
        /// <summary>
        /// 
        /// </summary>
        Jinja2,
        /// <summary>
        /// 
        /// </summary>
        Mustache,
        /// <summary>
        /// 
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionType value)
        {
            return value switch
            {
                PromptVersionType.Jinja2 => "jinja2",
                PromptVersionType.Mustache => "mustache",
                PromptVersionType.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionType? ToEnum(string value)
        {
            return value switch
            {
                "jinja2" => PromptVersionType.Jinja2,
                "mustache" => PromptVersionType.Mustache,
                "python" => PromptVersionType.Python,
                _ => null,
            };
        }
    }
}