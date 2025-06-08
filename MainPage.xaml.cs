namespace IndependBusines;

using IndependBusines.Resources.Localize;
/// <summary>
/// アプリケーションのメインページを表すクラス。
/// ユーザーインターフェースの初期化と、カウンターボタンのクリックイベント処理を担当する。
/// ボタンがクリックされるたびにカウントを増やし、クリック回数に応じたテキストを表示・読み上げる。
/// </summary>
public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
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
