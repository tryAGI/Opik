
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanFilterWriteOperator
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
    public static class SpanFilterWriteOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanFilterWriteOperator value)
        {
            return value switch
            {
                SpanFilterWriteOperator.Contains => "contains",
                SpanFilterWriteOperator.EndsWith => "ends_with",
                SpanFilterWriteOperator.Eq => "eq",
                SpanFilterWriteOperator.Gt => "gt",
                SpanFilterWriteOperator.Gte => "gte",
                SpanFilterWriteOperator.IsEmpty => "is_empty",
                SpanFilterWriteOperator.IsNotEmpty => "is_not_empty",
                SpanFilterWriteOperator.Lt => "lt",
                SpanFilterWriteOperator.Lte => "lte",
                SpanFilterWriteOperator.Neq => "neq",
                SpanFilterWriteOperator.NotContains => "not_contains",
                SpanFilterWriteOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanFilterWriteOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => SpanFilterWriteOperator.Contains,
                "ends_with" => SpanFilterWriteOperator.EndsWith,
                "eq" => SpanFilterWriteOperator.Eq,
                "gt" => SpanFilterWriteOperator.Gt,
                "gte" => SpanFilterWriteOperator.Gte,
                "is_empty" => SpanFilterWriteOperator.IsEmpty,
                "is_not_empty" => SpanFilterWriteOperator.IsNotEmpty,
                "lt" => SpanFilterWriteOperator.Lt,
                "lte" => SpanFilterWriteOperator.Lte,
                "neq" => SpanFilterWriteOperator.Neq,
                "not_contains" => SpanFilterWriteOperator.NotContains,
                "starts_with" => SpanFilterWriteOperator.StartsWith,
                _ => null,
            };
        }
    }
}