
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterWriteOperator
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
    public static class SpanFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterWriteOperator value)
        {
            return value switch
            {
                SpanFilterWriteOperator.Contains => "contains",
                SpanFilterWriteOperator.EndsWith => "ends_with",
                SpanFilterWriteOperator.Equal => "equal",
                SpanFilterWriteOperator.GreaterOrEqual => "greater_or_equal",
                SpanFilterWriteOperator.GreaterThan => "greater_than",
                SpanFilterWriteOperator.IsEmpty => "is_empty",
                SpanFilterWriteOperator.IsNotEmpty => "is_not_empty",
                SpanFilterWriteOperator.LessOrEqual => "less_or_equal",
                SpanFilterWriteOperator.LessThan => "less_than",
                SpanFilterWriteOperator.NotContains => "not_contains",
                SpanFilterWriteOperator.NotEqual => "not_equal",
                SpanFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => SpanFilterWriteOperator.Contains,
                "ends_with" => SpanFilterWriteOperator.EndsWith,
                "equal" => SpanFilterWriteOperator.Equal,
                "greater_or_equal" => SpanFilterWriteOperator.GreaterOrEqual,
                "greater_than" => SpanFilterWriteOperator.GreaterThan,
                "is_empty" => SpanFilterWriteOperator.IsEmpty,
                "is_not_empty" => SpanFilterWriteOperator.IsNotEmpty,
                "less_or_equal" => SpanFilterWriteOperator.LessOrEqual,
                "less_than" => SpanFilterWriteOperator.LessThan,
                "not_contains" => SpanFilterWriteOperator.NotContains,
                "not_equal" => SpanFilterWriteOperator.NotEqual,
                "starts_with" => SpanFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}