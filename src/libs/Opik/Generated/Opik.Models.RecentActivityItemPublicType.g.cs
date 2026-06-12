
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum RecentActivityItemPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        AlertEvent,
        /// <summary>
        /// 
        /// </summary>
        DatasetVersion,
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Optimization,
        /// <summary>
        /// 
        /// </summary>
        PromptVersion,
        /// <summary>
        /// 
        /// </summary>
        TestSuiteVersion,
        /// <summary>
        /// 
        /// </summary>
        TraceDaily,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecentActivityItemPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecentActivityItemPublicType value)
        {
            return value switch
            {
                RecentActivityItemPublicType.AlertEvent => "alert_event",
                RecentActivityItemPublicType.DatasetVersion => "dataset_version",
                RecentActivityItemPublicType.Experiment => "experiment",
                RecentActivityItemPublicType.Optimization => "optimization",
                RecentActivityItemPublicType.PromptVersion => "prompt_version",
                RecentActivityItemPublicType.TestSuiteVersion => "test_suite_version",
                RecentActivityItemPublicType.TraceDaily => "trace_daily",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecentActivityItemPublicType? ToEnum(string value)
        {
            return value switch
            {
                "alert_event" => RecentActivityItemPublicType.AlertEvent,
                "dataset_version" => RecentActivityItemPublicType.DatasetVersion,
                "experiment" => RecentActivityItemPublicType.Experiment,
                "optimization" => RecentActivityItemPublicType.Optimization,
                "prompt_version" => RecentActivityItemPublicType.PromptVersion,
                "test_suite_version" => RecentActivityItemPublicType.TestSuiteVersion,
                "trace_daily" => RecentActivityItemPublicType.TraceDaily,
                _ => null,
            };
        }
    }
}