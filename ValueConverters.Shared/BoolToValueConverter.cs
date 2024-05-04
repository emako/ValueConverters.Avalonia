using Avalonia;

namespace ValueConverters;

#pragma warning disable AVP1002
#pragma warning disable CS1591

public class BoolToValueConverter<T> : BoolToValueConverterBase<T, BoolToValueConverter<T>>
{
    public static readonly AvaloniaProperty TrueValueProperty = AvaloniaProperty.Register<BoolToValueConverter<T>, T>(
        "TrueValue",
        default!);

    public static readonly AvaloniaProperty FalseValueProperty = AvaloniaProperty.Register<BoolToValueConverter<T>, T>(
        "FalseValue",
       default!);

    public static readonly AvaloniaProperty IsInvertedProperty = AvaloniaProperty.Register<BoolToValueConverter<T>, bool>(
        "IsInverted",
       false);

    public override T TrueValue
    {
        get => (T)this.GetValue(TrueValueProperty)!;
        set => this.SetValue(TrueValueProperty, value);
    }

    public override T FalseValue
    {
        get => (T)this.GetValue(FalseValueProperty)!;
        set => this.SetValue(FalseValueProperty, value);
    }

    public override bool IsInverted
    {
        get => (bool)this.GetValue(IsInvertedProperty)!;
        set => this.SetValue(IsInvertedProperty, value);
    }
}
