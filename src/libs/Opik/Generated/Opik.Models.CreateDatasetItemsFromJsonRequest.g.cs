
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetItemsFromJsonRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.CreateDatasetItemsFromJsonRequestFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.CreateDatasetItemsFromJsonRequestFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromJsonRequest" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="datasetId"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetItemsFromJsonRequest(
            object file,
            global::System.Guid datasetId,
            global::Opik.CreateDatasetItemsFromJsonRequestFormat format)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.DatasetId = datasetId;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromJsonRequest" /> class.
        /// </summary>
        public CreateDatasetItemsFromJsonRequest()
        {
        }

    }
}