
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBlueprintsRequestPlatform
    {
        /// <summary>
        /// 
        /// </summary>
        Android,
        /// <summary>
        /// 
        /// </summary>
        Ios,
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBlueprintsRequestPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBlueprintsRequestPlatform value)
        {
            return value switch
            {
                ListBlueprintsRequestPlatform.Android => "Android",
                ListBlueprintsRequestPlatform.Ios => "iOS",
                ListBlueprintsRequestPlatform.Web => "Web",
                ListBlueprintsRequestPlatform.Api => "API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBlueprintsRequestPlatform? ToEnum(string value)
        {
            return value switch
            {
                "Android" => ListBlueprintsRequestPlatform.Android,
                "iOS" => ListBlueprintsRequestPlatform.Ios,
                "Web" => ListBlueprintsRequestPlatform.Web,
                "API" => ListBlueprintsRequestPlatform.Api,
                _ => null,
            };
        }
    }
}