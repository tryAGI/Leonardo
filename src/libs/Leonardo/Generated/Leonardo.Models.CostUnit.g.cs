
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
        Credits,
        /// <summary>
        /// DOLLARS unit only supports PAYG plan.
        /// </summary>
        Dollars,
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
                CostUnit.Credits => "CREDITS",
                CostUnit.Dollars => "DOLLARS",
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
                "CREDITS" => CostUnit.Credits,
                "DOLLARS" => CostUnit.Dollars,
                _ => null,
            };
        }
    }
}