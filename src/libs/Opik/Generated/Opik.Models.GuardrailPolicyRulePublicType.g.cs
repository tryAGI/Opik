
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailPolicyRulePublicType
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
    public static class GuardrailPolicyRulePublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPolicyRulePublicType value)
        {
            return value switch
            {
                GuardrailPolicyRulePublicType.CustomClassifier => "CUSTOM_CLASSIFIER",
                GuardrailPolicyRulePublicType.LlmJudge => "LLM_JUDGE",
                GuardrailPolicyRulePublicType.Pii => "PII",
                GuardrailPolicyRulePublicType.PromptInjection => "PROMPT_INJECTION",
                GuardrailPolicyRulePublicType.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPolicyRulePublicType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => GuardrailPolicyRulePublicType.CustomClassifier,
                "LLM_JUDGE" => GuardrailPolicyRulePublicType.LlmJudge,
                "PII" => GuardrailPolicyRulePublicType.Pii,
                "PROMPT_INJECTION" => GuardrailPolicyRulePublicType.PromptInjection,
                "TOPIC" => GuardrailPolicyRulePublicType.Topic,
                _ => null,
            };
        }
    }
}