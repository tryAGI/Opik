
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
                TraceThreadFilterOperator.Eq => "eq",
                TraceThreadFilterOperator.Gt => "gt",
                TraceThreadFilterOperator.Gte => "gte",
                TraceThreadFilterOperator.IsEmpty => "is_empty",
                TraceThreadFilterOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterOperator.Lt => "lt",
                TraceThreadFilterOperator.Lte => "lte",
                TraceThreadFilterOperator.Neq => "neq",
                TraceThreadFilterOperator.NotContains => "not_contains",
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
                "eq" => TraceThreadFilterOperator.Eq,
                "gt" => TraceThreadFilterOperator.Gt,
                "gte" => TraceThreadFilterOperator.Gte,
                "is_empty" => TraceThreadFilterOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterOperator.IsNotEmpty,
                "lt" => TraceThreadFilterOperator.Lt,
                "lte" => TraceThreadFilterOperator.Lte,
                "neq" => TraceThreadFilterOperator.Neq,
                "not_contains" => TraceThreadFilterOperator.NotContains,
                "starts_with" => TraceThreadFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}