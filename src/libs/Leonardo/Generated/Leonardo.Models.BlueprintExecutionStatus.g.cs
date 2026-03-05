
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
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
                BlueprintExecutionStatus.Pending => "PENDING",
                BlueprintExecutionStatus.Queued => "QUEUED",
                BlueprintExecutionStatus.Completed => "COMPLETED",
                BlueprintExecutionStatus.Failed => "FAILED",
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
                "PENDING" => BlueprintExecutionStatus.Pending,
                "QUEUED" => BlueprintExecutionStatus.Queued,
                "COMPLETED" => BlueprintExecutionStatus.Completed,
                "FAILED" => BlueprintExecutionStatus.Failed,
                _ => null,
            };
        }
    }
}