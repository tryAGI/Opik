
#nullable enable

namespace Opik
{
    /// <summary>
    /// on_request applies the policy when the SDK names it, global applies it to every guardrail built from stored policies in the workspace. Missing or null means on_request<br/>
    /// Default Value: on_request
    /// </summary>
    public enum GuardrailPolicyPublicExecutionScope
    {
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        OnRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailPolicyPublicExecutionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPolicyPublicExecutionScope value)
        {
            return value switch
            {
                GuardrailPolicyPublicExecutionScope.Global => "global",
                GuardrailPolicyPublicExecutionScope.OnRequest => "on_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPolicyPublicExecutionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => GuardrailPolicyPublicExecutionScope.Global,
                "on_request" => GuardrailPolicyPublicExecutionScope.OnRequest,
                _ => null,
            };
        }
    }
}