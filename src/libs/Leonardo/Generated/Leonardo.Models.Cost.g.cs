
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The cost of the operation.
    /// </summary>
    public sealed partial class Cost
    {
        /// <summary>
        /// The amount of the cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// The unit of the cost. Can be CREDITS or DOLLARS. Note: DOLLARS unit only supports PAYG plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.CostUnitJsonConverter))]
        public global::Leonardo.CostUnit? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cost" /> class.
        /// </summary>
        /// <param name="amount">
        /// The amount of the cost.
        /// </param>
        /// <param name="unit">
        /// The unit of the cost. Can be CREDITS or DOLLARS. Note: DOLLARS unit only supports PAYG plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cost(
            string? amount,
            global::Leonardo.CostUnit? unit)
        {
            this.Amount = amount;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cost" /> class.
        /// </summary>
        public Cost()
        {
        }
    }
}