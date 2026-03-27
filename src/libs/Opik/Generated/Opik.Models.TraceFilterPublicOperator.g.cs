
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceFilterPublicOperator
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
    public static class TraceFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceFilterPublicOperator value)
        {
            return value switch
            {
                TraceFilterPublicOperator.Contains => "contains",
                TraceFilterPublicOperator.EndsWith => "ends_with",
                TraceFilterPublicOperator.Equal => "equal",
                TraceFilterPublicOperator.GreaterOrEqual => "greater_or_equal",
                TraceFilterPublicOperator.GreaterThan => "greater_than",
                TraceFilterPublicOperator.IsEmpty => "is_empty",
                TraceFilterPublicOperator.IsNotEmpty => "is_not_empty",
                TraceFilterPublicOperator.LessOrEqual => "less_or_equal",
                TraceFilterPublicOperator.LessThan => "less_than",
                TraceFilterPublicOperator.NotContains => "not_contains",
                TraceFilterPublicOperator.NotEqual => "not_equal",
                TraceFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => TraceFilterPublicOperator.Contains,
                "ends_with" => TraceFilterPublicOperator.EndsWith,
                "equal" => TraceFilterPublicOperator.Equal,
                "greater_or_equal" => TraceFilterPublicOperator.GreaterOrEqual,
                "greater_than" => TraceFilterPublicOperator.GreaterThan,
                "is_empty" => TraceFilterPublicOperator.IsEmpty,
                "is_not_empty" => TraceFilterPublicOperator.IsNotEmpty,
                "less_or_equal" => TraceFilterPublicOperator.LessOrEqual,
                "less_than" => TraceFilterPublicOperator.LessThan,
                "not_contains" => TraceFilterPublicOperator.NotContains,
                "not_equal" => TraceFilterPublicOperator.NotEqual,
                "starts_with" => TraceFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}