
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteModelByIdResponse
    {
        /// <summary>
        /// columns and relationships of "custom_models"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_custom_models_by_pk")]
        public global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? DeleteCustomModelsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteCustomModelsByPk">
        /// columns and relationships of "custom_models"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteModelByIdResponse(
            global::Leonardo.DeleteModelByIdResponseDeleteCustomModelsByPk? deleteCustomModelsByPk)
        {
            this.DeleteCustomModelsByPk = deleteCustomModelsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelByIdResponse" /> class.
        /// </summary>
        public DeleteModelByIdResponse()
        {
        }
    }
}