
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum BridgeCommandSubmitRequestType
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
    public static class BridgeCommandSubmitRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeCommandSubmitRequestType value)
        {
            return value switch
            {
                BridgeCommandSubmitRequestType.EditFile => "EditFile",
                BridgeCommandSubmitRequestType.Exec => "Exec",
                BridgeCommandSubmitRequestType.ListFiles => "ListFiles",
                BridgeCommandSubmitRequestType.ReadFile => "ReadFile",
                BridgeCommandSubmitRequestType.SearchFiles => "SearchFiles",
                BridgeCommandSubmitRequestType.WriteFile => "WriteFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeCommandSubmitRequestType? ToEnum(string value)
        {
            return value switch
            {
                "EditFile" => BridgeCommandSubmitRequestType.EditFile,
                "Exec" => BridgeCommandSubmitRequestType.Exec,
                "ListFiles" => BridgeCommandSubmitRequestType.ListFiles,
                "ReadFile" => BridgeCommandSubmitRequestType.ReadFile,
                "SearchFiles" => BridgeCommandSubmitRequestType.SearchFiles,
                "WriteFile" => BridgeCommandSubmitRequestType.WriteFile,
                _ => null,
            };
        }
    }
}