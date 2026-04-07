
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum BridgeCommandItemType
    {
        /// <summary>
        /// 
        /// </summary>
        EditFile,
        /// <summary>
        /// 
        /// </summary>
        Exec,
        /// <summary>
        /// 
        /// </summary>
        ListFiles,
        /// <summary>
        /// 
        /// </summary>
        ReadFile,
        /// <summary>
        /// 
        /// </summary>
        SearchFiles,
        /// <summary>
        /// 
        /// </summary>
        WriteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BridgeCommandItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeCommandItemType value)
        {
            return value switch
            {
                BridgeCommandItemType.EditFile => "EditFile",
                BridgeCommandItemType.Exec => "Exec",
                BridgeCommandItemType.ListFiles => "ListFiles",
                BridgeCommandItemType.ReadFile => "ReadFile",
                BridgeCommandItemType.SearchFiles => "SearchFiles",
                BridgeCommandItemType.WriteFile => "WriteFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeCommandItemType? ToEnum(string value)
        {
            return value switch
            {
                "EditFile" => BridgeCommandItemType.EditFile,
                "Exec" => BridgeCommandItemType.Exec,
                "ListFiles" => BridgeCommandItemType.ListFiles,
                "ReadFile" => BridgeCommandItemType.ReadFile,
                "SearchFiles" => BridgeCommandItemType.SearchFiles,
                "WriteFile" => BridgeCommandItemType.WriteFile,
                _ => null,
            };
        }
    }
}