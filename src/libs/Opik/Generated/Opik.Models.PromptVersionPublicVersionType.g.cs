
#nullable enable

namespace Opik
{
    /// <summary>
    /// version type discriminator; defaults to prompt_version
    /// </summary>
    public enum PromptVersionPublicVersionType
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
    public static class PromptVersionPublicVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionPublicVersionType value)
        {
            return value switch
            {
                PromptVersionPublicVersionType.Mask => "mask",
                PromptVersionPublicVersionType.PromptVersion => "prompt_version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionPublicVersionType? ToEnum(string value)
        {
            return value switch
            {
                "mask" => PromptVersionPublicVersionType.Mask,
                "prompt_version" => PromptVersionPublicVersionType.PromptVersion,
                _ => null,
            };
        }
    }
}