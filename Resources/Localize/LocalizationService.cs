using Microsoft.Extensions.Localization;

namespace IndependBusines.Localize;

/// <summary>
/// アプリケーションの多言語対応を実現するローカライズサービスクラス。
/// リソースファイル（Strings.resx等）を利用し、指定したキーに対応するローカライズ済みの文字列を取得できる機能を提供する。
/// サポートする言語は英語（en）および日本語（ja）とし、将来的な多言語拡張にも対応可能な設計とする。
/// </summary>
public class LocalizationService
{
    private readonly IStringLocalizer _localizer;

    public LocalizationService(IStringLocalizerFactory factory)
    {
        // "Strings" はリソースファイル名
        _localizer = factory.Create("Strings", typeof(LocalizationService).Assembly.GetName().Name);
    }


    /// <summary>
    /// 指定されたキーを使用してローカライズされた文字列を取得します。
    /// </summary>
    /// <param name="key">リソースファイルで定義された文字列キー</param>
    /// <returns>ローカライズされた文字列</returns>
    /// <example>
    /// <code>
    /// var localizer = new LocalizationService(factory);
    /// string appName = localizer["AppName"];
    /// </code>
    /// </example>
    public string this[string key] => _localizer[key];
}