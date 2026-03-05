
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The base version to use if not using a custom model.<br/>
    /// Default Value: FLUX_DEV
    /// </summary>
    public enum CreateElementRequestSdVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Sdxl09,
        /// <summary>
        /// 
        /// </summary>
        Sdxl10,
        /// <summary>
        /// 
        /// </summary>
        LeonardoDiffusionXl,
        /// <summary>
        /// 
        /// </summary>
        LeonardoLightningXl,
        /// <summary>
        /// 
        /// </summary>
        VisionXl,
        /// <summary>
        /// 
        /// </summary>
        KinoXl,
        /// <summary>
        /// 
        /// </summary>
        AlbedoXl,
        /// <summary>
        /// 
        /// </summary>
        FluxDev,
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
                CreateElementRequestSdVersion.Sdxl09 => "SDXL_0_9",
                CreateElementRequestSdVersion.Sdxl10 => "SDXL_1_0",
                CreateElementRequestSdVersion.LeonardoDiffusionXl => "LEONARDO_DIFFUSION_XL",
                CreateElementRequestSdVersion.LeonardoLightningXl => "LEONARDO_LIGHTNING_XL",
                CreateElementRequestSdVersion.VisionXl => "VISION_XL",
                CreateElementRequestSdVersion.KinoXl => "KINO_XL",
                CreateElementRequestSdVersion.AlbedoXl => "ALBEDO_XL",
                CreateElementRequestSdVersion.FluxDev => "FLUX_DEV",
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
                "SDXL_0_9" => CreateElementRequestSdVersion.Sdxl09,
                "SDXL_1_0" => CreateElementRequestSdVersion.Sdxl10,
                "LEONARDO_DIFFUSION_XL" => CreateElementRequestSdVersion.LeonardoDiffusionXl,
                "LEONARDO_LIGHTNING_XL" => CreateElementRequestSdVersion.LeonardoLightningXl,
                "VISION_XL" => CreateElementRequestSdVersion.VisionXl,
                "KINO_XL" => CreateElementRequestSdVersion.KinoXl,
                "ALBEDO_XL" => CreateElementRequestSdVersion.AlbedoXl,
                "FLUX_DEV" => CreateElementRequestSdVersion.FluxDev,
                _ => null,
            };
        }
    }
}