
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadFilterWriteOperator
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
    public static class TraceThreadFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterWriteOperator value)
        {
            return value switch
            {
                TraceThreadFilterWriteOperator.Contains => "contains",
                TraceThreadFilterWriteOperator.EndsWith => "ends_with",
                TraceThreadFilterWriteOperator.Equal => "equal",
                TraceThreadFilterWriteOperator.GreaterOrEqual => "greater_or_equal",
                TraceThreadFilterWriteOperator.GreaterThan => "greater_than",
                TraceThreadFilterWriteOperator.IsEmpty => "is_empty",
                TraceThreadFilterWriteOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterWriteOperator.LessOrEqual => "less_or_equal",
                TraceThreadFilterWriteOperator.LessThan => "less_than",
                TraceThreadFilterWriteOperator.NotContains => "not_contains",
                TraceThreadFilterWriteOperator.NotEqual => "not_equal",
                TraceThreadFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => TraceThreadFilterWriteOperator.Contains,
                "ends_with" => TraceThreadFilterWriteOperator.EndsWith,
                "equal" => TraceThreadFilterWriteOperator.Equal,
                "greater_or_equal" => TraceThreadFilterWriteOperator.GreaterOrEqual,
                "greater_than" => TraceThreadFilterWriteOperator.GreaterThan,
                "is_empty" => TraceThreadFilterWriteOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterWriteOperator.IsNotEmpty,
                "less_or_equal" => TraceThreadFilterWriteOperator.LessOrEqual,
                "less_than" => TraceThreadFilterWriteOperator.LessThan,
                "not_contains" => TraceThreadFilterWriteOperator.NotContains,
                "not_equal" => TraceThreadFilterWriteOperator.NotEqual,
                "starts_with" => TraceThreadFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}