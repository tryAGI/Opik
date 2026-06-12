
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemImpact
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemImpactExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemImpact value)
        {
            return value switch
            {
                ItemImpact.High => "high",
                ItemImpact.Low => "low",
                ItemImpact.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemImpact? ToEnum(string value)
        {
            return value switch
            {
                "high" => ItemImpact.High,
                "low" => ItemImpact.Low,
                "medium" => ItemImpact.Medium,
                _ => null,
            };
        }
    }
}