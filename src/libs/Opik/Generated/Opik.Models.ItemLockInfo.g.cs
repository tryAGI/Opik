
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ItemLockInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_locks")]
        public int? ActiveLocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked_by")]
        public global::System.Collections.Generic.IList<string>? LockedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLockInfo" /> class.
        /// </summary>
        /// <param name="activeLocks"></param>
        /// <param name="lockedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemLockInfo(
            int? activeLocks,
            global::System.Collections.Generic.IList<string>? lockedBy)
        {
            this.ActiveLocks = activeLocks;
            this.LockedBy = lockedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLockInfo" /> class.
        /// </summary>
        public ItemLockInfo()
        {
        }

    }
}