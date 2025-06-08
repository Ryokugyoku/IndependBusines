namespace IndependBusines.Resources.Localize;
using System;
using System.Globalization;
using Microsoft.Maui.Controls;

[ContentProperty(nameof(Key))]
public class TranslateExtension : IMarkupExtension
{
    public string Key { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        if (Key == null)
            return "";

        var ci = CultureInfo.CurrentUICulture;
        var resourceManager = Resources.ResourceManager;
        var translation = resourceManager.GetString(Key, ci);

        return translation ?? $"[{Key}]";
    }
}   
