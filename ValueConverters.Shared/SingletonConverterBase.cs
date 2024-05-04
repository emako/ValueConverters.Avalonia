using System;
using System.Threading;

namespace ValueConverters;

#pragma warning disable CS1591

public abstract class SingletonConverterBase<TConverter> : ConverterBase
    where TConverter : new()
{
    private static readonly Lazy<TConverter> InstanceConstructor = new Lazy<TConverter>(() =>
    {
        return new TConverter();
    }, LazyThreadSafetyMode.PublicationOnly);

    public static TConverter Instance => InstanceConstructor.Value;
}
