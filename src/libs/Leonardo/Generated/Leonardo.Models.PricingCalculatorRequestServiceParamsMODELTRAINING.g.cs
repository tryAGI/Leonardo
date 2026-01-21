
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Parameters for MODEL_TRAINING service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsMODELTRAINING
    {
        /// <summary>
        /// The resolution for training. Must be 512, 768, or 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// The model for the training. Can be set to 'FLUX_DEV' for FLUX_DEV specific pricing or can be omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd_version")]
        public object? SdVersion { get; set; }

        /// <summary>
        /// The number of images in the training dataset when sd_version is set to 'FLUX_DEV'. Must be between 1 and 50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetImageCount")]
        public int? DatasetImageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMODELTRAINING" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution for training. Must be 512, 768, or 1024.
        /// </param>
        /// <param name="sdVersion">
        /// The model for the training. Can be set to 'FLUX_DEV' for FLUX_DEV specific pricing or can be omitted.
        /// </param>
        /// <param name="datasetImageCount">
        /// The number of images in the training dataset when sd_version is set to 'FLUX_DEV'. Must be between 1 and 50.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParamsMODELTRAINING(
            int? resolution,
            object? sdVersion,
            int? datasetImageCount)
        {
            this.Resolution = resolution;
            this.SdVersion = sdVersion;
            this.DatasetImageCount = datasetImageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsMODELTRAINING" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsMODELTRAINING()
        {
        }
    }
}