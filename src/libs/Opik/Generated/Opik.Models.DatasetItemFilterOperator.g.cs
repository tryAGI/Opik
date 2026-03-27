
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
        Equal,
        /// <summary>
        /// 
        /// </summary>
        GreaterOrEqual,
        /// <summary>
        /// 
        /// </summary>
        GreaterThan,
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
        LessOrEqual,
        /// <summary>
        /// 
        /// </summary>
        LessThan,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        NotEqual,
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
                DatasetItemFilterOperator.Equal => "equal",
                DatasetItemFilterOperator.GreaterOrEqual => "greater_or_equal",
                DatasetItemFilterOperator.GreaterThan => "greater_than",
                DatasetItemFilterOperator.IsEmpty => "is_empty",
                DatasetItemFilterOperator.IsNotEmpty => "is_not_empty",
                DatasetItemFilterOperator.LessOrEqual => "less_or_equal",
                DatasetItemFilterOperator.LessThan => "less_than",
                DatasetItemFilterOperator.NotContains => "not_contains",
                DatasetItemFilterOperator.NotEqual => "not_equal",
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
                "equal" => DatasetItemFilterOperator.Equal,
                "greater_or_equal" => DatasetItemFilterOperator.GreaterOrEqual,
                "greater_than" => DatasetItemFilterOperator.GreaterThan,
                "is_empty" => DatasetItemFilterOperator.IsEmpty,
                "is_not_empty" => DatasetItemFilterOperator.IsNotEmpty,
                "less_or_equal" => DatasetItemFilterOperator.LessOrEqual,
                "less_than" => DatasetItemFilterOperator.LessThan,
                "not_contains" => DatasetItemFilterOperator.NotContains,
                "not_equal" => DatasetItemFilterOperator.NotEqual,
                "starts_with" => DatasetItemFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}