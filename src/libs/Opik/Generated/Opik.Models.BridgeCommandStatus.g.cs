
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum BridgeCommandStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        PickedUp,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BridgeCommandStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeCommandStatus value)
        {
            return value switch
            {
                BridgeCommandStatus.Completed => "completed",
                BridgeCommandStatus.Failed => "failed",
                BridgeCommandStatus.Pending => "pending",
                BridgeCommandStatus.PickedUp => "picked_up",
                BridgeCommandStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeCommandStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BridgeCommandStatus.Completed,
                "failed" => BridgeCommandStatus.Failed,
                "pending" => BridgeCommandStatus.Pending,
                "picked_up" => BridgeCommandStatus.PickedUp,
                "timed_out" => BridgeCommandStatus.TimedOut,
                _ => null,
            };
        }
    }
}