
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailPolicyRuleWriteType
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
    public static class GuardrailPolicyRuleWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPolicyRuleWriteType value)
        {
            return value switch
            {
                GuardrailPolicyRuleWriteType.CustomClassifier => "CUSTOM_CLASSIFIER",
                GuardrailPolicyRuleWriteType.LlmJudge => "LLM_JUDGE",
                GuardrailPolicyRuleWriteType.Pii => "PII",
                GuardrailPolicyRuleWriteType.PromptInjection => "PROMPT_INJECTION",
                GuardrailPolicyRuleWriteType.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPolicyRuleWriteType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => GuardrailPolicyRuleWriteType.CustomClassifier,
                "LLM_JUDGE" => GuardrailPolicyRuleWriteType.LlmJudge,
                "PII" => GuardrailPolicyRuleWriteType.Pii,
                "PROMPT_INJECTION" => GuardrailPolicyRuleWriteType.PromptInjection,
                "TOPIC" => GuardrailPolicyRuleWriteType.Topic,
                _ => null,
            };
        }
    }
}