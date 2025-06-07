using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;

namespace IndependBusines;

/// <summary>
/// このアプリの初期化要件
/// </summary>
/// <remarks>
/// ・.NET MAUI アプリの初期化を行う
/// ・カスタムフォント（OpenSans-Regular, OpenSans-Semibold）を登録する
/// ・ローカライズ（多言語対応）サービスを有効化する
/// ・サポートするカルチャ（言語）は「en」（英語）と「ja」（日本語）
/// ・デフォルトカルチャは「en」（英語）
/// ・RequestLocalizationOptions でカルチャ設定を構成し、サービスとして登録する
/// ・デバッグビルド時はデバッグロギングを有効化する
/// </remarks>
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddLocalization();

		var supportedCultures = new[] { "en", "ja", "es" };
		var localizationOptions = new RequestLocalizationOptions()
			.SetDefaultCulture("en")
			.AddSupportedCultures(supportedCultures)
			.AddSupportedUICultures(supportedCultures);

		builder.Services.Configure<RequestLocalizationOptions>(options =>
		{
			options.SetDefaultCulture("en")
				   .AddSupportedCultures(supportedCultures)
				   .AddSupportedUICultures(supportedCultures);
		});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
