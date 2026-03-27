
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceFilterPublicOperator
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
    public static class TraceFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceFilterPublicOperator value)
        {
            return value switch
            {
                TraceFilterPublicOperator.Contains => "contains",
                TraceFilterPublicOperator.EndsWith => "ends_with",
                TraceFilterPublicOperator.Eq => "eq",
                TraceFilterPublicOperator.Gt => "gt",
                TraceFilterPublicOperator.Gte => "gte",
                TraceFilterPublicOperator.IsEmpty => "is_empty",
                TraceFilterPublicOperator.IsNotEmpty => "is_not_empty",
                TraceFilterPublicOperator.Lt => "lt",
                TraceFilterPublicOperator.Lte => "lte",
                TraceFilterPublicOperator.Neq => "neq",
                TraceFilterPublicOperator.NotContains => "not_contains",
                TraceFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => TraceFilterPublicOperator.Contains,
                "ends_with" => TraceFilterPublicOperator.EndsWith,
                "eq" => TraceFilterPublicOperator.Eq,
                "gt" => TraceFilterPublicOperator.Gt,
                "gte" => TraceFilterPublicOperator.Gte,
                "is_empty" => TraceFilterPublicOperator.IsEmpty,
                "is_not_empty" => TraceFilterPublicOperator.IsNotEmpty,
                "lt" => TraceFilterPublicOperator.Lt,
                "lte" => TraceFilterPublicOperator.Lte,
                "neq" => TraceFilterPublicOperator.Neq,
                "not_contains" => TraceFilterPublicOperator.NotContains,
                "starts_with" => TraceFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}