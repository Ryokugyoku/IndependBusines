using Microsoft.Extensions.Localization;

namespace IndependBusines.Localize;

/// <summary>
/// ローカライズサービス
/// </summary>
public class LocalizationService
{
    private readonly IStringLocalizer _localizer;

    public LocalizationService(IStringLocalizerFactory factory)
    {
        // "Strings" はリソースファイル名
        _localizer = factory.Create("Strings", typeof(LocalizationService).Assembly.GetName().Name);
    }

    // Keyごとにプロパティを追加
    public string AppName => _localizer["AppName"];
    public string WelcomeMessage => _localizer["WelcomeMessage"];
    // 他のKeyも同様に追加

    // 任意のKeyを取得する汎用メソッド
    public string this[string key] => _localizer[key];
}