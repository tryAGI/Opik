
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum BreakdownConfigField
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorInfo,
        /// <summary>
        /// 
        /// </summary>
        ErrorType,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Provider,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BreakdownConfigFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BreakdownConfigField value)
        {
            return value switch
            {
                BreakdownConfigField.ErrorInfo => "error_info",
                BreakdownConfigField.ErrorType => "error_type",
                BreakdownConfigField.Metadata => "metadata",
                BreakdownConfigField.Model => "model",
                BreakdownConfigField.Name => "name",
                BreakdownConfigField.None => "none",
                BreakdownConfigField.Provider => "provider",
                BreakdownConfigField.Tags => "tags",
                BreakdownConfigField.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BreakdownConfigField? ToEnum(string value)
        {
            return value switch
            {
                "error_info" => BreakdownConfigField.ErrorInfo,
                "error_type" => BreakdownConfigField.ErrorType,
                "metadata" => BreakdownConfigField.Metadata,
                "model" => BreakdownConfigField.Model,
                "name" => BreakdownConfigField.Name,
                "none" => BreakdownConfigField.None,
                "provider" => BreakdownConfigField.Provider,
                "tags" => BreakdownConfigField.Tags,
                "type" => BreakdownConfigField.Type,
                _ => null,
            };
        }
    }
}