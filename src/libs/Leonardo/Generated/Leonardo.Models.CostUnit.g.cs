
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The unit of the cost. Can be CREDITS or DOLLARS. Note: DOLLARS unit only supports PAYG plan.
    /// </summary>
    public enum CostUnit
    {
        /// <summary>
        /// DOLLARS unit only supports PAYG plan.
        /// </summary>
        CREDITS,
        /// <summary>
        /// DOLLARS unit only supports PAYG plan.
        /// </summary>
        DOLLARS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CostUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CostUnit value)
        {
            return value switch
            {
                CostUnit.CREDITS => "CREDITS",
                CostUnit.DOLLARS => "DOLLARS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CostUnit? ToEnum(string value)
        {
            return value switch
            {
                "CREDITS" => CostUnit.CREDITS,
                "DOLLARS" => CostUnit.DOLLARS,
                _ => null,
            };
        }
    }
}