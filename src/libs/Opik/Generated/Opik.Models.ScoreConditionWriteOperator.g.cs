
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreConditionWriteOperator
    {
        /// <summary>
        ///
        /// </summary>
        Lt,
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        Gt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreConditionWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreConditionWriteOperator value)
        {
            return value switch
            {
                ScoreConditionWriteOperator.Lt => "<",
                ScoreConditionWriteOperator.Eq => "=",
                ScoreConditionWriteOperator.Gt => ">",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreConditionWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => ScoreConditionWriteOperator.Lt,
                "=" => ScoreConditionWriteOperator.Eq,
                ">" => ScoreConditionWriteOperator.Gt,
                _ => null,
            };
        }
    }
}