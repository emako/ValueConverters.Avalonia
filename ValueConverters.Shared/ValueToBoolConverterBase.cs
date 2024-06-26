﻿using System;
using System.Globalization;
using Avalonia;

namespace ValueConverters;

#pragma warning disable CS1591

public abstract class ValueToBoolConverterBase<T, TConverter> : ConverterBase
    where TConverter : new()
{
    public abstract T TrueValue { get; set; }

    public bool IsInverted
    {
        get => (bool)this.GetValue(IsInvertedProperty)!;
        set => this.SetValue(IsInvertedProperty, value);
    }

    protected override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var trueValue = this.TrueValue;
        return Equals(value, trueValue) ^ this.IsInverted;
    }

    public static readonly AvaloniaProperty IsInvertedProperty = PropertyHelper.Create<bool, ValueToBoolConverterBase<T, TConverter>>(nameof(IsInverted));
}
