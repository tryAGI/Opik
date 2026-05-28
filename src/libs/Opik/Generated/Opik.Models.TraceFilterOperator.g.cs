
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
        Neq,
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
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        In,
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
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
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
                TraceFilterOperator.Neq => "!=",
                TraceFilterOperator.Lt => "<",
                TraceFilterOperator.Lte => "<=",
                TraceFilterOperator.Eq => "=",
                TraceFilterOperator.Gt => ">",
                TraceFilterOperator.Gte => ">=",
                TraceFilterOperator.Contains => "contains",
                TraceFilterOperator.EndsWith => "ends_with",
                TraceFilterOperator.In => "in",
                TraceFilterOperator.IsEmpty => "is_empty",
                TraceFilterOperator.IsNotEmpty => "is_not_empty",
                TraceFilterOperator.NotContains => "not_contains",
                TraceFilterOperator.NotIn => "not_in",
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
                "!=" => TraceFilterOperator.Neq,
                "<" => TraceFilterOperator.Lt,
                "<=" => TraceFilterOperator.Lte,
                "=" => TraceFilterOperator.Eq,
                ">" => TraceFilterOperator.Gt,
                ">=" => TraceFilterOperator.Gte,
                "contains" => TraceFilterOperator.Contains,
                "ends_with" => TraceFilterOperator.EndsWith,
                "in" => TraceFilterOperator.In,
                "is_empty" => TraceFilterOperator.IsEmpty,
                "is_not_empty" => TraceFilterOperator.IsNotEmpty,
                "not_contains" => TraceFilterOperator.NotContains,
                "not_in" => TraceFilterOperator.NotIn,
                "starts_with" => TraceFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}