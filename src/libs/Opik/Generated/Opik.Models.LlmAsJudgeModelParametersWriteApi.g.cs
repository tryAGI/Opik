
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum LlmAsJudgeModelParametersWriteApi
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmAsJudgeModelParametersWriteApiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeModelParametersWriteApi value)
        {
            return value switch
            {
                LlmAsJudgeModelParametersWriteApi.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeModelParametersWriteApi? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LlmAsJudgeModelParametersWriteApi.Decisions,
                _ => null,
            };
        }
    }
}