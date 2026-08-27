
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum CheckName
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
    public static class CheckNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckName value)
        {
            return value switch
            {
                CheckName.CustomClassifier => "CUSTOM_CLASSIFIER",
                CheckName.LlmJudge => "LLM_JUDGE",
                CheckName.Pii => "PII",
                CheckName.PromptInjection => "PROMPT_INJECTION",
                CheckName.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckName? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM_CLASSIFIER" => CheckName.CustomClassifier,
                "LLM_JUDGE" => CheckName.LlmJudge,
                "PII" => CheckName.Pii,
                "PROMPT_INJECTION" => CheckName.PromptInjection,
                "TOPIC" => CheckName.Topic,
                _ => null,
            };
        }
    }
}