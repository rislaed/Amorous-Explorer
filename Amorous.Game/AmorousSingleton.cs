using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Amorous.Engine.NPC;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Newtonsoft.Json;
using SDL2;
using Spine;
using Squid;

public class AmorousSingleton : IAmorous
{ // _bj8iyyk84DtxcxcHgAHHFGgq8oN
	private readonly Game _game;
	private readonly GraphicsDeviceManager _display;
	private SpriteBatch _batch;
	private SkeletonMeshRenderer _spines;
	private CanvasObserver _canvas;
	private RenderTarget2D _target;
	private Microsoft.Xna.Framework.Rectangle _destinationRectangle;
	private ScreenFader _fader;
	private FadingMediaPlayer _media;
	private SpineTextureLoader _resources;
	private ControllerObserver _controller;
	private Notifications _notifier;
	private Achievements _achievements;
	private SteamObserver _steam;
	private Action _pendingSceneThen;
	private AbstractScene _scene;
	private AbstractScene _pendingScene;
	private PlayerPreferences _player;
	private PhoneOverlay _phone;
	private TypingDialogue _writer;
	private Cutscene _cutscene;
	private AbstractSexscene _sexscene;
	private InteractableOverlay _overlay;
	private Texture2D _cursorTexture;
	private SpriteFont _font;

	private bool _hasControls;
	private bool _debugger;
	private bool _pendingScreenshot;

	private static readonly string[] _nonContextualPlaces = new string[8]
	{
		typeof(BedroomScene).Name,
		typeof(LivingRoomScene).Name,
		typeof(ClubBackScene).Name,
		typeof(ClubEntranceScene).Name,
		typeof(ClubInsideScene).Name,
		typeof(ClubLoungeScene).Name,
		typeof(ClubPoolScene).Name,
		typeof(ClubUpstairsScene).Name
	};

	private Microsoft.Xna.Framework.Input.Keys[] _keyboard;
	private string[] _debuggerCutscene;
	private Vector2 _debuggerPoint;

	public GameWindow Window => _game.Window;
	public GraphicsDevice Graphics => _game.GraphicsDevice;
	public ContentManager Content => _game.Content;
	public ControllerObserver Controller => _controller;
	public CanvasObserver Canvas => _canvas;
	public AbstractScene Scene => _scene;
	public AbstractSexscene Sexscene => _sexscene;
	public Cutscene Cutscene => _cutscene;
	public ScreenFader Fader => _fader;
	public InteractableOverlay Overlay => _overlay;
	public IAchievements Achievements => _achievements;
	public bool IsFullscreen => _display.IsFullScreen;
	public bool InPendingScene { get; set; }
	public bool IsRenderingCursor { get; set; }
	public bool IsControlsOnScreen => _hasControls;

	public AmorousSingleton(Game game, bool safemode)
	{
		_game = game;
		Options.Read();
		if (safemode)
		{
			_display = new GraphicsDeviceManager(game)
			{
				IsFullScreen = false,
				PreferredBackBufferWidth = 1024,
				PreferredBackBufferHeight = 768,
				SynchronizeWithVerticalRetrace = true
			};
		}
		else if (!Options.ContainsResolution())
		{
			DisplayMode currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
			_display = new GraphicsDeviceManager(game)
			{
				IsFullScreen = true,
				PreferredBackBufferWidth = currentDisplayMode.Width,
				PreferredBackBufferHeight = currentDisplayMode.Height,
				SynchronizeWithVerticalRetrace = true
			};
		}
		else
		{
			_display = new GraphicsDeviceManager(game)
			{
				IsFullScreen = Options.Data.Fullscreen,
				PreferredBackBufferWidth = Options.Data.ResolutionWidth,
				PreferredBackBufferHeight = Options.Data.ResolutionHeight,
				SynchronizeWithVerticalRetrace = true
			};
		}
		Content.RootDirectory = "Content-Release";
		_game.Content = new CompressableContentManager(Content.ServiceProvider, Content.RootDirectory);
	}

