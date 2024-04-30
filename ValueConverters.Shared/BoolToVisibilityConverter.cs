namespace ValueConverters;

public class BoolToVisibilityConverter : BoolToValueConverter<Visibility>
{
    public BoolToVisibilityConverter()
    {
        this.TrueValue = Visibility.Visible;
        this.FalseValue = Visibility.Collapsed;
    }
}
