
#nullable enable

namespace Opik
{
    /// <summary>
    /// How credentials are sent: form body (default), JSON body, or basic auth (id/secret in an HTTP Basic header, remaining fields in the form body)
    /// </summary>
    public enum ProviderAuthConfigPublicSendAs
    {
        /// <summary>
        /// form body (default), JSON body, or basic auth (id/secret in an HTTP Basic header, remaining fields in the form body)
        /// </summary>
        Basic,
        /// <summary>
        /// form body (default), JSON body, or basic auth (id/secret in an HTTP Basic header, remaining fields in the form body)
        /// </summary>
        Form,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderAuthConfigPublicSendAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderAuthConfigPublicSendAs value)
        {
            return value switch
            {
                ProviderAuthConfigPublicSendAs.Basic => "basic",
                ProviderAuthConfigPublicSendAs.Form => "form",
                ProviderAuthConfigPublicSendAs.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderAuthConfigPublicSendAs? ToEnum(string value)
        {
            return value switch
            {
                "basic" => ProviderAuthConfigPublicSendAs.Basic,
                "form" => ProviderAuthConfigPublicSendAs.Form,
                "json" => ProviderAuthConfigPublicSendAs.Json,
                _ => null,
            };
        }
    }
}