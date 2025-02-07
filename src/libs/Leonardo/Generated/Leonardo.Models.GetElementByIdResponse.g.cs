
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetElementByIdResponse
    {
        /// <summary>
        /// columns and relationships of "user_loras".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_loras_by_pk")]
        public global::Leonardo.GetElementByIdResponseUserLorasByPk? UserLorasByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetElementByIdResponse" /> class.
        /// </summary>
        /// <param name="userLorasByPk">
        /// columns and relationships of "user_loras".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetElementByIdResponse(
            global::Leonardo.GetElementByIdResponseUserLorasByPk? userLorasByPk)
        {
            this.UserLorasByPk = userLorasByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetElementByIdResponse" /> class.
        /// </summary>
        public GetElementByIdResponse()
        {
        }
    }
}