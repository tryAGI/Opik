
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum ScoreConditionPublicOperator
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
    public static class ScoreConditionPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreConditionPublicOperator value)
        {
            return value switch
            {
                ScoreConditionPublicOperator.Lt => "<",
                ScoreConditionPublicOperator.Eq => "=",
                ScoreConditionPublicOperator.Gt => ">",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreConditionPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => ScoreConditionPublicOperator.Lt,
                "=" => ScoreConditionPublicOperator.Eq,
                ">" => ScoreConditionPublicOperator.Gt,
                _ => null,
            };
        }
    }
}