
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
                TraceThreadFilterWriteOperator.Eq => "eq",
                TraceThreadFilterWriteOperator.Gt => "gt",
                TraceThreadFilterWriteOperator.Gte => "gte",
                TraceThreadFilterWriteOperator.IsEmpty => "is_empty",
                TraceThreadFilterWriteOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterWriteOperator.Lt => "lt",
                TraceThreadFilterWriteOperator.Lte => "lte",
                TraceThreadFilterWriteOperator.Neq => "neq",
                TraceThreadFilterWriteOperator.NotContains => "not_contains",
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
                "eq" => TraceThreadFilterWriteOperator.Eq,
                "gt" => TraceThreadFilterWriteOperator.Gt,
                "gte" => TraceThreadFilterWriteOperator.Gte,
                "is_empty" => TraceThreadFilterWriteOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterWriteOperator.IsNotEmpty,
                "lt" => TraceThreadFilterWriteOperator.Lt,
                "lte" => TraceThreadFilterWriteOperator.Lte,
                "neq" => TraceThreadFilterWriteOperator.Neq,
                "not_contains" => TraceThreadFilterWriteOperator.NotContains,
                "starts_with" => TraceThreadFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}