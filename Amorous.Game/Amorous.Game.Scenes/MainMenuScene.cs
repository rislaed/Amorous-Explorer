using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Engine.GUI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

namespace Amorous.Game.Scenes;

public class MainMenuScene : TimeOfDayScene
{
	private const int TickingDelay = 750;

	private int _blinking;
	private readonly AbstractLayer _separator;
	private readonly List<TexturedSequenceLayer> _segments = new List<TexturedSequenceLayer>();
	private readonly CopyrightOverlay _copyright;
	private readonly SpriteLayer _logotype;

	public MainMenuScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/MainMenu/Menu Background", -240, -135);
		AddSpriteLayer("Bed", "Assets/Scenes/MainMenu/Bed", -240, -135);
		AddSpriteLayer("Logo", "Assets/Scenes/MainMenu/Bed Logo", -240, -135);
		AddSpriteLayer("Table", "Assets/Scenes/MainMenu/Table and clock", -240, -135);
		AddSpriteLayer("LCD Separator", "Assets/Scenes/MainMenu/Semicolon", -155, -135);
		AddLayer(new DrawableLayer(this, "Custom")
		{
			OnDraw = DrawPlayer
		}, 0);
		AddForegroundSpriteLayer("Sheet", "Assets/Scenes/MainMenu/Bed Sheet", -240, -135);
		_logotype = NewSpriteLayer("Title", "Assets/Scenes/MainMenu/Logo", 1220, 800);
		AddIndicatorLayer("LCD 1", "Assets/Scenes/MainMenu/{0}", 1090, 330);
		AddIndicatorLayer("LCD 2", "Assets/Scenes/MainMenu/{0}", 1215, 330);
		AddIndicatorLayer("LCD 3", "Assets/Scenes/MainMenu/{0}", 1395, 330);
		AddIndicatorLayer("LCD 4", "Assets/Scenes/MainMenu/{0}", 1520, 330);
		_blinking = TickingDelay;
		_separator = GetLayer("LCD Separator");
		PlayerPreferences.SetPlayerOverlay(new MainMenuPlayerSkin(game));
		FadingMediaPlayer.PlayOnRepeat(AmorousData.GiantRobotsTrack, 0.4f);
		Game.SetOverlay(new MainMenuOverlay(game)
		{
			NewGame = delegate
			{
				base.Game.Overlay.Touchable = false;
				base.Squid.ShowSelection("What would you like to do?", new string[4] { "New Game", "New Game w/o Prologue", "Character Customization", "Oops, I've changed my mind!" }, AmorousData.ShortDialogueOffset, delegate(int answer)
				{
					PlayerData data = PlayerPreferences.GetPlayerData();
					switch (answer)
					{
						default:
							base.Game.Overlay.Touchable = true;
							break;
						case 0:
							FadingMediaPlayer.FadeOut();
							data.Reset();
							PhoneOverlay.Enabled = false;
							TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
							TypingDialogue.AutoSkip = Options.Data.DialogueAutoSkip;
							base.Game.PlayCutscene(AmorousData.Prologue);
							break;
						case 1:
							FadingMediaPlayer.FadeOut();
							data.Reset();
							PhoneOverlay.Enabled = false;
							TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
							TypingDialogue.AutoSkip = Options.Data.DialogueAutoSkip;
							base.Game.StartScene<SkipProloguePlayerCustomizationScene>();
							break;
						case 2:
							FadingMediaPlayer.FadeOut();
							data.Reset();
							PhoneOverlay.Enabled = false;
							TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
							TypingDialogue.AutoSkip = Options.Data.DialogueAutoSkip;
							base.Game.StartScene<PlayerCustomizationScene>();
							break;
					}
				});
			},
			Continue = delegate
			{
				base.Game.Overlay.Touchable = false;
				List<Saves.Pointer> saves = Saves.GetPointers(excludeAutosaves: false);
				List<string> saveNames = saves.Select((Saves.Pointer pointer) => pointer.Name).ToList();
				saveNames.Add("Oops, I've changed my mind!");
				base.Squid.ShowSelection("Which save do you wish to load?", saveNames.ToArray(), AmorousData.ShortDialogueOffset, delegate(int answer)
				{
					if (answer == saveNames.Count - 1)
					{
						base.Game.Overlay.Touchable = true;
					}
					else
					{
						Saves.Pointer pointer = saves[answer];
						if (!pointer.IsEmpty)
						{
							if (!((!pointer.IsAutosave) ? base.Game.ReadFromSlot(pointer.Index) : base.Game.ReadFromAutosaveSlot(pointer.Index)))
							{
								base.Squid.ShowConfirm("Failed to load save, it's most likely corrupted.", AmorousData.WideDialogueOffset, "OK", delegate
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
							base.Squid.ShowConfirm(string.Format("There is no save in {0}slot #{1}!", pointer.IsAutosave ? "autosave " : string.Empty, answer + 1), AmorousData.WideDialogueOffset, "OK", delegate
							{
								base.Game.Overlay.Touchable = true;
							});
						}
					}
				});
			},
			Quit = delegate
			{
				base.Game.Overlay.Touchable = false;
				base.Squid.ShowSelection("Are you sure you wish to quit the Game?", new string[2] { "Oh no, abort!", "Yes, I'm very sure!" }, AmorousData.ShortDialogueOffset, delegate(int answer)
				{
					if (answer == 1)
					{
						base.Game.Fader.FadeOut(delegate
						{
							base.Game.Exit();
						});
					}
					base.Game.Overlay.Touchable = true;
				});
			}
		});
		_copyright = new CopyrightOverlay(game)
		{
			ShowOptions = ShowOptions
		};
		Clocks.InRealTime = true;
	}

	public override void Start() {}

	public TexturedSequenceLayer AddIndicatorLayer(string name, string textureFormat, int x, int y)
	{
		Texture2D[] textures = new Texture2D[10];
		for (int i = 0; i < textures.Length; i++)
		{
			textures[i] = base.Game.Content.Load<Texture2D>(string.Format(textureFormat, i));
		}
		TexturedSequenceLayer layer = new TexturedSequenceLayer(this, name, textures)
		{
			Removable = true,
			X = x,
			Y = y
		};
		AddLayer(layer, OrderForeground);
		_segments.Add(layer);
		return layer;
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		_blinking -= gameTime.ElapsedGameTime.Milliseconds;
		if (_blinking < 0)
		{
			_separator.Visible = !_separator.Visible;
			_blinking = TickingDelay;
		}
		_segments[0].State = DateTime.Now.Hour / 10;
		_segments[1].State = DateTime.Now.Hour % 10;
		_segments[2].State = DateTime.Now.Minute / 10;
		_segments[3].State = DateTime.Now.Minute % 10;
		if (base.Game.Overlay != null)
		{
			_copyright.Touchable = base.Game.Overlay.Touchable;
			_copyright.Update(gameTime);
		}
	}

	public void DrawPlayer(SpriteBatch spriteBatch)
	{
		if (PlayerPreferences.Singleton.PlayerSkin != null)
		{
			spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, null, null, null, null, Matrix.CreateTranslation(-100f, -390f, 0f) * Matrix.CreateRotationZ((float)Math.Sin(Utils.Date) * MathHelper.ToRadians(5f)) * Matrix.CreateTranslation(90f, 390f, 0f));
			PlayerPreferences.Singleton.PlayerSkin.Draw(spriteBatch);
			spriteBatch.End();
		}
	}

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		base.DrawOverlay(spriteBatch);
		spriteBatch.Begin();
		_logotype.Draw(spriteBatch);
		spriteBatch.End();
		_copyright.Draw(spriteBatch);
	}

	private void ShowOptions()
	{
		base.Game.Overlay.Touchable = false;
		int offset = 0;
		if (Censorship.Booties)
		{
			offset += 60;
		}
		if (!Censorship.Censored)
		{
			offset += 60;
		}
		Window container = new Window
		{
			Dock = DockStyle.Center,
			Size = new Squid.Point(512, 540 + offset),
			Margin = new Margin(8),
			Padding = new Margin(8)
		};
		Panel content = new Panel
		{
			Dock = DockStyle.Fill,
			Margin = new Margin(8)
		};
		container.Controls.Add(content);
		Label graphicsLabel = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Display"
		};
		Label resolutionLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = "Resolutions"
		};
		DropDownList resolutionDropDown = new DropDownList();
		resolutionDropDown.Dock = DockStyle.Top;
		resolutionDropDown.Style = "button";
		resolutionDropDown.Label.Margin = new Margin(10, 0, 0, 0);
		resolutionDropDown.Dropdown.Resizable = false;
		resolutionDropDown.Margin = new Margin(0, 0, 0, 5);
		resolutionDropDown.Listbox.Scrollbar.ButtonUp.Visible = false;
		resolutionDropDown.Listbox.Scrollbar.ButtonDown.Visible = false;
		int canvasWidth = base.Game.Canvas.CanvasWidth;
		int canvasHeight = base.Game.Canvas.CanvasHeight;
		foreach (DisplayMode supportedDisplayMode in base.Game.Graphics.Adapter.SupportedDisplayModes)
		{
			resolutionDropDown.Items.Add(new ListBoxItem
			{
				Text = supportedDisplayMode.Width + "x" + supportedDisplayMode.Height,
				Value = supportedDisplayMode,
				Size = new Squid.Point(0, AmorousData.ButtonHeight),
				Selected = (canvasWidth == supportedDisplayMode.Width && canvasHeight == supportedDisplayMode.Height)
			});
		}
		resolutionDropDown.SelectedItemChanged += delegate(Control container, ListBoxItem box)
		{
			if (box.Value is DisplayMode)
			{
				DisplayMode displayMode = box.Value as DisplayMode;
				base.Game.SetDisplay(displayMode.Width, displayMode.Height);
				Options.Data.ResolutionWidth = displayMode.Width;
				Options.Data.ResolutionHeight = displayMode.Height;
				canvasWidth = displayMode.Width;
				canvasHeight = displayMode.Height;
			}
		};
		CheckBox fullscreenBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Fullscreen",
			Checked = base.Game.IsFullscreen
		};
		fullscreenBox.CheckedChanged += delegate
		{
			base.Game.SetDisplay(canvasWidth, canvasHeight, !base.Game.IsFullscreen);
			Options.Data.Fullscreen = base.Game.IsFullscreen;
		};
		content.Content.Controls.Add(graphicsLabel);
		content.Content.Controls.Add(resolutionLabel);
		content.Content.Controls.Add(resolutionDropDown);
		content.Content.Controls.Add(fullscreenBox);
		Label mediaLabel = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Sound"
		};
		Label volumeLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = "Master Volume"
		};
		Slider volumeSlider = new Slider();
		volumeSlider.Dock = DockStyle.Top;
		volumeSlider.Orientation = Orientation.Horizontal;
		volumeSlider.Steps = 100f;
		volumeSlider.Value = Options.Data.MasterVolume * 100f;
		volumeSlider.Style = "scrollSlider";
		volumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		volumeSlider.Button.Style = "scrollSliderButton";
		volumeSlider.ValueChanged += delegate
		{
			Options.Data.MasterVolume = volumeSlider.Value / 100f;
		};
		Label musicVolumeLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = "Music Volume"
		};
		Slider musicVolumeSlider = new Slider();
		musicVolumeSlider.Dock = DockStyle.Top;
		musicVolumeSlider.Orientation = Orientation.Horizontal;
		musicVolumeSlider.Steps = 100f;
		musicVolumeSlider.Value = Options.Data.MusicVolume * 100f;
		musicVolumeSlider.Style = "scrollSlider";
		musicVolumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		musicVolumeSlider.Button.Style = "scrollSliderButton";
		musicVolumeSlider.ValueChanged += delegate
		{
			Options.Data.MusicVolume = musicVolumeSlider.Value / 100f;
		};
		Label soundVolumeLabel = new Label
		{
			Dock = DockStyle.Top,
			Text = "SFX Volume"
		};
		Slider soundVolumeSlider = new Slider();
		soundVolumeSlider.Dock = DockStyle.Top;
		soundVolumeSlider.Orientation = Orientation.Horizontal;
		soundVolumeSlider.Steps = 100f;
		soundVolumeSlider.Value = Options.Data.SfxVolume * 100f;
		soundVolumeSlider.Style = "scrollSlider";
		soundVolumeSlider.Size = new Squid.Point(0, AmorousData.ButtonHeight);
		soundVolumeSlider.Button.Style = "scrollSliderButton";
		soundVolumeSlider.ValueChanged += delegate
		{
			Options.Data.SfxVolume = soundVolumeSlider.Value / 100f;
		};
		content.Content.Controls.Add(mediaLabel);
		content.Content.Controls.Add(volumeLabel);
		content.Content.Controls.Add(volumeSlider);
		content.Content.Controls.Add(musicVolumeLabel);
		content.Content.Controls.Add(musicVolumeSlider);
		content.Content.Controls.Add(soundVolumeLabel);
		content.Content.Controls.Add(soundVolumeSlider);
		Label dialogueLabel = new Label
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Text = "Dialogue"
		};
		content.Content.Controls.Add(dialogueLabel);
		PhoneOverlay.AttachDropDownList(content.Content.Controls, "Text Speed", new string[4] { "Slow", "Normal", "Fast", "Instant" }, (int)Options.Data.DialogueTextSpeed, delegate(int int_0)
		{
			Options.Data.DialogueTextSpeed = (DialogueSpeed)int_0;
			TypingDialogue.Speed = (DialogueSpeed)int_0;
		});
		CheckBox autoSkipBox = new CheckBox
		{
			Dock = DockStyle.Top,
			Text = "Auto-skip",
			Checked = Options.Data.DialogueAutoSkip
		};
		autoSkipBox.CheckedChanged += delegate
		{
			Options.Data.DialogueAutoSkip = autoSkipBox.Checked;
			TypingDialogue.AutoSkip = autoSkipBox.Checked;
		};
		content.Content.Controls.Add(autoSkipBox);
		if (Censorship.Booties)
		{
			Label bootiesLabel = new Label
			{
				Dock = DockStyle.Top,
				TextAlign = Alignment.MiddleCenter,
				Text = "Cheats"
			};
			CheckBox censoredBox = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable SFW-mode",
				Checked = Censorship.Censored
			};
			censoredBox.CheckedChanged += delegate
			{
				Censorship.Censored = censoredBox.Checked;
				container.Close();
				ShowOptions();
			};
			content.Content.Controls.Add(bootiesLabel);
			content.Content.Controls.Add(censoredBox);
		}
		if (!Censorship.Censored)
		{
			CheckBox toplessBox = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable Topless",
				Checked = Censorship.Topless
			};
			toplessBox.CheckedChanged += delegate
			{
				Censorship.Topless = toplessBox.Checked;
			};
			CheckBox bottomlessBox = new CheckBox
			{
				Dock = DockStyle.Top,
				Text = "Enable Bottomless",
				Checked = Censorship.Bottomless
			};
			bottomlessBox.CheckedChanged += delegate
			{
				Censorship.Bottomless = bottomlessBox.Checked;
			};
			content.Content.Controls.Add(toplessBox);
			content.Content.Controls.Add(bottomlessBox);
		}
		Button closeButton = new Button
		{
			Dock = DockStyle.Bottom,
			Text = "Close"
		};
		closeButton.MouseClick += delegate
		{
			base.Game.Overlay.Touchable = true;
			Options.Save();
			container.Close();
		};
		content.Content.Controls.Add(closeButton);
		container.Show(base.Squid);
	}

	public override void End()
	{
		base.End();
		Clocks.InRealTime = false;
	}
}
