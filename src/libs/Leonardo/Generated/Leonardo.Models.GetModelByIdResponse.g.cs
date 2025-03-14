
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelByIdResponse
    {
        /// <summary>
        /// columns and relationships of "custom_models"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_models_by_pk")]
        public global::Leonardo.GetModelByIdResponseCustomModelsByPk? CustomModelsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelByIdResponse" /> class.
        /// </summary>
        /// <param name="customModelsByPk">
        /// columns and relationships of "custom_models"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelByIdResponse(
            global::Leonardo.GetModelByIdResponseCustomModelsByPk? customModelsByPk)
        {
            this.CustomModelsByPk = customModelsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelByIdResponse" /> class.
        /// </summary>
        public GetModelByIdResponse()
        {
        }
    }
}