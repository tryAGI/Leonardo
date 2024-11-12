
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingCalculatorRequest
    {
        /// <summary>
        /// The services to be chosen for calculating the API credit cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.PricingCalculatorServicesJsonConverter))]
        public global::Leonardo.PricingCalculatorServices? Service { get; set; }

        /// <summary>
        /// Parameters for the service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceParams")]
        public global::Leonardo.PricingCalculatorRequestServiceParams? ServiceParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequest" /> class.
        /// </summary>
        /// <param name="service">
        /// The services to be chosen for calculating the API credit cost.
        /// </param>
        /// <param name="serviceParams">
        /// Parameters for the service
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PricingCalculatorRequest(
            global::Leonardo.PricingCalculatorServices? service,
            global::Leonardo.PricingCalculatorRequestServiceParams? serviceParams)
        {
            this.Service = service;
            this.ServiceParams = serviceParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequest" /> class.
        /// </summary>
        public PricingCalculatorRequest()
        {
        }
    }
}