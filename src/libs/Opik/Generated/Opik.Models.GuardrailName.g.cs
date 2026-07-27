
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailName
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
    public static class GuardrailNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailName value)
        {
            return value switch
            {
                GuardrailName.CustomClassifier => "CUSTOM_CLASSIFIER",
                GuardrailName.LlmJudge => "LLM_JUDGE",
                GuardrailName.Pii => "PII",
                GuardrailName.PromptInjection => "PROMPT_INJECTION",
                GuardrailName.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailName? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => GuardrailName.CustomClassifier,
                "LLM_JUDGE" => GuardrailName.LlmJudge,
                "PII" => GuardrailName.Pii,
                "PROMPT_INJECTION" => GuardrailName.PromptInjection,
                "TOPIC" => GuardrailName.Topic,
                _ => null,
            };
        }
    }
}