
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum BridgeCommandType
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
    public static class BridgeCommandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeCommandType value)
        {
            return value switch
            {
                BridgeCommandType.EditFile => "EditFile",
                BridgeCommandType.Exec => "Exec",
                BridgeCommandType.ListFiles => "ListFiles",
                BridgeCommandType.ReadFile => "ReadFile",
                BridgeCommandType.SearchFiles => "SearchFiles",
                BridgeCommandType.WriteFile => "WriteFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeCommandType? ToEnum(string value)
        {
            return value switch
            {
                "EditFile" => BridgeCommandType.EditFile,
                "Exec" => BridgeCommandType.Exec,
                "ListFiles" => BridgeCommandType.ListFiles,
                "ReadFile" => BridgeCommandType.ReadFile,
                "SearchFiles" => BridgeCommandType.SearchFiles,
                "WriteFile" => BridgeCommandType.WriteFile,
                _ => null,
            };
        }
    }
}