using System;
using System.Globalization;
using Avalonia;

namespace ValueConverters;

#pragma warning disable CS1591

public class NullToBoolConverter : SingletonConverterBase<NullToBoolConverter>
{
    public static readonly AvaloniaProperty IsInvertedProperty = AvaloniaProperty.Register<NullToBoolConverter, bool>(
        nameof(IsInverted),
        false);

    public bool IsInverted
    {
        get => (bool)this.GetValue(IsInvertedProperty)!;
        set => this.SetValue(IsInvertedProperty, value);
    }

    protected override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value == null ^ this.IsInverted;
    }
}
