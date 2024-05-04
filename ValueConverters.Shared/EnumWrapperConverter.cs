using Avalonia;

namespace ValueConverters;

#pragma warning disable CS1591

public class EnumWrapperConverter : EnumWrapperConverterBase<EnumWrapperConverter>
{
    public static readonly AvaloniaProperty NameStyleProperty = AvaloniaProperty.Register<EnumWrapperConverter, EnumWrapperConverterNameStyle>(
        "NameStyle",
        EnumWrapperConverterNameStyle.LongName);

    public override EnumWrapperConverterNameStyle NameStyle
    {
        get => (EnumWrapperConverterNameStyle)this.GetValue(NameStyleProperty)!;
        set => this.SetValue(NameStyleProperty, value);
    }
}
