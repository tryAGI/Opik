
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalRunnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Connect,
        /// <summary>
        /// 
        /// </summary>
        Endpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalRunnerType value)
        {
            return value switch
            {
                LocalRunnerType.Connect => "connect",
                LocalRunnerType.Endpoint => "endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "connect" => LocalRunnerType.Connect,
                "endpoint" => LocalRunnerType.Endpoint,
                _ => null,
            };
        }
    }
}