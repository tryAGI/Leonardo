
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteElementByIdResponse
    {
        /// <summary>
        /// columns and relationships of "user_loras".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_user_loras_by_pk")]
        public global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? DeleteUserLorasByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteElementByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteUserLorasByPk">
        /// columns and relationships of "user_loras".
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeleteElementByIdResponse(
            global::Leonardo.DeleteElementByIdResponseDeleteUserLorasByPk? deleteUserLorasByPk)
        {
            this.DeleteUserLorasByPk = deleteUserLorasByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteElementByIdResponse" /> class.
        /// </summary>
        public DeleteElementByIdResponse()
        {
        }
    }
}