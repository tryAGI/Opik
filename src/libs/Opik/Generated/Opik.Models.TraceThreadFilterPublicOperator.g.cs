
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadFilterPublicOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Equal,
        /// <summary>
        /// 
        /// </summary>
        GreaterOrEqual,
        /// <summary>
        /// 
        /// </summary>
        GreaterThan,
        /// <summary>
        /// 
        /// </summary>
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        LessOrEqual,
        /// <summary>
        /// 
        /// </summary>
        LessThan,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        NotEqual,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceThreadFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterPublicOperator value)
        {
            return value switch
            {
                TraceThreadFilterPublicOperator.Contains => "contains",
                TraceThreadFilterPublicOperator.EndsWith => "ends_with",
                TraceThreadFilterPublicOperator.Equal => "equal",
                TraceThreadFilterPublicOperator.GreaterOrEqual => "greater_or_equal",
                TraceThreadFilterPublicOperator.GreaterThan => "greater_than",
                TraceThreadFilterPublicOperator.IsEmpty => "is_empty",
                TraceThreadFilterPublicOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterPublicOperator.LessOrEqual => "less_or_equal",
                TraceThreadFilterPublicOperator.LessThan => "less_than",
                TraceThreadFilterPublicOperator.NotContains => "not_contains",
                TraceThreadFilterPublicOperator.NotEqual => "not_equal",
                TraceThreadFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => TraceThreadFilterPublicOperator.Contains,
                "ends_with" => TraceThreadFilterPublicOperator.EndsWith,
                "equal" => TraceThreadFilterPublicOperator.Equal,
                "greater_or_equal" => TraceThreadFilterPublicOperator.GreaterOrEqual,
                "greater_than" => TraceThreadFilterPublicOperator.GreaterThan,
                "is_empty" => TraceThreadFilterPublicOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterPublicOperator.IsNotEmpty,
                "less_or_equal" => TraceThreadFilterPublicOperator.LessOrEqual,
                "less_than" => TraceThreadFilterPublicOperator.LessThan,
                "not_contains" => TraceThreadFilterPublicOperator.NotContains,
                "not_equal" => TraceThreadFilterPublicOperator.NotEqual,
                "starts_with" => TraceThreadFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}