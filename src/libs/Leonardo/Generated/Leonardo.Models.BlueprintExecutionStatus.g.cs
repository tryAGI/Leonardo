
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The status of a Blueprint Execution.
    /// </summary>
    public enum BlueprintExecutionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        PENDING,
        /// <summary>
        /// 
        /// </summary>
        QUEUED,
        /// <summary>
        /// 
        /// </summary>
        COMPLETED,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlueprintExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlueprintExecutionStatus value)
        {
            return value switch
            {
                BlueprintExecutionStatus.PENDING => "PENDING",
                BlueprintExecutionStatus.QUEUED => "QUEUED",
                BlueprintExecutionStatus.COMPLETED => "COMPLETED",
                BlueprintExecutionStatus.FAILED => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlueprintExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => BlueprintExecutionStatus.PENDING,
                "QUEUED" => BlueprintExecutionStatus.QUEUED,
                "COMPLETED" => BlueprintExecutionStatus.COMPLETED,
                "FAILED" => BlueprintExecutionStatus.FAILED,
                _ => null,
            };
        }
    }
}