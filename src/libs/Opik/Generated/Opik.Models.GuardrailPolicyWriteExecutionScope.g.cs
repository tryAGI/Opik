
#nullable enable

namespace Opik
{
    /// <summary>
    /// on_request applies the policy when the SDK names it, global applies it to every guardrail built from stored policies in the workspace. Missing or null means on_request<br/>
    /// Default Value: on_request
    /// </summary>
    public enum GuardrailPolicyWriteExecutionScope
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
    public static class GuardrailPolicyWriteExecutionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPolicyWriteExecutionScope value)
        {
            return value switch
            {
                GuardrailPolicyWriteExecutionScope.Global => "global",
                GuardrailPolicyWriteExecutionScope.OnRequest => "on_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPolicyWriteExecutionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => GuardrailPolicyWriteExecutionScope.Global,
                "on_request" => GuardrailPolicyWriteExecutionScope.OnRequest,
                _ => null,
            };
        }
    }
}