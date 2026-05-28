
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
    public static class TraceThreadFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterOperator value)
        {
            return value switch
            {
                TraceThreadFilterOperator.Neq => "!=",
                TraceThreadFilterOperator.Lt => "<",
                TraceThreadFilterOperator.Lte => "<=",
                TraceThreadFilterOperator.Eq => "=",
                TraceThreadFilterOperator.Gt => ">",
                TraceThreadFilterOperator.Gte => ">=",
                TraceThreadFilterOperator.Contains => "contains",
                TraceThreadFilterOperator.EndsWith => "ends_with",
                TraceThreadFilterOperator.In => "in",
                TraceThreadFilterOperator.IsEmpty => "is_empty",
                TraceThreadFilterOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterOperator.NotContains => "not_contains",
                TraceThreadFilterOperator.NotIn => "not_in",
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
                "!=" => TraceThreadFilterOperator.Neq,
                "<" => TraceThreadFilterOperator.Lt,
                "<=" => TraceThreadFilterOperator.Lte,
                "=" => TraceThreadFilterOperator.Eq,
                ">" => TraceThreadFilterOperator.Gt,
                ">=" => TraceThreadFilterOperator.Gte,
                "contains" => TraceThreadFilterOperator.Contains,
                "ends_with" => TraceThreadFilterOperator.EndsWith,
                "in" => TraceThreadFilterOperator.In,
                "is_empty" => TraceThreadFilterOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterOperator.IsNotEmpty,
                "not_contains" => TraceThreadFilterOperator.NotContains,
                "not_in" => TraceThreadFilterOperator.NotIn,
                "starts_with" => TraceThreadFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}