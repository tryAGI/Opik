
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ValidationResultType
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
    public static class ValidationResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidationResultType value)
        {
            return value switch
            {
                ValidationResultType.CustomClassifier => "CUSTOM_CLASSIFIER",
                ValidationResultType.LlmJudge => "LLM_JUDGE",
                ValidationResultType.Pii => "PII",
                ValidationResultType.PromptInjection => "PROMPT_INJECTION",
                ValidationResultType.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidationResultType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => ValidationResultType.CustomClassifier,
                "LLM_JUDGE" => ValidationResultType.LlmJudge,
                "PII" => ValidationResultType.Pii,
                "PROMPT_INJECTION" => ValidationResultType.PromptInjection,
                "TOPIC" => ValidationResultType.Topic,
                _ => null,
            };
        }
    }
}