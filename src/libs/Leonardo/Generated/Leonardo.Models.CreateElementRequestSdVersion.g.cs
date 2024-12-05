
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The base version of stable diffusion to use if not using a custom model.<br/>
    /// Default Value: SDXL_0_9
    /// </summary>
    public enum CreateElementRequestSdVersion
    {
        /// <summary>
        /// 
        /// </summary>
        SDXL09,
        /// <summary>
        /// 
        /// </summary>
        SDXL10,
        /// <summary>
        /// 
        /// </summary>
        LEONARDODIFFUSIONXL,
        /// <summary>
        /// 
        /// </summary>
        LEONARDOLIGHTNINGXL,
        /// <summary>
        /// 
        /// </summary>
        VISIONXL,
        /// <summary>
        /// 
        /// </summary>
        KINOXL,
        /// <summary>
        /// 
        /// </summary>
        ALBEDOXL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateElementRequestSdVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateElementRequestSdVersion value)
        {
            return value switch
            {
                CreateElementRequestSdVersion.SDXL09 => "SDXL_0_9",
                CreateElementRequestSdVersion.SDXL10 => "SDXL_1_0",
                CreateElementRequestSdVersion.LEONARDODIFFUSIONXL => "LEONARDO_DIFFUSION_XL",
                CreateElementRequestSdVersion.LEONARDOLIGHTNINGXL => "LEONARDO_LIGHTNING_XL",
                CreateElementRequestSdVersion.VISIONXL => "VISION_XL",
                CreateElementRequestSdVersion.KINOXL => "KINO_XL",
                CreateElementRequestSdVersion.ALBEDOXL => "ALBEDO_XL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateElementRequestSdVersion? ToEnum(string value)
        {
            return value switch
            {
                "SDXL_0_9" => CreateElementRequestSdVersion.SDXL09,
                "SDXL_1_0" => CreateElementRequestSdVersion.SDXL10,
                "LEONARDO_DIFFUSION_XL" => CreateElementRequestSdVersion.LEONARDODIFFUSIONXL,
                "LEONARDO_LIGHTNING_XL" => CreateElementRequestSdVersion.LEONARDOLIGHTNINGXL,
                "VISION_XL" => CreateElementRequestSdVersion.VISIONXL,
                "KINO_XL" => CreateElementRequestSdVersion.KINOXL,
                "ALBEDO_XL" => CreateElementRequestSdVersion.ALBEDOXL,
                _ => null,
            };
        }
    }
}