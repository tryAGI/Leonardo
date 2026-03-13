
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Leonardo
{
    /// <summary>
    /// A node input object for customizing a Blueprint Execution
    /// </summary>
    public sealed partial class NodeInput
    {
        /// <summary>
        /// The ID of the node in the Blueprint<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </summary>
        /// <example>a1b2c3d4-e5f6-7890-abcd-ef1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid NodeId { get; set; }

        /// <summary>
        /// The type of setting to replace:<br/>
        /// - `text`: Direct text replacement (value is a string)<br/>
        /// - `imageUrl`: Image URL input (value is a URL string)<br/>
        /// - `textVariables`: Text with placeholder variables (value is an array of TextVariable)<br/>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("settingName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.NodeInputSettingNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.NodeInputSettingName SettingName { get; set; }

        /// <summary>
        /// The replacement value. Type depends on settingName:<br/>
        /// - `text`: string (the full text)<br/>
        /// - `imageUrl`: string (the image URL)<br/>
        /// - `textVariables`: array of TextVariable objects<br/>
        /// Example: A futuristic cityscape at sunset
        /// </summary>
        /// <example>A futuristic cityscape at sunset</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.OneOf<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInput" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// The ID of the node in the Blueprint<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="settingName">
        /// The type of setting to replace:<br/>
        /// - `text`: Direct text replacement (value is a string)<br/>
        /// - `imageUrl`: Image URL input (value is a URL string)<br/>
        /// - `textVariables`: Text with placeholder variables (value is an array of TextVariable)<br/>
        /// Example: text
        /// </param>
        /// <param name="value">
        /// The replacement value. Type depends on settingName:<br/>
        /// - `text`: string (the full text)<br/>
        /// - `imageUrl`: string (the image URL)<br/>
        /// - `textVariables`: array of TextVariable objects<br/>
        /// Example: A futuristic cityscape at sunset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeInput(
            global::System.Guid nodeId,
            global::Leonardo.NodeInputSettingName settingName,
            global::Leonardo.OneOf<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>> value)
        {
            this.NodeId = nodeId;
            this.SettingName = settingName;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInput" /> class.
        /// </summary>
        public NodeInput()
        {
        }
    }
}