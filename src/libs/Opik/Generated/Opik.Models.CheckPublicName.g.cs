
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum CheckPublicName
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
    public static class CheckPublicNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckPublicName value)
        {
            return value switch
            {
                CheckPublicName.CustomClassifier => "CUSTOM_CLASSIFIER",
                CheckPublicName.LlmJudge => "LLM_JUDGE",
                CheckPublicName.Pii => "PII",
                CheckPublicName.PromptInjection => "PROMPT_INJECTION",
                CheckPublicName.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckPublicName? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => CheckPublicName.CustomClassifier,
                "LLM_JUDGE" => CheckPublicName.LlmJudge,
                "PII" => CheckPublicName.Pii,
                "PROMPT_INJECTION" => CheckPublicName.PromptInjection,
                "TOPIC" => CheckPublicName.Topic,
                _ => null,
            };
        }
    }
}