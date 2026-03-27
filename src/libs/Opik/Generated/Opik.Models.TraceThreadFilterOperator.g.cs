
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadFilterOperator
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
    public static class TraceThreadFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterOperator value)
        {
            return value switch
            {
                TraceThreadFilterOperator.Contains => "contains",
                TraceThreadFilterOperator.EndsWith => "ends_with",
                TraceThreadFilterOperator.Equal => "equal",
                TraceThreadFilterOperator.GreaterOrEqual => "greater_or_equal",
                TraceThreadFilterOperator.GreaterThan => "greater_than",
                TraceThreadFilterOperator.IsEmpty => "is_empty",
                TraceThreadFilterOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterOperator.LessOrEqual => "less_or_equal",
                TraceThreadFilterOperator.LessThan => "less_than",
                TraceThreadFilterOperator.NotContains => "not_contains",
                TraceThreadFilterOperator.NotEqual => "not_equal",
                TraceThreadFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => TraceThreadFilterOperator.Contains,
                "ends_with" => TraceThreadFilterOperator.EndsWith,
                "equal" => TraceThreadFilterOperator.Equal,
                "greater_or_equal" => TraceThreadFilterOperator.GreaterOrEqual,
                "greater_than" => TraceThreadFilterOperator.GreaterThan,
                "is_empty" => TraceThreadFilterOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterOperator.IsNotEmpty,
                "less_or_equal" => TraceThreadFilterOperator.LessOrEqual,
                "less_than" => TraceThreadFilterOperator.LessThan,
                "not_contains" => TraceThreadFilterOperator.NotContains,
                "not_equal" => TraceThreadFilterOperator.NotEqual,
                "starts_with" => TraceThreadFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}