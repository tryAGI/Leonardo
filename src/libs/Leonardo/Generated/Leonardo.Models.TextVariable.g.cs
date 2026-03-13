
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// A text variable for replacing placeholders in Blueprint templates
    /// </summary>
    public sealed partial class TextVariable
    {
        /// <summary>
        /// The name of the placeholder variable (without curly braces)<br/>
        /// Example: characterName
        /// </summary>
        /// <example>characterName</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The value to replace the placeholder with<br/>
        /// Example: Luna
        /// </summary>
        /// <example>Luna</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the placeholder variable (without curly braces)<br/>
        /// Example: characterName
        /// </param>
        /// <param name="value">
        /// The value to replace the placeholder with<br/>
        /// Example: Luna
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextVariable(
            string name,
            string value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextVariable" /> class.
        /// </summary>
        public TextVariable()
        {
        }
    }
}