
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
        Api,
        /// <summary>
        /// 
        /// </summary>
        Android,
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        Ios,
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
                ListBlueprintsRequestPlatform.Api => "API",
                ListBlueprintsRequestPlatform.Android => "Android",
                ListBlueprintsRequestPlatform.Web => "Web",
                ListBlueprintsRequestPlatform.Ios => "iOS",
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
                "API" => ListBlueprintsRequestPlatform.Api,
                "Android" => ListBlueprintsRequestPlatform.Android,
                "Web" => ListBlueprintsRequestPlatform.Web,
                "iOS" => ListBlueprintsRequestPlatform.Ios,
                _ => null,
            };
        }
    }
}