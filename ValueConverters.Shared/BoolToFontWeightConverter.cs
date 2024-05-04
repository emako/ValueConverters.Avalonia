using Avalonia.Media;

namespace ValueConverters;

#pragma warning disable CS1591

public class BoolToFontWeightConverter : BoolToValueConverter<FontWeight>
{
    public BoolToFontWeightConverter()
    {
        this.TrueValue = FontWeight.Bold;
        this.FalseValue = FontWeight.Normal;
    }
}
