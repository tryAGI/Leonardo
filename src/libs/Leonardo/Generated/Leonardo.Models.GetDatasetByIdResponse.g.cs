
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetByIdResponse
    {
        /// <summary>
        /// columns and relationships of "datasets"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets_by_pk")]
        public global::Leonardo.GetDatasetByIdResponseDatasetsByPk? DatasetsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}