﻿namespace ValueConverters;

#pragma warning disable CS1591

public class BoolNegationConverter : BoolToValueConverter<bool>
{
    public BoolNegationConverter()
    {
        this.TrueValue = true;
        this.FalseValue = false;
        this.IsInverted = true;
    }
}
