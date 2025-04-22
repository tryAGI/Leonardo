
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The model for the training. Can be set to 'FLUX_DEV' for FLUX_DEV specific pricing or can be omitted.
    /// </summary>
    public enum PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion
    {
        /// <summary>
        /// 
        /// </summary>
        FLUXDEV,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingCalculatorRequestServiceParamsMODELTRAININGSdVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion value)
        {
            return value switch
            {
                PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion.FLUXDEV => "FLUX_DEV",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion? ToEnum(string value)
        {
            return value switch
            {
                "FLUX_DEV" => PricingCalculatorRequestServiceParamsMODELTRAININGSdVersion.FLUXDEV,
                _ => null,
            };
        }
    }
}