
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The type of failure - PROMPT_MODERATION_BLOCKED indicates the prompt was blocked by content moderation<br/>
    /// Example: PROMPT_MODERATION_BLOCKED
    /// </summary>
    public enum PromptModerationFailureReasonType
    {
        /// <summary>
        /// 
        /// </summary>
        PROMPTMODERATIONBLOCKED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptModerationFailureReasonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptModerationFailureReasonType value)
        {
            return value switch
            {
                PromptModerationFailureReasonType.PROMPTMODERATIONBLOCKED => "PROMPT_MODERATION_BLOCKED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptModerationFailureReasonType? ToEnum(string value)
        {
            return value switch
            {
                "PROMPT_MODERATION_BLOCKED" => PromptModerationFailureReasonType.PROMPTMODERATIONBLOCKED,
                _ => null,
            };
        }
    }
}