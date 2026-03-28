#pragma warning disable CS0108 // member hides inherited member
#pragma warning disable CS8618 // non-nullable field uninitialized

#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum FindFeedbackDefinitionsType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        Numerical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FindFeedbackDefinitionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindFeedbackDefinitionsType value)
        {
            return value switch
            {
                FindFeedbackDefinitionsType.Boolean => "boolean",
                FindFeedbackDefinitionsType.Categorical => "categorical",
                FindFeedbackDefinitionsType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindFeedbackDefinitionsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FindFeedbackDefinitionsType.Boolean,
                "categorical" => FindFeedbackDefinitionsType.Categorical,
                "numerical" => FindFeedbackDefinitionsType.Numerical,
                _ => null,
            };
        }
    }
}