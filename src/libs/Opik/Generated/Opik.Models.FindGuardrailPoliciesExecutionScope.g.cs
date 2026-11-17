
#nullable enable

namespace Opik
{
    /// <summary>
    /// Filter policies by execution scope
    /// </summary>
    public enum FindGuardrailPoliciesExecutionScope
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
    public static class FindGuardrailPoliciesExecutionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindGuardrailPoliciesExecutionScope value)
        {
            return value switch
            {
                FindGuardrailPoliciesExecutionScope.Global => "global",
                FindGuardrailPoliciesExecutionScope.OnRequest => "on_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindGuardrailPoliciesExecutionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => FindGuardrailPoliciesExecutionScope.Global,
                "on_request" => FindGuardrailPoliciesExecutionScope.OnRequest,
                _ => null,
            };
        }
    }
}