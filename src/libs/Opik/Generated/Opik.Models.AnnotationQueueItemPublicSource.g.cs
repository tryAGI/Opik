
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum AnnotationQueueItemPublicSource
    {
        /// <summary>
        ///
        /// </summary>
        Automated,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueItemPublicSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueItemPublicSource value)
        {
            return value switch
            {
                AnnotationQueueItemPublicSource.Automated => "automated",
                AnnotationQueueItemPublicSource.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueItemPublicSource? ToEnum(string value)
        {
            return value switch
            {
                "automated" => AnnotationQueueItemPublicSource.Automated,
                "manual" => AnnotationQueueItemPublicSource.Manual,
                _ => null,
            };
        }
    }
}