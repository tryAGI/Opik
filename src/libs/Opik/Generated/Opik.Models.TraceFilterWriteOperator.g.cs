
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceFilterWriteOperator
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
    public static class TraceFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceFilterWriteOperator value)
        {
            return value switch
            {
                TraceFilterWriteOperator.Contains => "contains",
                TraceFilterWriteOperator.EndsWith => "ends_with",
                TraceFilterWriteOperator.Equal => "equal",
                TraceFilterWriteOperator.GreaterOrEqual => "greater_or_equal",
                TraceFilterWriteOperator.GreaterThan => "greater_than",
                TraceFilterWriteOperator.IsEmpty => "is_empty",
                TraceFilterWriteOperator.IsNotEmpty => "is_not_empty",
                TraceFilterWriteOperator.LessOrEqual => "less_or_equal",
                TraceFilterWriteOperator.LessThan => "less_than",
                TraceFilterWriteOperator.NotContains => "not_contains",
                TraceFilterWriteOperator.NotEqual => "not_equal",
                TraceFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => TraceFilterWriteOperator.Contains,
                "ends_with" => TraceFilterWriteOperator.EndsWith,
                "equal" => TraceFilterWriteOperator.Equal,
                "greater_or_equal" => TraceFilterWriteOperator.GreaterOrEqual,
                "greater_than" => TraceFilterWriteOperator.GreaterThan,
                "is_empty" => TraceFilterWriteOperator.IsEmpty,
                "is_not_empty" => TraceFilterWriteOperator.IsNotEmpty,
                "less_or_equal" => TraceFilterWriteOperator.LessOrEqual,
                "less_than" => TraceFilterWriteOperator.LessThan,
                "not_contains" => TraceFilterWriteOperator.NotContains,
                "not_equal" => TraceFilterWriteOperator.NotEqual,
                "starts_with" => TraceFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}