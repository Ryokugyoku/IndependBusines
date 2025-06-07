namespace IndependBusines;

using IndependBusines.Localize;
/// <summary>
/// アプリケーションのメインページを表すクラス。
/// ユーザーインターフェースの初期化と、カウンターボタンのクリックイベント処理を担当する。
/// ボタンがクリックされるたびにカウントを増やし、クリック回数に応じたテキストを表示・読み上げる。
/// </summary>
public partial class MainPage : ContentPage
{
	private readonly LocalizationService _localization;

	int count = 0;

	public MainPage(LocalizationService localizationService)
	{
		InitializeComponent();
		_localization = localizationService;
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
