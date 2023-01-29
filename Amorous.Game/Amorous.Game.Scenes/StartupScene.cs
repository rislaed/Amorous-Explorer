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

	private static readonly string _Pxncvon3rRvuowKL1yYBOZjpf2y = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "username.txt");

	private readonly TextBox _njC7ZfEM6PTCffwkw18LisM3W9E;

	private readonly CheckBox _9nCiJkYgPYczxXJNlo8Z7BbfdsB;

	public StartupScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Intro/Background", 0, -540);
		AddSpriteLayer("Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		AddForegroundSpriteLayer("Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.TheNightSkyTrack, 0.4f);
		Window window = new Window
		{
			Position = new Point(704, 412),
			Size = new Point(512, 285)
		};
		Label item = new Label
		{
			Position = new Point(15, 15),
			AutoSize = AutoSize.HorizontalVertical,
			Text = "Thank you for playing Amorous!\n\nThis release is for patrons only. To verify this, please\nlogin using your forum credentials below:"
		};
		Label item2 = new Label
		{
			Position = new Point(15, 135),
			AutoSize = AutoSize.HorizontalVertical,
			Text = "Username:"
		};
		_njC7ZfEM6PTCffwkw18LisM3W9E = new TextBox
		{
			Position = new Point(140, 130),
			Size = new Point(200, AmorousData.ButtonHeight),
			TabIndex = 1
		};
		if (File.Exists(_Pxncvon3rRvuowKL1yYBOZjpf2y))
		{
			_njC7ZfEM6PTCffwkw18LisM3W9E.Text = File.ReadAllText(_Pxncvon3rRvuowKL1yYBOZjpf2y);
		}
		Label item3 = new Label
		{
			Position = new Point(15, 170),
			AutoSize = AutoSize.HorizontalVertical,
			Text = "Password:"
		};
		TextBox _mzwWNbSlBetGnbEr0j6IpMenjkp = new TextBox
		{
			Position = new Point(140, 165),
			Size = new Point(200, AmorousData.ButtonHeight),
			TabIndex = 2,
			IsPassword = true
		};
		_9nCiJkYgPYczxXJNlo8Z7BbfdsB = new CheckBox
		{
			Position = new Point(15, 200),
			Size = new Point(300, AmorousData.ButtonHeight),
			Text = "Remember username",
			Checked = true
		};
		Button button = new Button
		{
			Position = new Point(15, 240),
			Text = "Login"
		};
		button.MouseClick += delegate
		{
			try
			{
				WebRequest webRequest = WebRequest.Create("https://download.amorousgame.com/api/v4/launcherLogin");
				webRequest.Method = "POST";
				using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
				{
					streamWriter.Write(JsonConvert.SerializeObject(new ApiLogin
					{
						username = _njC7ZfEM6PTCffwkw18LisM3W9E.Text,
						password = _mzwWNbSlBetGnbEr0j6IpMenjkp.Text
					}));
				}
				using StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
				ApiReponse apiReponse = JsonConvert.DeserializeObject<ApiReponse>(streamReader.ReadToEnd());
				if (!apiReponse.error)
				{
					string text = Randoms.GetMD5(_njC7ZfEM6PTCffwkw18LisM3W9E.Text + _mzwWNbSlBetGnbEr0j6IpMenjkp.Text + apiReponse.message + apiReponse.timestamp);
					if (text == apiReponse.hash)
					{
						_x8adRt6rvrXniPFYijbzqvPFr4j();
					}
					else
					{
						base.Squid.ShowConfirm("Sorry, please try again!", AmorousData.WideDialogueOffset);
					}
				}
				else
				{
					base.Squid.ShowConfirm(apiReponse.message, AmorousData.ShortDialogueOffset);
				}
			}
			catch (Exception)
			{
				base.Squid.ShowConfirm("Sorry, an unexpected exception occured, see log-file for more details!", AmorousData.ShortDialogueOffset);
			}
		};
		Button button2 = new Button
		{
			Position = new Point(120, 240),
			Size = new Point(180, AmorousData.ButtonHeight),
			Text = "Forgot password?"
		};
		button2.MouseClick += delegate
		{
			base.Game.OpenUrl("https://forums.amorousgame.com/lost-password/");
		};
		window.Controls.Add(item);
		window.Controls.Add(item2);
		window.Controls.Add(_njC7ZfEM6PTCffwkw18LisM3W9E);
		window.Controls.Add(item3);
		window.Controls.Add(_mzwWNbSlBetGnbEr0j6IpMenjkp);
		window.Controls.Add(_9nCiJkYgPYczxXJNlo8Z7BbfdsB);
		window.Controls.Add(button);
		window.Controls.Add(button2);
		base.Squid.Controls.Add(window);
	}

	public override void Start()
	{
		CoupleANPC coupleANPC = base.Game.GetNPCLayerAt<CoupleANPC>(LayerOrder.Background);
		coupleANPC.X = 350f;
		coupleANPC.Y = 1090f;
		coupleANPC.SetPose(CoupleANPC.EPoses.Waving);
		coupleANPC.SetClothes(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC coupleBNPC = base.Game.GetNPCLayerAt<CoupleBNPC>(LayerOrder.Background);
		coupleBNPC.X = 550f;
		coupleBNPC.Y = 1090f;
		coupleBNPC.SetPose(CoupleBNPC.EPoses.Waving);
		coupleBNPC.SetClothes(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
	}

	private void _x8adRt6rvrXniPFYijbzqvPFr4j()
	{
		if (_9nCiJkYgPYczxXJNlo8Z7BbfdsB.Checked)
		{
			File.WriteAllText(_Pxncvon3rRvuowKL1yYBOZjpf2y, _njC7ZfEM6PTCffwkw18LisM3W9E.Text);
		}
		base.Game.StartScene<MainMenuScene>();
	}
}
