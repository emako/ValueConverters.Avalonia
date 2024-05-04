namespace ValueConverters;

#pragma warning disable CS1591

public static class ValueConvertersConfig
{
    /// <summary>
    /// The default culture override behavior.
    /// </summary>
    public static PreferredCulture DefaultPreferredCulture { get; set; } = PreferredCulture.ConverterCulture;
}
