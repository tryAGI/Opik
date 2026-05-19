
#nullable enable

namespace Opik
{
    /// <summary>
    /// version type discriminator; defaults to prompt_version
    /// </summary>
    public enum PromptVersionDetailVersionType
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
    public static class PromptVersionDetailVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionDetailVersionType value)
        {
            return value switch
            {
                PromptVersionDetailVersionType.Mask => "mask",
                PromptVersionDetailVersionType.PromptVersion => "prompt_version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionDetailVersionType? ToEnum(string value)
        {
            return value switch
            {
                "mask" => PromptVersionDetailVersionType.Mask,
                "prompt_version" => PromptVersionDetailVersionType.PromptVersion,
                _ => null,
            };
        }
    }
}