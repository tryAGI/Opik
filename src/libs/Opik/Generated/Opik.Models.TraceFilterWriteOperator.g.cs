
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
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
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
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
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
                TraceFilterWriteOperator.Eq => "eq",
                TraceFilterWriteOperator.Gt => "gt",
                TraceFilterWriteOperator.Gte => "gte",
                TraceFilterWriteOperator.IsEmpty => "is_empty",
                TraceFilterWriteOperator.IsNotEmpty => "is_not_empty",
                TraceFilterWriteOperator.Lt => "lt",
                TraceFilterWriteOperator.Lte => "lte",
                TraceFilterWriteOperator.Neq => "neq",
                TraceFilterWriteOperator.NotContains => "not_contains",
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
                "eq" => TraceFilterWriteOperator.Eq,
                "gt" => TraceFilterWriteOperator.Gt,
                "gte" => TraceFilterWriteOperator.Gte,
                "is_empty" => TraceFilterWriteOperator.IsEmpty,
                "is_not_empty" => TraceFilterWriteOperator.IsNotEmpty,
                "lt" => TraceFilterWriteOperator.Lt,
                "lte" => TraceFilterWriteOperator.Lte,
                "neq" => TraceFilterWriteOperator.Neq,
                "not_contains" => TraceFilterWriteOperator.NotContains,
                "starts_with" => TraceFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}