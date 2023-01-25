using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
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
		: base(Game)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Background", 0, -540);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Biggyzoom - The Night Sky", 0.4f);
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
			Size = new Point(200, 30),
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
			Size = new Point(200, 30),
			TabIndex = 2,
			IsPassword = true
		};
		_9nCiJkYgPYczxXJNlo8Z7BbfdsB = new CheckBox
		{
			Position = new Point(15, 200),
			Size = new Point(300, 30),
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
					string text = _boyt8NIMtKsAGSTcjHeL0WMbFxs._mCgIgZp06WD70u8PXcTcCcl6zfe(_njC7ZfEM6PTCffwkw18LisM3W9E.Text + _mzwWNbSlBetGnbEr0j6IpMenjkp.Text + apiReponse.message + apiReponse.timestamp);
					if (text == apiReponse.hash)
					{
						_x8adRt6rvrXniPFYijbzqvPFr4j();
					}
					else
					{
						base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowConfirm("Sorry, please try again!", 250);
					}
				}
				else
				{
					base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowConfirm(apiReponse.message, 500);
				}
			}
			catch (Exception)
			{
				base._PnkAlVnMv0SZvRBFexqzE5DF9tp.ShowConfirm("Sorry, an unexpected exception occured, see log-file for more details!", 500);
			}
		};
		Button button2 = new Button
		{
			Position = new Point(120, 240),
			Size = new Point(180, 30),
			Text = "Forgot password?"
		};
		button2.MouseClick += delegate
		{
			base.Game._fDSidqggP063WGf2vzkdlA1UDkn("https://forums.amorousgame.com/lost-password/");
		};
		window.Controls.Add(item);
		window.Controls.Add(item2);
		window.Controls.Add(_njC7ZfEM6PTCffwkw18LisM3W9E);
		window.Controls.Add(item3);
		window.Controls.Add(_mzwWNbSlBetGnbEr0j6IpMenjkp);
		window.Controls.Add(_9nCiJkYgPYczxXJNlo8Z7BbfdsB);
		window.Controls.Add(button);
		window.Controls.Add(button2);
		base._PnkAlVnMv0SZvRBFexqzE5DF9tp.Controls.Add(window);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		CoupleANPC coupleANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleANPC>(LayerOrder.Background);
		coupleANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 350f;
		coupleANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
		coupleANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleANPC.EPoses.Waving);
		coupleANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC coupleBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CoupleBNPC>(LayerOrder.Background);
		coupleBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 550f;
		coupleBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
		coupleBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(CoupleBNPC.EPoses.Waving);
		coupleBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
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
