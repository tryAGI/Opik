
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
    public static class SpanFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterOperator value)
        {
            return value switch
            {
                SpanFilterOperator.Neq => "!=",
                SpanFilterOperator.Lt => "<",
                SpanFilterOperator.Lte => "<=",
                SpanFilterOperator.Eq => "=",
                SpanFilterOperator.Gt => ">",
                SpanFilterOperator.Gte => ">=",
                SpanFilterOperator.Contains => "contains",
                SpanFilterOperator.EndsWith => "ends_with",
                SpanFilterOperator.In => "in",
                SpanFilterOperator.IsEmpty => "is_empty",
                SpanFilterOperator.IsNotEmpty => "is_not_empty",
                SpanFilterOperator.NotContains => "not_contains",
                SpanFilterOperator.NotIn => "not_in",
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
                "!=" => SpanFilterOperator.Neq,
                "<" => SpanFilterOperator.Lt,
                "<=" => SpanFilterOperator.Lte,
                "=" => SpanFilterOperator.Eq,
                ">" => SpanFilterOperator.Gt,
                ">=" => SpanFilterOperator.Gte,
                "contains" => SpanFilterOperator.Contains,
                "ends_with" => SpanFilterOperator.EndsWith,
                "in" => SpanFilterOperator.In,
                "is_empty" => SpanFilterOperator.IsEmpty,
                "is_not_empty" => SpanFilterOperator.IsNotEmpty,
                "not_contains" => SpanFilterOperator.NotContains,
                "not_in" => SpanFilterOperator.NotIn,
                "starts_with" => SpanFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}