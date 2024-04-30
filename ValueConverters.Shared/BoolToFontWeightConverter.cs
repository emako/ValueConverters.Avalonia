using Avalonia.Media;

namespace ValueConverters;

public class BoolToFontWeightConverter : BoolToValueConverter<FontWeight>
{
    public BoolToFontWeightConverter()
    {
        this.TrueValue = FontWeight.Bold;
        this.FalseValue = FontWeight.Normal;
    }
}
