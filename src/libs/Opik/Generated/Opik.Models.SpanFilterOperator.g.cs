
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterOperator
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
    public static class SpanFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterOperator value)
        {
            return value switch
            {
                SpanFilterOperator.Contains => "contains",
                SpanFilterOperator.EndsWith => "ends_with",
                SpanFilterOperator.Equal => "equal",
                SpanFilterOperator.GreaterOrEqual => "greater_or_equal",
                SpanFilterOperator.GreaterThan => "greater_than",
                SpanFilterOperator.IsEmpty => "is_empty",
                SpanFilterOperator.IsNotEmpty => "is_not_empty",
                SpanFilterOperator.LessOrEqual => "less_or_equal",
                SpanFilterOperator.LessThan => "less_than",
                SpanFilterOperator.NotContains => "not_contains",
                SpanFilterOperator.NotEqual => "not_equal",
                SpanFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => SpanFilterOperator.Contains,
                "ends_with" => SpanFilterOperator.EndsWith,
                "equal" => SpanFilterOperator.Equal,
                "greater_or_equal" => SpanFilterOperator.GreaterOrEqual,
                "greater_than" => SpanFilterOperator.GreaterThan,
                "is_empty" => SpanFilterOperator.IsEmpty,
                "is_not_empty" => SpanFilterOperator.IsNotEmpty,
                "less_or_equal" => SpanFilterOperator.LessOrEqual,
                "less_than" => SpanFilterOperator.LessThan,
                "not_contains" => SpanFilterOperator.NotContains,
                "not_equal" => SpanFilterOperator.NotEqual,
                "starts_with" => SpanFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}