
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ValidationDescriptorType
    {
        /// <summary>
        ///
        /// </summary>
        CustomClassifier,
        /// <summary>
        ///
        /// </summary>
        LlmJudge,
        /// <summary>
        ///
        /// </summary>
        Pii,
        /// <summary>
        ///
        /// </summary>
        PromptInjection,
        /// <summary>
        ///
        /// </summary>
        Topic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidationDescriptorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidationDescriptorType value)
        {
            return value switch
            {
                ValidationDescriptorType.CustomClassifier => "CUSTOM_CLASSIFIER",
                ValidationDescriptorType.LlmJudge => "LLM_JUDGE",
                ValidationDescriptorType.Pii => "PII",
                ValidationDescriptorType.PromptInjection => "PROMPT_INJECTION",
                ValidationDescriptorType.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidationDescriptorType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => ValidationDescriptorType.CustomClassifier,
                "LLM_JUDGE" => ValidationDescriptorType.LlmJudge,
                "PII" => ValidationDescriptorType.Pii,
                "PROMPT_INJECTION" => ValidationDescriptorType.PromptInjection,
                "TOPIC" => ValidationDescriptorType.Topic,
                _ => null,
            };
        }
    }
}