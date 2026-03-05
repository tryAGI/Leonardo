
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
    /// </summary>
    public enum SdVersions
    {
        /// <summary>
        /// 
        /// </summary>
        V15,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V3,
        /// <summary>
        /// 
        /// </summary>
        Sdxl08,
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
        SdxlLightning,
        /// <summary>
        /// 
        /// </summary>
        Phoenix,
        /// <summary>
        /// 
        /// </summary>
        Flux,
        /// <summary>
        /// 
        /// </summary>
        FluxDev,
        /// <summary>
        /// 
        /// </summary>
        Kino20,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SdVersionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SdVersions value)
        {
            return value switch
            {
                SdVersions.V15 => "v1_5",
                SdVersions.V2 => "v2",
                SdVersions.V3 => "v3",
                SdVersions.Sdxl08 => "SDXL_0_8",
                SdVersions.Sdxl09 => "SDXL_0_9",
                SdVersions.Sdxl10 => "SDXL_1_0",
                SdVersions.SdxlLightning => "SDXL_LIGHTNING",
                SdVersions.Phoenix => "PHOENIX",
                SdVersions.Flux => "FLUX",
                SdVersions.FluxDev => "FLUX_DEV",
                SdVersions.Kino20 => "KINO_2_0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SdVersions? ToEnum(string value)
        {
            return value switch
            {
                "v1_5" => SdVersions.V15,
                "v2" => SdVersions.V2,
                "v3" => SdVersions.V3,
                "SDXL_0_8" => SdVersions.Sdxl08,
                "SDXL_0_9" => SdVersions.Sdxl09,
                "SDXL_1_0" => SdVersions.Sdxl10,
                "SDXL_LIGHTNING" => SdVersions.SdxlLightning,
                "PHOENIX" => SdVersions.Phoenix,
                "FLUX" => SdVersions.Flux,
                "FLUX_DEV" => SdVersions.FluxDev,
                "KINO_2_0" => SdVersions.Kino20,
                _ => null,
            };
        }
    }
}