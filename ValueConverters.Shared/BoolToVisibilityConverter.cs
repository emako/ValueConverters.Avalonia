using System;

namespace ValueConverters;

#pragma warning disable CS1591

[Obsolete("Not supported for Avalonia")]
public class BoolToVisibilityConverter : BoolToValueConverter<Visibility>
{
    public BoolToVisibilityConverter()
    {
        this.TrueValue = Visibility.Visible;
        this.FalseValue = Visibility.Collapsed;
    }
}
