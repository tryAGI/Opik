
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssertionResultBatchItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        OnlineScoring,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssertionResultBatchItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssertionResultBatchItemSource value)
        {
            return value switch
            {
                AssertionResultBatchItemSource.OnlineScoring => "online_scoring",
                AssertionResultBatchItemSource.Sdk => "sdk",
                AssertionResultBatchItemSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssertionResultBatchItemSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => AssertionResultBatchItemSource.OnlineScoring,
                "sdk" => AssertionResultBatchItemSource.Sdk,
                "ui" => AssertionResultBatchItemSource.Ui,
                _ => null,
            };
        }
    }
}