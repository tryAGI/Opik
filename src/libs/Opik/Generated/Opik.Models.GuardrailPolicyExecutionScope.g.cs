
#nullable enable

namespace Opik
{
    /// <summary>
    /// on_request applies the policy when the SDK names it, global applies it to every guardrail built from stored policies in the workspace. Missing or null means on_request<br/>
    /// Default Value: on_request
    /// </summary>
    public enum GuardrailPolicyExecutionScope
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
    public static class GuardrailPolicyExecutionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPolicyExecutionScope value)
        {
            return value switch
            {
                GuardrailPolicyExecutionScope.Global => "global",
                GuardrailPolicyExecutionScope.OnRequest => "on_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPolicyExecutionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => GuardrailPolicyExecutionScope.Global,
                "on_request" => GuardrailPolicyExecutionScope.OnRequest,
                _ => null,
            };
        }
    }
}