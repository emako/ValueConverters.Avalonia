using System;
using System.Collections;
using System.Globalization;

namespace ValueConverters;

#pragma warning disable CS1591

public class FirstOrDefaultConverter : SingletonConverterBase<FirstOrDefaultConverter>
{
    protected override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is IEnumerable enumerable)
        {
            var enumerator = enumerable.GetEnumerator();
            {
                if (enumerator.MoveNext())
                {
                    return enumerator.Current;
                }
            }
        }

        return UnsetValue;
    }
}
