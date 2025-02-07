
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserElementsInput
    {
        /// <summary>
        /// Unique identifier for user custom element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLoraId")]
        public double? UserLoraId { get; set; }

        /// <summary>
        /// Weight for the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserElementsInput" /> class.
        /// </summary>
        /// <param name="userLoraId">
        /// Unique identifier for user custom element.
        /// </param>
        /// <param name="weight">
        /// Weight for the element
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserElementsInput(
            double? userLoraId,
            double? weight)
        {
            this.UserLoraId = userLoraId;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserElementsInput" /> class.
        /// </summary>
        public UserElementsInput()
        {
        }
    }
}