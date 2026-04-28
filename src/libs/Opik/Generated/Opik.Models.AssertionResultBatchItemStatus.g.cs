
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssertionResultBatchItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Passed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssertionResultBatchItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssertionResultBatchItemStatus value)
        {
            return value switch
            {
                AssertionResultBatchItemStatus.Failed => "failed",
                AssertionResultBatchItemStatus.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssertionResultBatchItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AssertionResultBatchItemStatus.Failed,
                "passed" => AssertionResultBatchItemStatus.Passed,
                _ => null,
            };
        }
    }
}