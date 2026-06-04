
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetItemsFromJsonRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Jsonl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDatasetItemsFromJsonRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetItemsFromJsonRequestFormat value)
        {
            return value switch
            {
                CreateDatasetItemsFromJsonRequestFormat.Json => "json",
                CreateDatasetItemsFromJsonRequestFormat.Jsonl => "jsonl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetItemsFromJsonRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateDatasetItemsFromJsonRequestFormat.Json,
                "jsonl" => CreateDatasetItemsFromJsonRequestFormat.Jsonl,
                _ => null,
            };
        }
    }
}