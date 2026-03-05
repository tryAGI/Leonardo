
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The status of a Blueprint Execution Generation
    /// </summary>
    public enum BlueprintExecutionGenerationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
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
    public static class BlueprintExecutionGenerationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlueprintExecutionGenerationStatus value)
        {
            return value switch
            {
                BlueprintExecutionGenerationStatus.Pending => "PENDING",
                BlueprintExecutionGenerationStatus.Completed => "COMPLETED",
                BlueprintExecutionGenerationStatus.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlueprintExecutionGenerationStatus? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => BlueprintExecutionGenerationStatus.Pending,
                "COMPLETED" => BlueprintExecutionGenerationStatus.Completed,
                "FAILED" => BlueprintExecutionGenerationStatus.Failed,
                _ => null,
            };
        }
    }
}