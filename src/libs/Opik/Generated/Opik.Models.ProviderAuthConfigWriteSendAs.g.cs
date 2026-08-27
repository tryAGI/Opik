
#nullable enable

namespace Opik
{
    /// <summary>
    /// How credentials are sent: form body (default), JSON body, or basic auth (id/secret in an HTTP Basic header, remaining fields in the form body)
    /// </summary>
    public enum ProviderAuthConfigWriteSendAs
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
    public static class ProviderAuthConfigWriteSendAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderAuthConfigWriteSendAs value)
        {
            return value switch
            {
                ProviderAuthConfigWriteSendAs.Basic => "basic",
                ProviderAuthConfigWriteSendAs.Form => "form",
                ProviderAuthConfigWriteSendAs.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderAuthConfigWriteSendAs? ToEnum(string value)
        {
            return value switch
            {
                "basic" => ProviderAuthConfigWriteSendAs.Basic,
                "form" => ProviderAuthConfigWriteSendAs.Form,
                "json" => ProviderAuthConfigWriteSendAs.Json,
                _ => null,
            };
        }
    }
}