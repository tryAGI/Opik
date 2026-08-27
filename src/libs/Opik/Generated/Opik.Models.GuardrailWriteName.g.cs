
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailWriteName
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
    public static class GuardrailWriteNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailWriteName value)
        {
            return value switch
            {
                GuardrailWriteName.CustomClassifier => "CUSTOM_CLASSIFIER",
                GuardrailWriteName.LlmJudge => "LLM_JUDGE",
                GuardrailWriteName.Pii => "PII",
                GuardrailWriteName.PromptInjection => "PROMPT_INJECTION",
                GuardrailWriteName.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailWriteName? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => GuardrailWriteName.CustomClassifier,
                "LLM_JUDGE" => GuardrailWriteName.LlmJudge,
                "PII" => GuardrailWriteName.Pii,
                "PROMPT_INJECTION" => GuardrailWriteName.PromptInjection,
                "TOPIC" => GuardrailWriteName.Topic,
                _ => null,
            };
        }
    }
}