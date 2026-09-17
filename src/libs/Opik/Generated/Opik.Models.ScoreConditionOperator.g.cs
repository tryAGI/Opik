
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreConditionOperator
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
    public static class ScoreConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreConditionOperator value)
        {
            return value switch
            {
                ScoreConditionOperator.Lt => "<",
                ScoreConditionOperator.Eq => "=",
                ScoreConditionOperator.Gt => ">",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => ScoreConditionOperator.Lt,
                "=" => ScoreConditionOperator.Eq,
                ">" => ScoreConditionOperator.Gt,
                _ => null,
            };
        }
    }
}