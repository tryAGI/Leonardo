
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElementInput
    {
        /// <summary>
        /// Unique identifier for element. Elements can be found from the List Elements endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AkUUID { get; set; }

        /// <summary>
        /// Weight for the element<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementInput" /> class.
        /// </summary>
        /// <param name="akUUID">
        /// Unique identifier for element. Elements can be found from the List Elements endpoint.
        /// </param>
        /// <param name="weight">
        /// Weight for the element<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElementInput(
            string akUUID,
            double? weight)
        {
            this.AkUUID = akUUID ?? throw new global::System.ArgumentNullException(nameof(akUUID));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementInput" /> class.
        /// </summary>
        public ElementInput()
        {
        }
    }
}