
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceFilterOperator
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
    public static class TraceFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceFilterOperator value)
        {
            return value switch
            {
                TraceFilterOperator.Contains => "contains",
                TraceFilterOperator.EndsWith => "ends_with",
                TraceFilterOperator.Equal => "equal",
                TraceFilterOperator.GreaterOrEqual => "greater_or_equal",
                TraceFilterOperator.GreaterThan => "greater_than",
                TraceFilterOperator.IsEmpty => "is_empty",
                TraceFilterOperator.IsNotEmpty => "is_not_empty",
                TraceFilterOperator.LessOrEqual => "less_or_equal",
                TraceFilterOperator.LessThan => "less_than",
                TraceFilterOperator.NotContains => "not_contains",
                TraceFilterOperator.NotEqual => "not_equal",
                TraceFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => TraceFilterOperator.Contains,
                "ends_with" => TraceFilterOperator.EndsWith,
                "equal" => TraceFilterOperator.Equal,
                "greater_or_equal" => TraceFilterOperator.GreaterOrEqual,
                "greater_than" => TraceFilterOperator.GreaterThan,
                "is_empty" => TraceFilterOperator.IsEmpty,
                "is_not_empty" => TraceFilterOperator.IsNotEmpty,
                "less_or_equal" => TraceFilterOperator.LessOrEqual,
                "less_than" => TraceFilterOperator.LessThan,
                "not_contains" => TraceFilterOperator.NotContains,
                "not_equal" => TraceFilterOperator.NotEqual,
                "starts_with" => TraceFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}