
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetItemFilterOperator
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
    public static class DatasetItemFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemFilterOperator value)
        {
            return value switch
            {
                DatasetItemFilterOperator.Contains => "contains",
                DatasetItemFilterOperator.EndsWith => "ends_with",
                DatasetItemFilterOperator.Eq => "eq",
                DatasetItemFilterOperator.Gt => "gt",
                DatasetItemFilterOperator.Gte => "gte",
                DatasetItemFilterOperator.IsEmpty => "is_empty",
                DatasetItemFilterOperator.IsNotEmpty => "is_not_empty",
                DatasetItemFilterOperator.Lt => "lt",
                DatasetItemFilterOperator.Lte => "lte",
                DatasetItemFilterOperator.Neq => "neq",
                DatasetItemFilterOperator.NotContains => "not_contains",
                DatasetItemFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => DatasetItemFilterOperator.Contains,
                "ends_with" => DatasetItemFilterOperator.EndsWith,
                "eq" => DatasetItemFilterOperator.Eq,
                "gt" => DatasetItemFilterOperator.Gt,
                "gte" => DatasetItemFilterOperator.Gte,
                "is_empty" => DatasetItemFilterOperator.IsEmpty,
                "is_not_empty" => DatasetItemFilterOperator.IsNotEmpty,
                "lt" => DatasetItemFilterOperator.Lt,
                "lte" => DatasetItemFilterOperator.Lte,
                "neq" => DatasetItemFilterOperator.Neq,
                "not_contains" => DatasetItemFilterOperator.NotContains,
                "starts_with" => DatasetItemFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}