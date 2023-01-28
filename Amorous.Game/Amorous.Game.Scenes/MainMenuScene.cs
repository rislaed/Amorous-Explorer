using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Amorous.Engine.GUI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Squid;

namespace Amorous.Game.Scenes;

public class MainMenuScene : TimeOfDayScene
{
	private const int TickingDelay = 750;

	private int Blinking;
	private readonly AbstractLayer Separator;
	private readonly List<TexturedSequenceLayer> Indicators = new List<TexturedSequenceLayer>();
	private readonly CopyrightGUI Copyright;
	private readonly TexturedLayer Logotype;

	public MainMenuScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/MainMenu/Menu Background", -240, -135);
		AddTexturedLayer("Bed", "Assets/Scenes/MainMenu/Bed", -240, -135);
		AddTexturedLayer("Logo", "Assets/Scenes/MainMenu/Bed Logo", -240, -135);
		AddTexturedLayer("Table", "Assets/Scenes/MainMenu/Table and clock", -240, -135);
		AddTexturedLayer("LCD Separator", "Assets/Scenes/MainMenu/Semicolon", -155, -135);
		AddLayer(new DrawableLayer(this, "Custom")
		{
			OnDraw = DrawPlayer
		}, 0);
		AddForegroundTexturedLayer("Sheet", "Assets/Scenes/MainMenu/Bed Sheet", -240, -135);
		Logotype = NewTexturedLayer("Title", "Assets/Scenes/MainMenu/Logo", 1220, 800);
		AddIndicatorLayer("LCD 1", "Assets/Scenes/MainMenu/{0}", 1090, 330);
		AddIndicatorLayer("LCD 2", "Assets/Scenes/MainMenu/{0}", 1215, 330);
		AddIndicatorLayer("LCD 3", "Assets/Scenes/MainMenu/{0}", 1395, 330);
		AddIndicatorLayer("LCD 4", "Assets/Scenes/MainMenu/{0}", 1520, 330);
		Blinking = TickingDelay;
		Separator = GetLayer("LCD Separator");
		PlayerPreferences.SetPlayerSkin(new MainMenuPlayerSkin(game));
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/WarmanSteve - Giant Robots", 0.4f);
		Game.SetOverlay(new _BlUQCbX8YXbBc38I7iPEHyF1rUQ(game)
		{
			_uIOOxdCbSvCxXvjNgoXh2qYj0hr = delegate
			{
				base.Game.Overlay.Touchable = false;
				base.Squid.ShowSelection("What would you like to do?", new string[4] { "New Game", "New Game w/o Prologue", "Character Customization", "Oops, I've changed my mind!" }, 500, delegate(int answer)
				{
					PlayerData data = PlayerPreferences.GetPlayerData();
					switch (answer)
					{
						default:
							base.Game.Overlay.Touchable = true;
							break;
						case 0:
							FadingMediaPlayer.Show();
							data.Reset();
							PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = false;
							TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
							TypingDialogue._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
							base.Game.StartCutscene("Prologue");
							break;
						case 1:
							FadingMediaPlayer.Show();
							data.Reset();
							PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = false;
							TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
							TypingDialogue._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
							base.Game.StartScene<SkipProloguePlayerCustomizationScene>();
							break;
						case 2:
							FadingMediaPlayer.Show();
							data.Reset();
							PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = false;
							TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
							TypingDialogue._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
							base.Game.StartScene<PlayerCustomizationScene>();
							break;
					}
				});
			},
			_HmpXEsA3mxR8eI4MZmgIPCtSGQb = delegate
			{
				base.Game.Overlay.Touchable = false;
				List<Saves.Pointer> saves = Saves.GetPointers(excludeAutosaves: false);
				List<string> saveNames = saves.Select((Saves.Pointer pointer) => pointer.Name).ToList();
				saveNames.Add("Oops, I've changed my mind!");
				base.Squid.ShowSelection("Which save do you wish to load?", saveNames.ToArray(), 500, delegate(int answer)
				{
					if (answer == saveNames.Count - 1)
					{
						base.Game.Overlay.Touchable = true;
					}
					else
					{
						Saves.Pointer Pointer = saves[answer];
						if (!Pointer.IsEmpty)
						{
							if (!((!Pointer.IsAutosave) ? base.Game.ReadFromSlot(Pointer.Index) : base.Game.ReadFromAutosaveSlot(Pointer.Index)))
							{
								base.Squid.ShowConfirm("Failed to load save, it's most likely corrupted.", 250, "OK", delegate
								{
									base.Game.Overlay.Touchable = true;
								});
							}
							else
							{
								base.Game.Overlay.Touchable = true;
							}
						}
						else
						{
							base.Squid.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", Pointer.IsAutosave ? "autosave " : string.Empty, answer + 1), 250, "OK", delegate
							{
								base.Game.Overlay.Touchable = true;
							});
						}
					}
				});
			},
			_vE5Pvwth7cQFh82bMTB5u59Ju4o = delegate
			{
				base.Game.Overlay.Touchable = false;
				base.Squid.ShowSelection("Are you sure you wish to quit the Game?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, 500, delegate(int answer)
				{
					if (answer == 1)
					{
						base.Game.Fading.Show(delegate
						{
							base.Game.Exit();
						});
					}
					base.Game.Overlay.Touchable = true;
				});
			}
		});
		Copyright = new CopyrightGUI(game)
		{
			Configure = DiplayOptions
		};
		Clocks.InRealTime = true;
	}

	public override void Begin() {}

	public TexturedSequenceLayer AddIndicatorLayer(string name, string textureFormat, int x, int y)
	{
		Texture2D[] array = new Texture2D[10];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = base.Game.Content.Load<Texture2D>(string.Format(textureFormat, i));
		}
		TexturedSequenceLayer layer = new TexturedSequenceLayer(this, name, array)
		{
			Removable = true,
			X = x,
			Y = y
		};
		AddLayer(layer, OrderForeground);
		Indicators.Add(layer);
		return layer;
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		Blinking -= gameTime.ElapsedGameTime.Milliseconds;
		if (Blinking < 0)
		{
			Separator.Visible = !Separator.Visible;
			Blinking = TickingDelay;
		}
		Indicators[0].State = DateTime.Now.Hour / 10;
		Indicators[1].State = DateTime.Now.Hour % 10;
		Indicators[2].State = DateTime.Now.Minute / 10;
		Indicators[3].State = DateTime.Now.Minute % 10;
		if (base.Game.Overlay != null)
		{
			Copyright.Touchable = base.Game.Overlay.Touchable;
			Copyright.Update(gameTime);
		}
	}

	public void DrawPlayer(SpriteBatch spriteBatch)
	{
		if (PlayerPreferences.Singleton.PlayerSkin != null)
		{
			spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, null, null, null, null, Matrix.CreateTranslation(-100f, -390f, 0f) * Matrix.CreateRotationZ((float)Math.Sin(Randoms.Time) * MathHelper.ToRadians(5f)) * Matrix.CreateTranslation(90f, 390f, 0f));
			PlayerPreferences.Singleton.PlayerSkin.Draw(spriteBatch);
			spriteBatch.End();
		}
	}

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		base.DrawOverlay(spriteBatch);
		spriteBatch.Begin();
		Logotype.Draw(spriteBatch);
		spriteBatch.End();
		Copyright.Draw(spriteBatch);
	}

	private void DiplayOptions()
	{
		base.Game.Overlay.Touchable = false;
		int num = 0;
		if (Censorship.Booties)
		{
			num += 60;
		}
		if (!Censorship.Censored)
		{
			num += 60;
		}
		Window _L7VColD35B3sDgJdUnjTeXGa7pv = new Window
		{
			Dock = DockStyle.Center,
			Size = new Squid.Point(512, 540 + num),
			Margin = new Margin(8),
			Padding = new Margin(8)
		};
		Panel panel = new Panel
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(8)
		};
		_L7VColD35B3sDgJdUnjTeXGa7pv.Controls.Add(panel);
		Label item = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Display"
		};
		Label item2 = new Label
		{
			Dock = DockStyle.Top,
			Text = "Resolutions"
		};
		DropDownList dropDownList = new DropDownList();
		dropDownList.Dock = DockStyle.Top;
		dropDownList.Style = "button";
		dropDownList.Label.Margin = new Margin(10, 0, 0, 0);
		dropDownList.Dropdown.Resizable = false;
		dropDownList.Margin = new Margin(0, 0, 0, 5);
		DropDownList dropDownList2 = dropDownList;
		dropDownList2.Listbox.Scrollbar.ButtonUp.Visible = false;
		dropDownList2.Listbox.Scrollbar.ButtonDown.Visible = false;
		int _ExpbREeE97oXaFMwg5UwE6MpAAQ = base.Game.Mouse.CanvasWidth;
		int _P2eFcUFiRYQgRf4ICqeX3kVcA2m = base.Game.Mouse.CanvasHeight;
		foreach (DisplayMode supportedDisplayMode in base.Game.GLES.Adapter.SupportedDisplayModes)
		{
			dropDownList2.Items.Add(new ListBoxItem
			{
				Text = supportedDisplayMode.Width + "x" + supportedDisplayMode.Height,
				Value = supportedDisplayMode,
				Size = new Squid.Point(0, 30),
				Selected = (_ExpbREeE97oXaFMwg5UwE6MpAAQ == supportedDisplayMode.Width && _P2eFcUFiRYQgRf4ICqeX3kVcA2m == supportedDisplayMode.Height)
			});
		}
		dropDownList2.SelectedItemChanged += delegate(Control control_0, ListBoxItem listBoxItem_0)
		{
			if (listBoxItem_0.Value is DisplayMode)
			{
				DisplayMode displayMode = listBoxItem_0.Value as DisplayMode;
				base.Game.SetDisplay(displayMode.Width, displayMode.Height);
				Options.Data.ResolutionWidth = displayMode.Width;
				Options.Data.ResolutionHeight = displayMode.Height;
				_ExpbREeE97oXaFMwg5UwE6MpAAQ = displayMode.Width;
				_P2eFcUFiRYQgRf4ICqeX3kVcA2m = displayMode.Height;
			}
		};
		CheckBox checkBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Fullscreen",
			Checked = base.Game.IsFullscreen
		};
		checkBox.CheckedChanged += delegate
		{
			base.Game.SetDisplay(_ExpbREeE97oXaFMwg5UwE6MpAAQ, _P2eFcUFiRYQgRf4ICqeX3kVcA2m, !base.Game.IsFullscreen);
			Options.Data.Fullscreen = base.Game.IsFullscreen;
		};
		panel.Content.Controls.Add(item);
		panel.Content.Controls.Add(item2);
		panel.Content.Controls.Add(dropDownList2);
		panel.Content.Controls.Add(checkBox);
		Label item3 = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Sound"
		};
		Label item4 = new Label
		{
			Dock = DockStyle.Top,
			Text = "Master Volume"
		};
		Slider slider = new Slider();
		slider.Dock = DockStyle.Top;
		slider.Orientation = Orientation.Horizontal;
		slider.Steps = 100f;
		slider.Value = Options.Data.MasterVolume * 100f;
		slider.Style = "scrollSlider";
		slider.Size = new Squid.Point(0, 30);
		slider.Button.Style = "scrollSliderButton";
		Slider _XEgAfmv7sJWJSaC2diC3eaD4Fgl = slider;
		_XEgAfmv7sJWJSaC2diC3eaD4Fgl.ValueChanged += delegate
		{
			Options.Data.MasterVolume = _XEgAfmv7sJWJSaC2diC3eaD4Fgl.Value / 100f;
		};
		Label item5 = new Label
		{
			Dock = DockStyle.Top,
			Text = "Music Volume"
		};
		Slider slider2 = new Slider();
		slider2.Dock = DockStyle.Top;
		slider2.Orientation = Orientation.Horizontal;
		slider2.Steps = 100f;
		slider2.Value = Options.Data.MusicVolume * 100f;
		slider2.Style = "scrollSlider";
		slider2.Size = new Squid.Point(0, 30);
		slider2.Button.Style = "scrollSliderButton";
		Slider _gjeIIVx9bHyd0aMj0WD483nrLWK = slider2;
		_gjeIIVx9bHyd0aMj0WD483nrLWK.ValueChanged += delegate
		{
			Options.Data.MusicVolume = _gjeIIVx9bHyd0aMj0WD483nrLWK.Value / 100f;
		};
		Label item6 = new Label
		{
			Dock = DockStyle.Top,
			Text = "SFX Volume"
		};
		Slider slider3 = new Slider();
		slider3.Dock = DockStyle.Top;
		slider3.Orientation = Orientation.Horizontal;
		slider3.Steps = 100f;
		slider3.Value = Options.Data.SfxVolume * 100f;
		slider3.Style = "scrollSlider";
		slider3.Size = new Squid.Point(0, 30);
		slider3.Button.Style = "scrollSliderButton";
		Slider _5mK9ExiyKm0md8q4J1C6xc4TzdF = slider3;
		_5mK9ExiyKm0md8q4J1C6xc4TzdF.ValueChanged += delegate
		{
			Options.Data.SfxVolume = _5mK9ExiyKm0md8q4J1C6xc4TzdF.Value / 100f;
		};
		panel.Content.Controls.Add(item3);
		panel.Content.Controls.Add(item4);
		panel.Content.Controls.Add(_XEgAfmv7sJWJSaC2diC3eaD4Fgl);
		panel.Content.Controls.Add(item5);
		panel.Content.Controls.Add(_gjeIIVx9bHyd0aMj0WD483nrLWK);
		panel.Content.Controls.Add(item6);
		panel.Content.Controls.Add(_5mK9ExiyKm0md8q4J1C6xc4TzdF);
		Label item7 = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Dialogue"
		};
		panel.Content.Controls.Add(item7);
		PhoneOverlay._YemBTJprwfbd3mpg5Gy9uyEJWwI(panel.Content.Controls, "Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)Options.Data.DialogueTextSpeed, delegate(int int_0)
		{
			Options.Data.DialogueTextSpeed = (DialogueSpeed)int_0;
			TypingDialogue.Speed = (DialogueSpeed)int_0;
		});
		CheckBox _feL3soNn6ZWaJqYfjYJUyH118tF = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Auto-skip",
			Checked = Options.Data.DialogueAutoSkip
		};
		_feL3soNn6ZWaJqYfjYJUyH118tF.CheckedChanged += delegate
		{
			Options.Data.DialogueAutoSkip = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
			TypingDialogue._fUgDiz7KX8TZUVzFlTeXMOhmfUT = _feL3soNn6ZWaJqYfjYJUyH118tF.Checked;
		};
		panel.Content.Controls.Add(_feL3soNn6ZWaJqYfjYJUyH118tF);
		if (Censorship.Booties)
		{
			Label item8 = new Label
			{
				Dock = DockStyle.Top,
				TextAlign = Alignment.MiddleCenter,
				Text = "Cheats"
			};
			CheckBox _LFRG0GY4VuOaiC2XHbpUmFoVDAj = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable SFW-mode",
				Checked = Censorship.Censored
			};
			_LFRG0GY4VuOaiC2XHbpUmFoVDAj.CheckedChanged += delegate
			{
				Censorship.Censored = _LFRG0GY4VuOaiC2XHbpUmFoVDAj.Checked;
				_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
				DiplayOptions();
			};
			panel.Content.Controls.Add(item8);
			panel.Content.Controls.Add(_LFRG0GY4VuOaiC2XHbpUmFoVDAj);
		}
		if (!Censorship.Censored)
		{
			CheckBox _PBgLcZr7dRzS97rFn3FU6lDw8ZE = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable Topless",
				Checked = Censorship.Topless
			};
			_PBgLcZr7dRzS97rFn3FU6lDw8ZE.CheckedChanged += delegate
			{
				Censorship.Topless = _PBgLcZr7dRzS97rFn3FU6lDw8ZE.Checked;
			};
			CheckBox _qWiPLfzctHo3AqPevD7VV4qTuDy = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable Bottomless",
				Checked = Censorship.Bottomless
			};
			_qWiPLfzctHo3AqPevD7VV4qTuDy.CheckedChanged += delegate
			{
				Censorship.Bottomless = _qWiPLfzctHo3AqPevD7VV4qTuDy.Checked;
			};
			panel.Content.Controls.Add(_PBgLcZr7dRzS97rFn3FU6lDw8ZE);
			panel.Content.Controls.Add(_qWiPLfzctHo3AqPevD7VV4qTuDy);
		}
		Button button = new Button
		{
			Dock = DockStyle.Bottom,
			Text = "Close"
		};
		button.MouseClick += delegate
		{
			base.Game.Overlay.Touchable = true;
			Options.Save();
			_L7VColD35B3sDgJdUnjTeXGa7pv.Close();
		};
		panel.Content.Controls.Add(button);
		_L7VColD35B3sDgJdUnjTeXGa7pv.Show(base.Squid);
	}

	public override void End()
	{
		base.End();
		Clocks.InRealTime = false;
	}
}
