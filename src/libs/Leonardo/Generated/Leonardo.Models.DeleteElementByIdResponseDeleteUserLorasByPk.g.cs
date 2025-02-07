
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "user_loras".
    /// </summary>
    public sealed partial class DeleteElementByIdResponseDeleteUserLorasByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteElementByIdResponseDeleteUserLorasByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteElementByIdResponseDeleteUserLorasByPk(
            int? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteElementByIdResponseDeleteUserLorasByPk" /> class.
        /// </summary>
        public DeleteElementByIdResponseDeleteUserLorasByPk()
        {
        }
    }
}