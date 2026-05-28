
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadFilterPublicOperator
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
    public static class TraceThreadFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterPublicOperator value)
        {
            return value switch
            {
                TraceThreadFilterPublicOperator.Neq => "!=",
                TraceThreadFilterPublicOperator.Lt => "<",
                TraceThreadFilterPublicOperator.Lte => "<=",
                TraceThreadFilterPublicOperator.Eq => "=",
                TraceThreadFilterPublicOperator.Gt => ">",
                TraceThreadFilterPublicOperator.Gte => ">=",
                TraceThreadFilterPublicOperator.Contains => "contains",
                TraceThreadFilterPublicOperator.EndsWith => "ends_with",
                TraceThreadFilterPublicOperator.In => "in",
                TraceThreadFilterPublicOperator.IsEmpty => "is_empty",
                TraceThreadFilterPublicOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterPublicOperator.NotContains => "not_contains",
                TraceThreadFilterPublicOperator.NotIn => "not_in",
                TraceThreadFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => TraceThreadFilterPublicOperator.Neq,
                "<" => TraceThreadFilterPublicOperator.Lt,
                "<=" => TraceThreadFilterPublicOperator.Lte,
                "=" => TraceThreadFilterPublicOperator.Eq,
                ">" => TraceThreadFilterPublicOperator.Gt,
                ">=" => TraceThreadFilterPublicOperator.Gte,
                "contains" => TraceThreadFilterPublicOperator.Contains,
                "ends_with" => TraceThreadFilterPublicOperator.EndsWith,
                "in" => TraceThreadFilterPublicOperator.In,
                "is_empty" => TraceThreadFilterPublicOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterPublicOperator.IsNotEmpty,
                "not_contains" => TraceThreadFilterPublicOperator.NotContains,
                "not_in" => TraceThreadFilterPublicOperator.NotIn,
                "starts_with" => TraceThreadFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}