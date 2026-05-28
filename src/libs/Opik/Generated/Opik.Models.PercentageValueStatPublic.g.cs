
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PercentageValueStatPublic : global::Opik.ProjectStatItemObjectPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Opik.PercentageValuesPublic? Value { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValueStatPublic" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PercentageValueStatPublic(
            global::Opik.PercentageValuesPublic? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValueStatPublic" /> class.
        /// </summary>
        public PercentageValueStatPublic()
        {
        }

    }
}