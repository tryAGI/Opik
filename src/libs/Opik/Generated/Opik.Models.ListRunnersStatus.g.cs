
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRunnersStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
        /// <summary>
        /// 
        /// </summary>
        Disconnected,
        /// <summary>
        /// 
        /// </summary>
        Pairing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRunnersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRunnersStatus value)
        {
            return value switch
            {
                ListRunnersStatus.Connected => "connected",
                ListRunnersStatus.Disconnected => "disconnected",
                ListRunnersStatus.Pairing => "pairing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRunnersStatus? ToEnum(string value)
        {
            return value switch
            {
                "connected" => ListRunnersStatus.Connected,
                "disconnected" => ListRunnersStatus.Disconnected,
                "pairing" => ListRunnersStatus.Pairing,
                _ => null,
            };
        }
    }
}