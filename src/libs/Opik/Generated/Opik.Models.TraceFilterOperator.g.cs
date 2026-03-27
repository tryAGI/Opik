
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
                TraceFilterOperator.Eq => "eq",
                TraceFilterOperator.Gt => "gt",
                TraceFilterOperator.Gte => "gte",
                TraceFilterOperator.IsEmpty => "is_empty",
                TraceFilterOperator.IsNotEmpty => "is_not_empty",
                TraceFilterOperator.Lt => "lt",
                TraceFilterOperator.Lte => "lte",
                TraceFilterOperator.Neq => "neq",
                TraceFilterOperator.NotContains => "not_contains",
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
                "eq" => TraceFilterOperator.Eq,
                "gt" => TraceFilterOperator.Gt,
                "gte" => TraceFilterOperator.Gte,
                "is_empty" => TraceFilterOperator.IsEmpty,
                "is_not_empty" => TraceFilterOperator.IsNotEmpty,
                "lt" => TraceFilterOperator.Lt,
                "lte" => TraceFilterOperator.Lte,
                "neq" => TraceFilterOperator.Neq,
                "not_contains" => TraceFilterOperator.NotContains,
                "starts_with" => TraceFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}