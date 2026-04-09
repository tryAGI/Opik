
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionPublicType
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
    public static class PromptVersionPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionPublicType value)
        {
            return value switch
            {
                PromptVersionPublicType.Jinja2 => "jinja2",
                PromptVersionPublicType.Mustache => "mustache",
                PromptVersionPublicType.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionPublicType? ToEnum(string value)
        {
            return value switch
            {
                "jinja2" => PromptVersionPublicType.Jinja2,
                "mustache" => PromptVersionPublicType.Mustache,
                "python" => PromptVersionPublicType.Python,
                _ => null,
            };
        }
    }
}