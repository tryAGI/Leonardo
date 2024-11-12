
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "custom_models"
    /// </summary>
    public sealed partial class DeleteModelByIdResponseDeleteCustomModelsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelByIdResponseDeleteCustomModelsByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeleteModelByIdResponseDeleteCustomModelsByPk(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelByIdResponseDeleteCustomModelsByPk" /> class.
        /// </summary>
        public DeleteModelByIdResponseDeleteCustomModelsByPk()
        {
        }
    }
}