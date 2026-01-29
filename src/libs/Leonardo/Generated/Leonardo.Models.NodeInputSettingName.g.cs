
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The type of setting to replace:<br/>
    /// - `text`: Direct text replacement (value is a string)<br/>
    /// - `imageUrl`: Image URL input (value is a URL string)<br/>
    /// - `textVariables`: Text with placeholder variables (value is an array of TextVariable)<br/>
    /// Example: text
    /// </summary>
    public enum NodeInputSettingName
    {
        /// <summary>
        /// Direct text replacement (value is a string)
        /// </summary>
        Text,
        /// <summary>
        /// Image URL input (value is a URL string)
        /// </summary>
        ImageUrl,
        /// <summary>
        /// Text with placeholder variables (value is an array of TextVariable)
        /// </summary>
        TextVariables,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeInputSettingNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeInputSettingName value)
        {
            return value switch
            {
                NodeInputSettingName.Text => "text",
                NodeInputSettingName.ImageUrl => "imageUrl",
                NodeInputSettingName.TextVariables => "textVariables",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeInputSettingName? ToEnum(string value)
        {
            return value switch
            {
                "text" => NodeInputSettingName.Text,
                "imageUrl" => NodeInputSettingName.ImageUrl,
                "textVariables" => NodeInputSettingName.TextVariables,
                _ => null,
            };
        }
    }
}