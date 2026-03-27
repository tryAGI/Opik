
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterPublicOperator
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
    public static class SpanFilterPublicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterPublicOperator value)
        {
            return value switch
            {
                SpanFilterPublicOperator.Contains => "contains",
                SpanFilterPublicOperator.EndsWith => "ends_with",
                SpanFilterPublicOperator.Eq => "eq",
                SpanFilterPublicOperator.Gt => "gt",
                SpanFilterPublicOperator.Gte => "gte",
                SpanFilterPublicOperator.IsEmpty => "is_empty",
                SpanFilterPublicOperator.IsNotEmpty => "is_not_empty",
                SpanFilterPublicOperator.Lt => "lt",
                SpanFilterPublicOperator.Lte => "lte",
                SpanFilterPublicOperator.Neq => "neq",
                SpanFilterPublicOperator.NotContains => "not_contains",
                SpanFilterPublicOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterPublicOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => SpanFilterPublicOperator.Contains,
                "ends_with" => SpanFilterPublicOperator.EndsWith,
                "eq" => SpanFilterPublicOperator.Eq,
                "gt" => SpanFilterPublicOperator.Gt,
                "gte" => SpanFilterPublicOperator.Gte,
                "is_empty" => SpanFilterPublicOperator.IsEmpty,
                "is_not_empty" => SpanFilterPublicOperator.IsNotEmpty,
                "lt" => SpanFilterPublicOperator.Lt,
                "lte" => SpanFilterPublicOperator.Lte,
                "neq" => SpanFilterPublicOperator.Neq,
                "not_contains" => SpanFilterPublicOperator.NotContains,
                "starts_with" => SpanFilterPublicOperator.StartsWith,
                _ => null,
            };
        }
    }
}