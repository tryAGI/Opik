
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
    public static class TraceThreadFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadFilterPublicOperator value)
        {
            return value switch
            {
                TraceThreadFilterPublicOperator.Contains => "contains",
                TraceThreadFilterPublicOperator.EndsWith => "ends_with",
                TraceThreadFilterPublicOperator.Eq => "eq",
                TraceThreadFilterPublicOperator.Gt => "gt",
                TraceThreadFilterPublicOperator.Gte => "gte",
                TraceThreadFilterPublicOperator.IsEmpty => "is_empty",
                TraceThreadFilterPublicOperator.IsNotEmpty => "is_not_empty",
                TraceThreadFilterPublicOperator.Lt => "lt",
                TraceThreadFilterPublicOperator.Lte => "lte",
                TraceThreadFilterPublicOperator.Neq => "neq",
                TraceThreadFilterPublicOperator.NotContains => "not_contains",
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
                "contains" => TraceThreadFilterPublicOperator.Contains,
                "ends_with" => TraceThreadFilterPublicOperator.EndsWith,
                "eq" => TraceThreadFilterPublicOperator.Eq,
                "gt" => TraceThreadFilterPublicOperator.Gt,
                "gte" => TraceThreadFilterPublicOperator.Gte,
                "is_empty" => TraceThreadFilterPublicOperator.IsEmpty,
                "is_not_empty" => TraceThreadFilterPublicOperator.IsNotEmpty,
                "lt" => TraceThreadFilterPublicOperator.Lt,
                "lte" => TraceThreadFilterPublicOperator.Lte,
                "neq" => TraceThreadFilterPublicOperator.Neq,
                "not_contains" => TraceThreadFilterPublicOperator.NotContains,
                "starts_with" => TraceThreadFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}