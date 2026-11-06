
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum LlmAsJudgeModelParametersPublicApi
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmAsJudgeModelParametersPublicApiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeModelParametersPublicApi value)
        {
            return value switch
            {
                LlmAsJudgeModelParametersPublicApi.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeModelParametersPublicApi? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LlmAsJudgeModelParametersPublicApi.Decisions,
                _ => null,
            };
        }
    }
}