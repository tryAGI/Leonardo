
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// columns and relationships of "users"
    /// </summary>
    public sealed partial class GetUserSelfResponseUserDetailUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Username of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponseUserDetailUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username">
        /// Username of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserSelfResponseUserDetailUser(
            string? id,
            string? username)
        {
            this.Id = id;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponseUserDetailUser" /> class.
        /// </summary>
        public GetUserSelfResponseUserDetailUser()
        {
        }
    }
}