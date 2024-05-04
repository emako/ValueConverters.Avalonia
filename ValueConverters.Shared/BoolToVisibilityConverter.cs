namespace ValueConverters;

#pragma warning disable CS1591

public class BoolToVisibilityConverter : BoolToValueConverter<Visibility>
{
    public BoolToVisibilityConverter()
    {
        this.TrueValue = Visibility.Visible;
        this.FalseValue = Visibility.Collapsed;
    }
}