	public void Initialize()
	{
		_game.Disposed += delegate
		{
			Options.Save();
		};
		Gui.GetClipboardCallback = (Func<string>)Delegate.Combine(Gui.GetClipboardCallback, new Func<string>(SDL.SDL_GetClipboardText));
		Gui.SetClipboardCallback = (Action<string>)Delegate.Combine(Gui.SetClipboardCallback, (Action<string>)delegate(string string_0)
		{
			SDL.SDL_SetClipboardText(string_0);
		});
		string pathNonSteam = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NonSteam");
		if (!File.Exists(pathNonSteam) && !File.Exists(pathNonSteam + ".txt"))
		{
			_steam = new SteamObserver();
			if (!_steam.Initialize(AmorousData.Code, this))
			{
				_steam = null;
			}
		}
		_achievements = new Achievements(this, _steam);
	}

	public void LoadContent()
	{
		string bootiesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShowMeSomeBooty");
		Censorship.SetBooties(File.Exists(bootiesPath) || File.Exists(bootiesPath + ".txt"));
		_controller = new ControllerObserver(this);
		_keyboard = (Microsoft.Xna.Framework.Input.Keys[])Enum.GetValues(typeof(Microsoft.Xna.Framework.Input.Keys));
		Controller.Grabbed = true;
		_batch = new SpriteBatch(_game.GraphicsDevice);
		_spines = new SkeletonMeshRenderer(_game.GraphicsDevice);
		_canvas = new CanvasObserver(this, 1920, 1080);
		_canvas.SetResolution(_display.PreferredBackBufferWidth, _display.PreferredBackBufferHeight, _display.PreferredBackBufferWidth, _display.PreferredBackBufferHeight);
		_target = new RenderTarget2D(_game.GraphicsDevice, 1920, 1080);
		_target.SetUsage(RenderTargetUsage.PreserveContents);
		_destinationRectangle = new Microsoft.Xna.Framework.Rectangle(_canvas.RelativeX, _canvas.RelativeY, _canvas.RelativeWidth, _canvas.RelativeHeight);
		Gui.Renderer = new SquidRenderer(_game);
		Gui.Renderer.SetTexture("PhoneScreen", _game.Content.Load<Texture2D>("Assets/GUI/Phone/PhoneScreen"));
		Gui.Renderer.SetTexture("Contact_DJ", _game.Content.Load<Texture2D>("Assets/GUI/Phone/Contacts/DJ"));
		Overlays.WhenReturnToMenu = ReturnToMenu;
		_player = new PlayerPreferences();
		_fader = new ScreenFader(_game.GraphicsDevice);
		_media = new FadingMediaPlayer(_game.Content);
		_resources = new SpineTextureLoader(_game.Content);
		_notifier = new Notifications();
		Texture2D dialogueTexture = _game.Content.Load<Texture2D>("Assets/GUI/Dialogue/dialogue");
		Texture2D buttonTexture = _game.Content.Load<Texture2D>("Assets/GUI/Dialogue/button");
		_cursorTexture = _game.Content.Load<Texture2D>("Assets/GUI/Squid/DefaultCursor");
		IsRenderingCursor = true;
		_font = _game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		SpriteFont italicFont = _game.Content.Load<SpriteFont>("Assets/GUI/Fonts/BoldItalic-26");
		_writer = new TypingDialogue(this, dialogueTexture, buttonTexture, _font, italicFont);
		Saves.Pointer pointer = Saves.GetLastPointer();
		if (!pointer.IsEmpty)
		{
			SaveData save = (pointer.IsAutosave ? Saves.ReadAutosave(pointer.Index) : Saves.Read(pointer.Index));
			if (save != null)
			{
				PlayerPreferences.Singleton.Data = save.PlayerData;
			}
		}
		_phone = new PhoneOverlay(this, _game.Content);
		Clocks.InRealTime = true;
		Clocks.UpdateTime();
		_hasControls = true;
		Gui.Renderer.SetTexture(AmorousData.MessageIconCoby, Content.Load<Texture2D>(AmorousData.AchievementCoby));
		Gui.Renderer.SetTexture(AmorousData.MessageIconDustin, Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Dustin"));
		Gui.Renderer.SetTexture(AmorousData.MessageIconJax, Content.Load<Texture2D>(AmorousData.AchievementJax));
		Gui.Renderer.SetTexture(AmorousData.MessageIconLex, Content.Load<Texture2D>(AmorousData.AchievementLex));
		Gui.Renderer.SetTexture(AmorousData.MessageIconMercy, Content.Load<Texture2D>(AmorousData.AchievementMercy));
		Gui.Renderer.SetTexture(AmorousData.MessageIconRemy, Content.Load<Texture2D>(AmorousData.AchievementRemy));
		Gui.Renderer.SetTexture(AmorousData.MessageIconSeth, Content.Load<Texture2D>(AmorousData.AchievementSeth));
		Gui.Renderer.SetTexture(AmorousData.MessageIconSkye, Content.Load<Texture2D>(AmorousData.AchievementSkye));
		Gui.Renderer.SetTexture(AmorousData.MessageIconZenith, Content.Load<Texture2D>(AmorousData.AchievementZenith));
		Gui.Renderer.SetTexture(AmorousData.MessageIconGeneric, Content.Load<Texture2D>(AmorousData.AchievementGeneric));
		Gui.Renderer.SetTexture(AmorousData.MessageIconDJ, Content.Load<Texture2D>(AmorousData.AchievementDJ));
		Gui.Renderer.SetTexture(AmorousData.MessageIconShootingRange, Content.Load<Texture2D>(AmorousData.AchievementShootingRange));
		Gui.Renderer.SetTexture(AmorousData.MessageIconCooking, Content.Load<Texture2D>(AmorousData.AchievementCooking));
		Start();
	}

	protected virtual void Start()
	{
		_scene = new EmptyScene(this);
		Fader.ApplyNow(new Color(0, 0, 0, 255));
		SwitchToScene<MainMenuScene>(delegate
		{
			Fader.FadeIn();
		});
	}

	public void UnloadContent()
	{
	}

	public void Update(GameTime gameTime)
	{
		if (InPendingScene && _pendingScene == null)
		{
			InPendingScene = false;
			if (_pendingSceneThen != null)
			{
				Action action = _pendingSceneThen;
				_pendingSceneThen = null;
				action();
			}
		}
		_controller.Update();
		if (Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.F1))
		{
			_hasControls = !_hasControls;
		}
		if ((Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) || Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.F2))
		{
			RefreshDisplay();
		}
		if (_steam == null && (Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.F12) || Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.PrintScreen)))
		{
			RequestScreenshot();
		}
		if (Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Tab))
		{
			_debugger = !_debugger;
		}
		_canvas.Update(gameTime);
		_fader.Update(gameTime);
		_media.Update(gameTime);
		_media.InterpolateVolume();
		if (_pendingScene != null)
		{
			if (_scene != null)
			{
				Logger.Log(ConsoleColor.White, "Debug", "Changing to pending scene '{0}' -> '{1}'", _scene.GetType().Name, _pendingScene.GetType().Name);
				_scene.End();
			}
			else
			{
				Logger.Log(ConsoleColor.White, "Debug", "Starting pending scene '{0}'", _pendingScene.GetType().Name);
			}
			_scene = _pendingScene;
			_pendingScene = null;
			_scene.Start();
		}
		_scene.Update(gameTime);
		_player.Update(gameTime);
		_phone.Update(gameTime, _canvas);
		_writer.Update(gameTime);
		if (_cutscene != null)
		{
			_cutscene.Update(gameTime);
			if (!_cutscene.Active)
			{
				_debuggerCutscene = _cutscene.ToString(5);
				Logger.Log(ConsoleColor.White, "Debug", "Finishing cutscene '{0}' ({1})", _cutscene.Data.Name, string.Join(", ", _debuggerCutscene).Trim(new char[] { ' ', ',' }));
				_cutscene = null;
			}
		}
		if (_sexscene != null)
		{
			_sexscene.Update(gameTime);
		}
		if (_overlay != null)
		{
			_overlay.Update(gameTime);
		}
		_notifier.Update(gameTime);
		Microsoft.Xna.Framework.Point point = _canvas.GlobalToContent(Controller.Cursor);
		List<KeyData> list = new List<KeyData>();
		foreach (Microsoft.Xna.Framework.Input.Keys keys in _keyboard)
		{
			bool pressed = Controller.IsPressed(keys);
			bool released = Controller.IsReleasing(keys);
			if (pressed || released)
			{
				Squid.Keys? availables = SquidDesktop.Keys[Keyboard.GetKeyFromScancodeEXT(keys)];
				if (availables.HasValue)
				{
					list.Add(new KeyData
					{
						Scancode = (int)availables.Value,
						Char = keys.ChangeKeyboard(Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.LeftShift) || Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.RightShift)),
						Pressed = pressed,
						Released = released
					});
				}
			}
		}
		Gui.SetKeyboard(list.ToArray());
		Gui.SetButtons(Controller.IsHolding(ControllerButtonType.LeftButton), Controller.IsHolding(ControllerButtonType.RightButton));
		Gui.SetMouse(point.X, point.Y, Controller.Scroll);
		Gui.TimeElapsed = gameTime.ElapsedGameTime.Milliseconds;
		if (_steam != null)
		{
			_steam.Update();
		}
	}

	public void Draw(GameTime gameTime)
	{
		Utils.Date = (float)gameTime.TotalGameTime.TotalSeconds;
		_game.GraphicsDevice.SetRenderTarget(_target);
		_game.GraphicsDevice.Clear(Color.Black);
		_scene.Draw(_batch, _spines, _canvas.OverscrollNoneMatrix);
		if (_canvas.OverscrollRight)
		{
			_scene.Draw(_batch, _spines, _canvas.OverscrollRightMatrix);
		}
		else if (_canvas.OverscrollLeft)
		{
			_scene.Draw(_batch, _spines, _canvas.OverscrollLeftMatrix);
		}
		if (_sexscene != null)
		{
			_sexscene.Draw(_batch, _spines);
		}
		if (_hasControls)
		{
			_phone.Draw(_batch, _spines);
		}
		if (_overlay != null)
		{
			_overlay.Draw(_batch);
		}
		_scene.DrawOverlay(_batch);
		_fader.Draw(_batch, _canvas);
		if (_hasControls)
		{
			_writer.Draw(_batch);
		}
		_notifier.Draw(_batch);
		if (_debugger)
		{
			object sceneName = null;
			if (_cutscene != null)
			{
				_debuggerCutscene = _cutscene.ToString(5);
			}
			_debuggerPoint.X = 10f;
			_debuggerPoint.Y = 10f;
			_batch.Begin();
			_batch.DrawString(_font, "[Generic]", _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			if (_scene != null)
			{
				sceneName = _scene.GetType().Name;
			}
			if (sceneName == null)
			{
				sceneName = "None";
			}
			_batch.DrawString(_font, "Scene: " + sceneName, _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			_batch.DrawString(_font, "ScreenFader: " + _fader.State.A, _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			_debuggerPoint.Y += 40f;
			_batch.DrawString(_font, "[Cutscenes]", _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			_batch.DrawString(_font, string.Format("Cutscene in progress: {0}", (_cutscene == null) ? "No" : "Yes"), _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			if (_debuggerCutscene != null)
			{
				_batch.DrawString(_font, "Cutscene: " + _debuggerCutscene[0], _debuggerPoint, Color.White);
				_debuggerPoint.Y += 40f;
				_batch.DrawString(_font, "Stage: " + _debuggerCutscene[1], _debuggerPoint, Color.White);
				_debuggerPoint.Y += 40f;
				_batch.DrawString(_font, "Path: " + _debuggerCutscene[2], _debuggerPoint, Color.White);
				_debuggerPoint.Y += 40f;
				_batch.DrawString(_font, "Current: " + _debuggerCutscene[3], _debuggerPoint, Color.White);
				_debuggerPoint.Y += 40f;
			}
			else
			{
				_batch.DrawString(_font, "Cutscene: None", _debuggerPoint, Color.White);
				_debuggerPoint.Y += 40f;
			}
			_debuggerPoint.Y += 40f;
			_batch.DrawString(_font, "Press Tab to toggle", _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			_batch.End();
		}
		if (_pendingScreenshot)
		{
			_pendingScreenshot = false;
			if (!Directory.Exists("Screenshots"))
			{
				Directory.CreateDirectory("Screenshots");
			}
			string screenshotDirectory = $"Screenshots/screenshot-{DateTime.Now.DayOfYear}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.png";
			string screenshotPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, screenshotDirectory);
			using (Stream stream = File.OpenWrite(screenshotPath))
			{
				_target.SaveAsPng(stream, _canvas.Width, _canvas.Height);
			}
			if (_steam != null)
			{
				_steam.AddScreenshotToLibrary(screenshotPath, _canvas.Width, _canvas.Height);
			}
			if (_debugger && _debuggerCutscene != null)
			{
				string scenePath = $"{screenshotPath}.txt";
				object sceneName = null;
				if (_scene != null)
				{
					sceneName = _scene.GetType().Name;
				}
				if (sceneName == null)
				{
					sceneName = "None";
				}
				object[] sceneInformation = new object[5];
				sceneInformation[0] = sceneName;
				sceneInformation[1] = _debuggerCutscene[0];
				sceneInformation[2] = _debuggerCutscene[1];
				sceneInformation[3] = _debuggerCutscene[2];
				sceneInformation[4] = _debuggerCutscene[3];
				File.WriteAllText(scenePath, string.Format("Scene: {0}\r\nCutscene: {1}\r\nStage: {2}\r\nPath: {3}\r\nCurrent: {4}", sceneInformation));
			}
		}
		_game.GraphicsDevice.SetRenderTarget(null);
		_game.GraphicsDevice.Clear(Color.Black);
		_batch.Begin();
		_batch.Draw(_target, _destinationRectangle, Color.White);
		if (IsRenderingCursor)
		{
			_batch.Draw(_cursorTexture, Controller.CursorVector, _player.Data.PhoneColor);
		}
		_batch.End();
	}

	public void RefreshDisplay()
	{
		SetDisplay(_canvas.CanvasWidth, _canvas.CanvasHeight, !_display.IsFullScreen);
	}

	public void RequestScreenshot()
	{
		_pendingScreenshot = true;
	}

	public bool OpenUrl(string url)
	{
		if (_steam == null)
		{
			try
			{
				Process.Start(url);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		_steam.OpenUrl(url);
		return true;
	}

	public void SetDisplay(int width, int height)
	{
		SetDisplay(width, height, _display.IsFullScreen);
	}

	public void SetDisplay(int width, int height, bool fullscreen)
	{
		_display.IsFullScreen = fullscreen;
		_display.PreferredBackBufferWidth = (fullscreen ? GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width : width);
		_display.PreferredBackBufferHeight = (fullscreen ? GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height : height);
		_display.GraphicsDevice.Viewport = new Viewport(0, 0, _display.PreferredBackBufferWidth, _display.PreferredBackBufferHeight);
		_canvas.SetResolution(width, height, _display.PreferredBackBufferWidth, _display.PreferredBackBufferHeight);
		_destinationRectangle = new Microsoft.Xna.Framework.Rectangle(_canvas.RelativeX, _canvas.RelativeY, _canvas.RelativeWidth, _canvas.RelativeHeight);
		_display.ApplyChanges();
	}

	public void Exit()
	{
		_game.Exit();
	}

	public void StartScene<T>() where T : AbstractScene
	{
		_fader.FadeOut(delegate
		{
			SwitchToScene<T>(delegate
			{
				_fader.FadeIn();
			});
		});
	}

	public void StartScene(string name)
	{
		_fader.FadeOut(delegate
		{
			SwitchToScene(name, delegate
			{
				_fader.FadeIn();
			});
		});
	}

	public void StartScene(AbstractScene scene)
	{
		_fader.FadeOut(delegate
		{
			SwitchToScene(scene, delegate
			{
				_fader.FadeIn();
			});
		});
	}

	public void SwitchToScene<T>(Action then = null) where T : AbstractScene
	{
		if (_pendingSceneThen != null)
		{
			Action action = _pendingSceneThen;
			_pendingSceneThen = null;
			action();
		}
		_pendingSceneThen = then;
		_canvas.ResetOverscroll();
		PlayerPreferences.SetPlayerOverlay(null);
		_overlay = null;
		_sexscene = null;
		_pendingScene = Activator.CreateInstance(typeof(T), this) as AbstractScene;
		InPendingScene = true;
	}

	public void SwitchToScene(string name, Action then = null)
	{
		if (_pendingSceneThen != null)
		{
			Action action = _pendingSceneThen;
			_pendingSceneThen = null;
			action();
		}
		_pendingSceneThen = then;
		IEnumerable<Type> source = from scene in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
			where typeof(AbstractScene).IsAssignableFrom(scene)
			select scene;
		Type type = source.FirstOrDefault((Type scene) => scene.Name == name);
		if (!(type == null))
		{
			_canvas.ResetOverscroll();
			PlayerPreferences.SetPlayerOverlay(null);
			_overlay = null;
			_sexscene = null;
			_pendingScene = Activator.CreateInstance(type, this) as AbstractScene;
			InPendingScene = true;
		}
		else
		{
			Logger.Error("Failed to load scene '{0}'", name);
		}
	}

	public void SwitchToScene(AbstractScene scene, Action then = null)
	{
		if (_pendingSceneThen != null)
		{
			Action action = _pendingSceneThen;
			_pendingSceneThen = null;
			action();
		}
		_pendingSceneThen = then;
		_canvas.ResetOverscroll();
		PlayerPreferences.SetPlayerOverlay(null);
		_overlay = null;
		_sexscene = null;
		_pendingScene = scene;
		InPendingScene = true;
	}

	public void PlaySexscene(string name)
	{
		IEnumerable<Type> source = from sexscene in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
			where typeof(AbstractSexscene).IsAssignableFrom(sexscene)
			select sexscene;
		Type type = source.FirstOrDefault((Type sexscene) => sexscene.Name == name);
		if (!(type == null))
		{
			if (_sexscene != null)
			{
				Logger.Log(ConsoleColor.White, "Debug", "Changing to sexscene '{0}' -> '{1}'", _sexscene.GetType().Name, type.Name);
			}
			else
			{
				Logger.Log(ConsoleColor.White, "Debug", "Starting sexscene '{0}'", type.Name);
			}
			_sexscene = Activator.CreateInstance(type, _game.Content) as AbstractSexscene;
		}
		else
		{
			Logger.Error("Failed to load sexscene '{0}'", name);
		}
	}

	public void ResetSexscene()
	{
		_sexscene = null;
	}

	public void PlayCutscene(string name)
	{
		PlayCutscene(ReadCutscene(name));
	}

	public void PlayCutscene(Cutscene cutscene)
	{
		if (cutscene != null)
		{
			if (_cutscene != null)
			{
				Logger.Log(ConsoleColor.White, "Debug", "Changing to cutscene '{0}' -> '{1}'", _cutscene.Data.Name, cutscene.Data.Name);
			}
			else
			{
				Logger.Log(ConsoleColor.White, "Debug", "Starting cutscene '{0}'", cutscene.Data.Name);
			}
			_cutscene = cutscene;
			int stage = _player.Data.GetState(cutscene.Data.Name);
			PhoneOverlay.Hide();
			_cutscene.Start(stage);
		}
	}

	private Cutscene ReadCutscene(string name)
	{
		string path = Path.Combine(Content.RootDirectory, $"Content-Mods/Data/Quests/{name}.json");
		if (!File.Exists(path))
		{
			path = Path.Combine(Content.RootDirectory, $"Data/Quests/{name}.json");
			if (!File.Exists(path))
			{
				Logger.Error("Failed to load cutscene '{0}'", name);
				return null;
			}
		}
		string json = Compressions.ReadStreamAsText(path);
		JsonSerializerSettings settings = new JsonSerializerSettings
		{
			TypeNameHandling = TypeNameHandling.Auto,
			Converters = { (JsonConverter)new ColorJsonConverter() }
		};
		CutsceneData data = JsonConvert.DeserializeObject<CutsceneData>(json, settings);
		if (data != null)
		{
			return new Cutscene(this, data, Assembly.Load("Amorous.Game"));
		}
		return null;
	}

	private CutsceneState GetCutsceneState()
	{
		if (Cutscene != null)
		{
			CutsceneState state = new CutsceneState
			{
				Name = Cutscene.Data.Name,
				Stage = Cutscene.State.Data.Stage,
				ID = Cutscene.State.State.ID,
				Scene = Scene.GetType().Name,
				Subscene = Scene.Subscene,
				Sexscene = Sexscene?.GetType().Name,
				SexscenePhase = (Sexscene?.State ?? AbstractSexscene.Phase.Idle),
				SexsceneFinished = (Sexscene?.Exploded ?? false),
				FadedOut = (Fader.State.A > 0)
			};
			state.SaveNPCLayer(_scene.GetNPCLayer(NPCLocation.Left));
			state.SaveNPCLayer(_scene.GetNPCLayer(NPCLocation.Middle));
			state.SaveNPCLayer(_scene.GetNPCLayer(NPCLocation.Right));
			return state;
		}
		return null;
	}

	private void LoadCutscene(CutsceneState state)
	{
		Fader.FadeOut(delegate
		{
			Cutscene cutscene = ReadCutscene(state.Name);
			if (cutscene != null)
			{
				SwitchToScene(state.Scene, delegate
				{
					if (state.Subscene != null)
					{
						Scene.SwitchToSubscene(state.Subscene);
					}
					if (state.Sexscene != null)
					{
						PlaySexscene(state.Sexscene);
						Sexscene.LoadPhase(state.SexscenePhase, state.SexsceneFinished);
					}
					foreach (CutsceneState.NPCState item in state.NPCs)
					{
						AbstractNPC npc = GetNPCLayerAt(item.Name, LayerOrder.Background);
						npc.Apply(item.Location, item.Head, item.Pose, item.Clothes);
						NPCLayer NPCLayer = _scene.GetNPCLayer(item.Name);
						NPCLayer.LayerOrder = item.LayerOrder;
					}
					if (state.FadedOut)
					{
						_cutscene = cutscene;
						_cutscene.Start(state.Stage, state.ID);
					}
					else
					{
						Fader.FadeIn(delegate
						{
							_cutscene = cutscene;
							_cutscene.Start(state.Stage, state.ID);
						});
					}
				});
			}
		});
	}

	public void Autosave()
	{
		AutosaveAtSlot(0);
		ResetInGameDrawing();
		_scene.Autosave();
	}

	public void SetOverlay<T>() where T : InteractableOverlay
	{
		_overlay = Activator.CreateInstance(typeof(T), this) as InteractableOverlay;
	}

	public void SetOverlay<T>(T overlay) where T : InteractableOverlay
	{
		_overlay = overlay;
	}

	public void ResetOverlay()
	{
		_overlay = null;
	}

	public AbstractNPC GetNPCLayer(string name)
	{
		if (_scene == null)
		{
			return null;
		}
		return _scene.GetNPCLayer(name)?.NPC;
	}

	public AbstractNPC GetNPCLayer(NPCLocation location)
	{
		if (_scene == null)
		{
			return null;
		}
		return _scene.GetNPCLayer(location)?.NPC;
	}

	public AbstractNPC GetNPCLayerAt(string name, LayerOrder order)
	{
		if (_scene != null)
		{
			NPCLayer NPCLayer = _scene.GetNPCLayer(name);
			if (NPCLayer == null)
			{
				IEnumerable<Type> source = from npc in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
					where typeof(AbstractNPC).IsAssignableFrom(npc) && !npc.IsAbstract
					select npc;
				Type type = source.FirstOrDefault((Type npc) => npc.Name == name);
				if (!(type == null))
				{
					if (Activator.CreateInstance(type, this) is AbstractNPC npc)
					{
						npc.Game = this;
						npc.Start();
						_scene.AddNPC(npc, (order == LayerOrder.None) ? LayerOrder.Background : order);
						return npc;
					}
					Logger.Error("Failed to instance npc '{0}'", name);
					return null;
				}
				Logger.Error("Failed to load npc '{0}'", name);
				return null;
			}
			AbstractNPC NPC = NPCLayer.NPC;
			if (NPC != null && NPC.LockedInLayer)
			{
				return null;
			}
			NPCLayer.Layer = ((order == LayerOrder.None) ? NPCLayer.Layer : order);
			NPCLayer.ZOrder = ((NPCLayer.Layer == LayerOrder.Background) ? 1 : 3);
			_scene.RefreshLayerOrdering();
			return NPCLayer.NPC;
		}
		return null;
	}

	public T GetNPCLayerAt<T>(LayerOrder order) where T : AbstractNPC
	{
		return GetNPCLayerAt(typeof(T).Name, order) as T;
	}

	public void SaveAtSlot(int slot)
	{
		Saves.Save(slot, new SaveData
		{
			Version = SavesMigration.CurrentlyVersion,
			PlayerData = _player.Data,
			CutsceneState = GetCutsceneState(),
			SceneName = _scene.GetType().Name,
			PhoneEnabled = PhoneOverlay.Enabled
		});
	}

	public void AutosaveAtSlot(int slot)
	{
		Saves.Autosave(slot, new SaveData
		{
			Version = SavesMigration.CurrentlyVersion,
			PlayerData = _player.Data,
			SceneName = _scene.GetType().Name,
			PhoneEnabled = PhoneOverlay.Enabled
		});
	}

	public bool ReadFromSlot(int slot)
	{
		ResetInGameDrawing();
		SaveData save = Saves.Read(slot);
		if (save != null)
		{
			SavesMigration.RestoreSaveData(save);
			_player.Data = save.PlayerData;
			PhoneOverlay.Enabled = save.PhoneEnabled;
			PhoneOverlay.Get().RefreshSkin();
			TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
			TypingDialogue.AutoSkip = Options.Data.DialogueAutoSkip;
			if (save.CutsceneState != null)
			{
				LoadCutscene(save.CutsceneState);
			}
			else
			{
				if (!_nonContextualPlaces.Contains(save.SceneName))
				{
					save.SceneName = typeof(ClubInsideScene).Name;
				}
				if (!SavesMigration.StartMigration(this, save))
				{
					StartScene(save.SceneName);
				}
			}
			return true;
		}
		return false;
	}

	public bool ReadFromAutosaveSlot(int slot)
	{
		ResetInGameDrawing();
		SaveData save = Saves.ReadAutosave(slot);
		if (save != null)
		{
			SavesMigration.RestoreSaveData(save);
			_player.Data = save.PlayerData;
			PhoneOverlay.Enabled = save.PhoneEnabled;
			PhoneOverlay.Get().RefreshSkin();
			TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
			TypingDialogue.AutoSkip = Options.Data.DialogueAutoSkip;
			if (!_nonContextualPlaces.Contains(save.SceneName))
			{
				save.SceneName = typeof(ClubInsideScene).Name;
			}
			if (!SavesMigration.StartMigration(this, save))
			{
				StartScene(save.SceneName);
			}
			return true;
		}
		return false;
	}

	public void ShowMessage(string icon, string title, string message)
	{
		PlayerPreferences.GetPlayerData().Messages.Add(new PhoneMessage
		{
			Icon = icon,
			Title = title,
			Message = message,
			Date = DateTime.Now
		});
		_notifier.ShowMessage(icon, title, message);
	}

	private void ReturnToMenu()
	{
		ResetInGameDrawing();
		StartScene<MainMenuScene>();
	}

	private void ResetInGameDrawing()
	{
		if (Cutscene != null)
		{
			Cutscene.ResetState();
		}
		PhoneOverlay.Hide();
		PhoneOverlay.Get().ResetState();
		TypingDialogue.Unselect();
		TypingDialogue.Complete();
		_fader.ApplyNow(new Color(0, 0, 0, 0));
	}
}
