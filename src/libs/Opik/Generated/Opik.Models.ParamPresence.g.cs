
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParamPresence
    {
        /// <summary>
        /// 
        /// </summary>
        Optional,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParamPresenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParamPresence value)
        {
            return value switch
            {
                ParamPresence.Optional => "optional",
                ParamPresence.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParamPresence? ToEnum(string value)
        {
            return value switch
            {
                "optional" => ParamPresence.Optional,
                "required" => ParamPresence.Required,
                _ => null,
            };
        }
    }
}