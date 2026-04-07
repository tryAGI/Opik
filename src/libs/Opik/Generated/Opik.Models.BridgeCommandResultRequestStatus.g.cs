
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum BridgeCommandResultRequestStatus
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
    public static class BridgeCommandResultRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeCommandResultRequestStatus value)
        {
            return value switch
            {
                BridgeCommandResultRequestStatus.Completed => "completed",
                BridgeCommandResultRequestStatus.Failed => "failed",
                BridgeCommandResultRequestStatus.Pending => "pending",
                BridgeCommandResultRequestStatus.PickedUp => "picked_up",
                BridgeCommandResultRequestStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeCommandResultRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BridgeCommandResultRequestStatus.Completed,
                "failed" => BridgeCommandResultRequestStatus.Failed,
                "pending" => BridgeCommandResultRequestStatus.Pending,
                "picked_up" => BridgeCommandResultRequestStatus.PickedUp,
                "timed_out" => BridgeCommandResultRequestStatus.TimedOut,
                _ => null,
            };
        }
    }
}