
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSessionRequestType
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
    public static class CreateSessionRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSessionRequestType value)
        {
            return value switch
            {
                CreateSessionRequestType.Connect => "connect",
                CreateSessionRequestType.Endpoint => "endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSessionRequestType? ToEnum(string value)
        {
            return value switch
            {
                "connect" => CreateSessionRequestType.Connect,
                "endpoint" => CreateSessionRequestType.Endpoint,
                _ => null,
            };
        }
    }
}