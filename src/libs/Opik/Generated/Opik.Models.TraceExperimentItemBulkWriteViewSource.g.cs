
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceExperimentItemBulkWriteViewSource
    {
        /// <summary>
        /// 
        /// </summary>
        Evaluator,
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
        Playground,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceExperimentItemBulkWriteViewSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceExperimentItemBulkWriteViewSource value)
        {
            return value switch
            {
                TraceExperimentItemBulkWriteViewSource.Evaluator => "evaluator",
                TraceExperimentItemBulkWriteViewSource.Experiment => "experiment",
                TraceExperimentItemBulkWriteViewSource.Optimization => "optimization",
                TraceExperimentItemBulkWriteViewSource.Playground => "playground",
                TraceExperimentItemBulkWriteViewSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceExperimentItemBulkWriteViewSource? ToEnum(string value)
        {
            return value switch
            {
                "evaluator" => TraceExperimentItemBulkWriteViewSource.Evaluator,
                "experiment" => TraceExperimentItemBulkWriteViewSource.Experiment,
                "optimization" => TraceExperimentItemBulkWriteViewSource.Optimization,
                "playground" => TraceExperimentItemBulkWriteViewSource.Playground,
                "sdk" => TraceExperimentItemBulkWriteViewSource.Sdk,
                _ => null,
            };
        }
    }
}