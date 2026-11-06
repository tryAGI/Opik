
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum LlmAsJudgeModelParametersApi
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmAsJudgeModelParametersApiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeModelParametersApi value)
        {
            return value switch
            {
                LlmAsJudgeModelParametersApi.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeModelParametersApi? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LlmAsJudgeModelParametersApi.Decisions,
                _ => null,
            };
        }
    }
}