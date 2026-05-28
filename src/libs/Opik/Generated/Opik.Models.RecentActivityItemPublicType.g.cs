
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
        AgentConfigVersion,
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
        TestSuiteVersion,
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
                RecentActivityItemPublicType.AgentConfigVersion => "agent_config_version",
                RecentActivityItemPublicType.AlertEvent => "alert_event",
                RecentActivityItemPublicType.DatasetVersion => "dataset_version",
                RecentActivityItemPublicType.Experiment => "experiment",
                RecentActivityItemPublicType.Optimization => "optimization",
                RecentActivityItemPublicType.TestSuiteVersion => "test_suite_version",
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
                "agent_config_version" => RecentActivityItemPublicType.AgentConfigVersion,
                "alert_event" => RecentActivityItemPublicType.AlertEvent,
                "dataset_version" => RecentActivityItemPublicType.DatasetVersion,
                "experiment" => RecentActivityItemPublicType.Experiment,
                "optimization" => RecentActivityItemPublicType.Optimization,
                "test_suite_version" => RecentActivityItemPublicType.TestSuiteVersion,
                _ => null,
            };
        }
    }
}