
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingCalculatorResponseCalculateProductionApiServiceCost
    {
        /// <summary>
        /// API service cost to generate the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorResponseCalculateProductionApiServiceCost" /> class.
        /// </summary>
        /// <param name="cost">
        /// API service cost to generate the image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorResponseCalculateProductionApiServiceCost(
            int? cost)
        {
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorResponseCalculateProductionApiServiceCost" /> class.
        /// </summary>
        public PricingCalculatorResponseCalculateProductionApiServiceCost()
        {
        }
    }
}