﻿using System.Globalization;
using Avalonia.Data.Converters;

namespace ValueConverters;

#pragma warning disable CS1591

public enum PreferredCulture
{
    /// <summary>
    /// Uses the default culture provided by <seealso cref="IValueConverter"/>.
    /// </summary>
    ConverterCulture,

    /// <summary>
    /// Overrides the default converter culture with <seealso cref="CultureInfo.CurrentCulture"/>.
    /// </summary>
    CurrentCulture,

    /// <summary>
    /// Overrides the default converter culture with <seealso cref="CultureInfo.CurrentUICulture"/>.
    /// </summary>
    CurrentUICulture,
}
