
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterOperator
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
    public static class SpanFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterOperator value)
        {
            return value switch
            {
                SpanFilterOperator.Contains => "contains",
                SpanFilterOperator.EndsWith => "ends_with",
                SpanFilterOperator.Eq => "eq",
                SpanFilterOperator.Gt => "gt",
                SpanFilterOperator.Gte => "gte",
                SpanFilterOperator.IsEmpty => "is_empty",
                SpanFilterOperator.IsNotEmpty => "is_not_empty",
                SpanFilterOperator.Lt => "lt",
                SpanFilterOperator.Lte => "lte",
                SpanFilterOperator.Neq => "neq",
                SpanFilterOperator.NotContains => "not_contains",
                SpanFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => SpanFilterOperator.Contains,
                "ends_with" => SpanFilterOperator.EndsWith,
                "eq" => SpanFilterOperator.Eq,
                "gt" => SpanFilterOperator.Gt,
                "gte" => SpanFilterOperator.Gte,
                "is_empty" => SpanFilterOperator.IsEmpty,
                "is_not_empty" => SpanFilterOperator.IsNotEmpty,
                "lt" => SpanFilterOperator.Lt,
                "lte" => SpanFilterOperator.Lte,
                "neq" => SpanFilterOperator.Neq,
                "not_contains" => SpanFilterOperator.NotContains,
                "starts_with" => SpanFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}