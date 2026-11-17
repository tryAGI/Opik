
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailPolicyRuleType
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
    public static class GuardrailPolicyRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPolicyRuleType value)
        {
            return value switch
            {
                GuardrailPolicyRuleType.CustomClassifier => "CUSTOM_CLASSIFIER",
                GuardrailPolicyRuleType.LlmJudge => "LLM_JUDGE",
                GuardrailPolicyRuleType.Pii => "PII",
                GuardrailPolicyRuleType.PromptInjection => "PROMPT_INJECTION",
                GuardrailPolicyRuleType.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPolicyRuleType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => GuardrailPolicyRuleType.CustomClassifier,
                "LLM_JUDGE" => GuardrailPolicyRuleType.LlmJudge,
                "PII" => GuardrailPolicyRuleType.Pii,
                "PROMPT_INJECTION" => GuardrailPolicyRuleType.PromptInjection,
                "TOPIC" => GuardrailPolicyRuleType.Topic,
                _ => null,
            };
        }
    }
}