using System.Globalization;
using Android.Content.PM;
using Android.Views;
using Microsoft.Xna.Framework;

namespace Amorous.Explorer.Android;

[Activity(Label = "@string/app_name",
    MainLauncher = true,
    AlwaysRetainTaskState = true,
    LaunchMode = LaunchMode.SingleInstance,
    ConfigurationChanges = ConfigChanges.Orientation |
    ConfigChanges.KeyboardHidden |
    ConfigChanges.Keyboard |
    ConfigChanges.ScreenSize)]
public class MainActivity : Activity {
    protected override void OnCreate(Bundle savedInstanceState) {
        base.OnCreate(savedInstanceState);

        AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
		{
			Logger.Error((e.ExceptionObject as Exception).ToString());
			Environment.Exit(1);
		};
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
		Logger.Initialize();
		FNALoggerEXT.LogInfo = delegate(string message)
		{
			Logger.Log(message);
		};
		FNALoggerEXT.LogWarn = delegate(string message)
		{
			Logger.Warning(message);
		};
		FNALoggerEXT.LogError = delegate(string message)
		{
			Logger.Error(message);
		};
		Environment.SetEnvironmentVariable("FNA_OPENGL_DISABLE_LATESWAPTEAR", "1");
		using AmorousXnaGame game = new AmorousXnaGame(false);
        SetContentView((View)game.Services.GetService(typeof(View)));
		game.Run();
    }
}
