
#nullable enable

namespace Opik
{
    /// <summary>
    /// version type discriminator; defaults to prompt_version
    /// </summary>
    public enum PromptVersionVersionType
    {
        /// <summary>
        /// 
        /// </summary>
        Mask,
        /// <summary>
        /// 
        /// </summary>
        PromptVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionVersionType value)
        {
            return value switch
            {
                PromptVersionVersionType.Mask => "mask",
                PromptVersionVersionType.PromptVersion => "prompt_version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionVersionType? ToEnum(string value)
        {
            return value switch
            {
                "mask" => PromptVersionVersionType.Mask,
                "prompt_version" => PromptVersionVersionType.PromptVersion,
                _ => null,
            };
        }
    }
}