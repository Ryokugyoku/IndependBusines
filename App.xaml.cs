namespace IndependBusines;
using Resources.Localize;
/// <summary>
/// アプリケーション全体のエントリーポイントとなるクラス。
/// アプリの初期化処理やリソースの読み込み、メインウィンドウの生成を担当する。
/// 画面遷移やナビゲーションの基点として AppShell を生成し、アプリケーションのライフサイクル管理も行う。
/// </summary>
public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new MainPage();
	}
}