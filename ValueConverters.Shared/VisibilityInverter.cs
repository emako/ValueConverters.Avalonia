using System;

namespace ValueConverters;

#pragma warning disable CS1591

[Obsolete("Not supported for Avalonia")]
public sealed class VisibilityInverter : BoolToValueConverter<Visibility>
{
    public VisibilityInverter()
    {
        this.TrueValue = Visibility.Visible;
        this.FalseValue = Visibility.Collapsed;
        this.IsInverted = true;
    }
}
