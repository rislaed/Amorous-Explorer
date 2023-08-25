using System;
using System.IO;
using System.Net;
using Amorous.Game.NPC;
using Newtonsoft.Json;
using Squid;

namespace Amorous.Game.Scenes;

public class StartupScene : AbstractScene
{
	private class ApiLogin
	{
		[JsonProperty("username")]
		public string username { get; set; }

		[JsonProperty("password")]
		public string password { get; set; }
	}

	private class ApiReponse
	{
		[JsonProperty("error")]
		public bool error { get; set; }

		[JsonProperty("message")]
		public string message { get; set; }

		[JsonProperty("userGroups")]
		public string[] userGroups { get; set; }

		[JsonProperty("timestamp")]
		public string timestamp { get; set; }

		[JsonProperty("hash")]
		public string hash { get; set; }
	}

	private static readonly string LOGIN_CREDENTIALS = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "username.txt");

	private readonly TextBox usernameText;
	private readonly CheckBox rememberUsernameCheck;

	public StartupScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Intro/Background", 0, -540);
		AddSpriteLayer("Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		AddSpriteLayerAbove("Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.TheNightSkyTrack, 0.4f);
		Window container = new Window
		{
			Position = new Point(704, 412),
			Size = new Point(512, 285)
		};
		Label informationLabel = new Label
		{
			Position = new Point(15, 15),
			AutoSize = AutoSize.HorizontalVertical,
			Text = "Thank you for playing Amorous!\n\nThis release is for patrons only. To verify this, please\nlogin using your forum credentials below:"
		};
		Label usernameLabel = new Label
		{
			Position = new Point(15, 135),
			AutoSize = AutoSize.HorizontalVertical,
			Text = "Username:"
		};
		usernameText = new TextBox
		{
			Position = new Point(140, 130),
			Size = new Point(200, AmorousData.ButtonHeight),
			TabIndex = 1
		};
		if (File.Exists(LOGIN_CREDENTIALS))
		{
			usernameText.Text = File.ReadAllText(LOGIN_CREDENTIALS);
		}
		Label passwordLabel = new Label
		{
			Position = new Point(15, 170),
			AutoSize = AutoSize.HorizontalVertical,
			Text = "Password:"
		};
		TextBox passwordBox = new TextBox
		{
			Position = new Point(140, 165),
			Size = new Point(200, AmorousData.ButtonHeight),
			TabIndex = 2,
			IsPassword = true
		};
		rememberUsernameCheck = new CheckBox
		{
			Position = new Point(15, 200),
			Size = new Point(300, AmorousData.ButtonHeight),
			Text = "Remember username",
			Checked = true
		};
		Button loginButton = new Button
		{
			Position = new Point(15, 240),
			Text = "Login"
		};
		loginButton.MouseClick += delegate
		{
			try
			{
				WebRequest loginRequest = WebRequest.Create("https://download.amorousgame.com/api/v4/launcherLogin");
				loginRequest.Method = "POST";
				using (StreamWriter loginData = new StreamWriter(loginRequest.GetRequestStream()))
				{
					loginData.Write(JsonConvert.SerializeObject(new ApiLogin
					{
						username = usernameText.Text,
						password = passwordBox.Text
					}));
				}
				using StreamReader loginAnswer = new StreamReader(loginRequest.GetResponse().GetResponseStream());
				ApiReponse apiReponse = JsonConvert.DeserializeObject<ApiReponse>(loginAnswer.ReadToEnd());
				if (!apiReponse.error)
				{
					string text = Utils.GetMD5(usernameText.Text + passwordBox.Text + apiReponse.message + apiReponse.timestamp);
					if (text == apiReponse.hash)
					{
						Login();
					}
					else
					{
						base.Desktop.ShowConfirm("Sorry, please try again!", AmorousData.ShortDialogueWidth);
					}
				}
				else
				{
					base.Desktop.ShowConfirm(apiReponse.message, AmorousData.WideDialogueWidth);
				}
			}
			catch (Exception)
			{
				base.Desktop.ShowConfirm("Sorry, an unexpected exception occured, see log-file for more details!", AmorousData.WideDialogueWidth);
			}
		};
		Button forgotPasswordButton = new Button
		{
			Position = new Point(120, 240),
			Size = new Point(180, AmorousData.ButtonHeight),
			Text = "Forgot password?"
		};
		forgotPasswordButton.MouseClick += delegate
		{
			base.Game.OpenUrl("https://forums.amorousgame.com/lost-password/");
		};
		container.Controls.Add(informationLabel);
		container.Controls.Add(usernameLabel);
		container.Controls.Add(usernameText);
		container.Controls.Add(passwordLabel);
		container.Controls.Add(passwordBox);
		container.Controls.Add(rememberUsernameCheck);
		container.Controls.Add(loginButton);
		container.Controls.Add(forgotPasswordButton);
		base.Desktop.Controls.Add(container);
	}

	public override void Start()
	{
		CoupleANPC leftCouples = base.Game.GetNPCLayerAt<CoupleANPC>(LayerOrder.Background);
		leftCouples.X = 350f;
		leftCouples.Y = 1090f;
		leftCouples.SetPose(CoupleANPC.EPoses.Waving);
		leftCouples.SetClothes(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC rightCouples = base.Game.GetNPCLayerAt<CoupleBNPC>(LayerOrder.Background);
		rightCouples.X = 550f;
		rightCouples.Y = 1090f;
		rightCouples.SetPose(CoupleBNPC.EPoses.Waving);
		rightCouples.SetClothes(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
	}

	private void Login()
	{
		if (rememberUsernameCheck.Checked)
		{
			File.WriteAllText(LOGIN_CREDENTIALS, usernameText.Text);
		}
		base.Game.StartScene<MainMenuScene>();
	}
}
