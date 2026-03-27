
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterPublicOperator
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
    public static class SpanFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterPublicOperator value)
        {
            return value switch
            {
                SpanFilterPublicOperator.Contains => "contains",
                SpanFilterPublicOperator.EndsWith => "ends_with",
                SpanFilterPublicOperator.Equal => "equal",
                SpanFilterPublicOperator.GreaterOrEqual => "greater_or_equal",
                SpanFilterPublicOperator.GreaterThan => "greater_than",
                SpanFilterPublicOperator.IsEmpty => "is_empty",
                SpanFilterPublicOperator.IsNotEmpty => "is_not_empty",
                SpanFilterPublicOperator.LessOrEqual => "less_or_equal",
                SpanFilterPublicOperator.LessThan => "less_than",
                SpanFilterPublicOperator.NotContains => "not_contains",
                SpanFilterPublicOperator.NotEqual => "not_equal",
                SpanFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => SpanFilterPublicOperator.Contains,
                "ends_with" => SpanFilterPublicOperator.EndsWith,
                "equal" => SpanFilterPublicOperator.Equal,
                "greater_or_equal" => SpanFilterPublicOperator.GreaterOrEqual,
                "greater_than" => SpanFilterPublicOperator.GreaterThan,
                "is_empty" => SpanFilterPublicOperator.IsEmpty,
                "is_not_empty" => SpanFilterPublicOperator.IsNotEmpty,
                "less_or_equal" => SpanFilterPublicOperator.LessOrEqual,
                "less_than" => SpanFilterPublicOperator.LessThan,
                "not_contains" => SpanFilterPublicOperator.NotContains,
                "not_equal" => SpanFilterPublicOperator.NotEqual,
                "starts_with" => SpanFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}