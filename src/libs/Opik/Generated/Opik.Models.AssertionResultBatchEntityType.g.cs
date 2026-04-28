
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssertionResultBatchEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
        Thread,
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssertionResultBatchEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssertionResultBatchEntityType value)
        {
            return value switch
            {
                AssertionResultBatchEntityType.Span => "SPAN",
                AssertionResultBatchEntityType.Thread => "THREAD",
                AssertionResultBatchEntityType.Trace => "TRACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssertionResultBatchEntityType? ToEnum(string value)
        {
            return value switch
            {
                "SPAN" => AssertionResultBatchEntityType.Span,
                "THREAD" => AssertionResultBatchEntityType.Thread,
                "TRACE" => AssertionResultBatchEntityType.Trace,
                _ => null,
            };
        }
    }
}