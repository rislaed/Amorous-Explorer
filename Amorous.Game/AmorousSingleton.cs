using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
// using Amorous.Engine.GUI;
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
{
	private readonly Game _game;
	private readonly GraphicsDeviceManager _display;
	private SpriteBatch _batch;
	private SkeletonMeshRenderer _spines;
	private MouseObserver _mouse;
	private RenderTarget2D _canvas;
	private Microsoft.Xna.Framework.Rectangle _destinationRectangle;
	private ScreenFader _fader;
	private FadingMediaPlayer _media;
	private ExtendedTextureLoader _resources;
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
	private string[] _debuggerCutsceneStates;
	private Vector2 _debuggerPoint;

	public GameWindow Window => _game.Window;
	public GraphicsDevice GLES => _game.GraphicsDevice;
	public ContentManager Content => _game.Content;
	public ControllerObserver Controller => _controller;
	public MouseObserver Mouse => _mouse;
	public AbstractScene Scene => _scene;
	public AbstractSexscene Sexscene => _sexscene;
	public Cutscene Cutscene => _cutscene;
	public ScreenFader Fading => _fader;
	public InteractableOverlay Overlay => _overlay;
	public IAchievements Achievements => _achievements;
	public bool IsFullscreen => _display.IsFullScreen;
	public bool InScenePending { get; set; }
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
		_game.Content = new ExtendedContentManager(Content.ServiceProvider, Content.RootDirectory);
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
			if (!_steam.Initialize(778700u, this))
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
		_mouse = new MouseObserver(this, 1920, 1080);
		_mouse.SetResolution(_display.PreferredBackBufferWidth, _display.PreferredBackBufferHeight, _display.PreferredBackBufferWidth, _display.PreferredBackBufferHeight);
		_canvas = new RenderTarget2D(_game.GraphicsDevice, 1920, 1080);
		_canvas.SetUsage(RenderTargetUsage.PreserveContents);
		_destinationRectangle = new Microsoft.Xna.Framework.Rectangle(_mouse.RelativeX, _mouse.RelativeY, _mouse.RelativeWidth, _mouse.RelativeHeight);
		Gui.Renderer = new SquidRenderer(_game);
		Gui.Renderer.SetTexture("PhoneScreen", _game.Content.Load<Texture2D>("Assets/GUI/Phone/PhoneScreen"));
		Gui.Renderer.SetTexture("Contact_DJ", _game.Content.Load<Texture2D>("Assets/GUI/Phone/Contacts/DJ"));
		Confirmations.WhenReturnToMenu = ReturnToMenu;
		_player = new PlayerPreferences();
		_fader = new ScreenFader(_game.GraphicsDevice);
		_media = new FadingMediaPlayer(_game.Content);
		_resources = new ExtendedTextureLoader(_game.Content);
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
		Gui.Renderer.SetTexture("MessageIconCoby", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Coby"));
		Gui.Renderer.SetTexture("MessageIconDustin", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Dustin"));
		Gui.Renderer.SetTexture("MessageIconJax", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Jax"));
		Gui.Renderer.SetTexture("MessageIconLex", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Lex"));
		Gui.Renderer.SetTexture("MessageIconMercy", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Mercy"));
		Gui.Renderer.SetTexture("MessageIconRemy", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Remy"));
		Gui.Renderer.SetTexture("MessageIconSeth", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Seth"));
		Gui.Renderer.SetTexture("MessageIconSkye", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Skye"));
		Gui.Renderer.SetTexture("MessageIconZenith", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Zenith"));
		Gui.Renderer.SetTexture("MessageIconGeneric", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Generic"));
		Gui.Renderer.SetTexture("MessageIconDJ", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_DJ"));
		Gui.Renderer.SetTexture("MessageIconShootingRange", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_ShootingRange"));
		Gui.Renderer.SetTexture("MessageIconCooking", Content.Load<Texture2D>("Assets/GUI/Achievements/Achievement_Cooking"));
		Begin();
	}

	protected virtual void Begin()
	{
		_scene = new EmptyScene(this);
		Fading.ApplyNow(new Color(0, 0, 0, 255));
		SwitchScene<MainMenuScene>(delegate
		{
			Fading.Hide();
		});
	}

	public void UnloadContent() {}

	public void Update(GameTime gameTime)
	{
		if (InScenePending && _pendingScene == null)
		{
			InScenePending = false;
			if (_pendingSceneThen != null)
			{
				Action action = _pendingSceneThen;
				_pendingSceneThen = null;
				action();
			}
		}
		_controller.Update();
		if (Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.F1))
		{
			_hasControls = !_hasControls;
		}
		if ((Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) || Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.F2))
		{
			RefreshDisplay();
		}
		if (_steam == null && (Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.F12) || Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.PrintScreen)))
		{
			RequestScreenshot();
		}
		if (Controller.JustPressed(Microsoft.Xna.Framework.Input.Keys.Tab))
		{
			_debugger = !_debugger;
		}
		_mouse.Update(gameTime);
		_fader.Update(gameTime);
		_media.Update(gameTime);
		_media._LcX2y4hMIzQST4uGT2Q5Ce7vaGg();
		if (_pendingScene != null)
		{
			if (_scene != null)
			{
				Logger.Log(ConsoleColor.White, "Debug", "Changing to pending scene '{0}' -> '{1}'", _scene.GetType().Name, _pendingScene.GetType().Name);
				_scene.End();
			} else {
				Logger.Log(ConsoleColor.White, "Debug", "Starting pending scene '{0}'", _pendingScene.GetType().Name);
			}
			_scene = _pendingScene;
			_pendingScene = null;
			_scene.Begin();
		}
		_scene.Update(gameTime);
		_player.Update(gameTime);
		_phone.Update(gameTime, _mouse);
		_writer.Update(gameTime);
		if (_cutscene != null)
		{
			_cutscene.Update(gameTime);
			if (!_cutscene.Active)
			{
				_debuggerCutsceneStates = _cutscene.ToString(5);
				Logger.Log(ConsoleColor.White, "Debug", "Finishing cutscene '{0}' ({1})", _cutscene.Data.Name, string.Join(", ", _debuggerCutsceneStates).Trim(new char[] { ' ', ',' }));
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
		Microsoft.Xna.Framework.Point point = _mouse.Rescale(Controller.Cursor);
		List<KeyData> list = new List<KeyData>();
		foreach (Microsoft.Xna.Framework.Input.Keys keys in _keyboard)
		{
			bool pressed = Controller.JustPressed(keys);
			bool released = Controller.JustReleased(keys);
			if (pressed || released)
			{
				Squid.Keys? availables = SquidUtils._HSj1lr89AFIB9adVhSrAeWjS1xC[Keyboard.GetKeyFromScancodeEXT(keys)];
				if (availables.HasValue)
				{
					list.Add(new KeyData
					{
						Scancode = (int)availables.Value,
						Char = keys.ChangeKeyboard(Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.LeftShift) || Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.RightShift)),
						Pressed = pressed,
						Released = released
					});
				}
			}
		}
		Gui.SetKeyboard(list.ToArray());
		Gui.SetButtons(Controller.IsPressed(ControllerButtonType.LeftButton), Controller.IsPressed(ControllerButtonType.RightButton));
		Gui.SetMouse(point.X, point.Y, Controller.Scroll);
		Gui.TimeElapsed = gameTime.ElapsedGameTime.Milliseconds;
		if (_steam != null)
		{
			_steam.Update();
		}
	}

	public void Draw(GameTime gameTime)
	{
		Randoms.Time = (float)gameTime.TotalGameTime.TotalSeconds;
		_game.GraphicsDevice.SetRenderTarget(_canvas);
		_game.GraphicsDevice.Clear(Color.Black);
		_scene.Draw(_batch, _spines, _mouse._oLRK3f26Sw9AKBKi0iR44APDZEt);
		if (_mouse._q1DGEI79OguKnK8dCIgPvfGc9Bi)
		{
			_scene.Draw(_batch, _spines, _mouse._00mMjYnrMXUVj1aA8AYlqz1bdTI);
		}
		else if (_mouse._c3CMfxjIJAFFcSeEIluZOLANXnE)
		{
			_scene.Draw(_batch, _spines, _mouse._MPYpHIXdfUjJipVgAvBCGASJZiZ);
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
		_fader.Draw(_batch, _mouse);
		if (_hasControls)
		{
			_writer.Draw(_batch);
		}
		_notifier.Draw(_batch);
		object obj;
		if (_debugger)
		{
			if (_cutscene != null)
			{
				_debuggerCutsceneStates = _cutscene.ToString(5);
			}
			_debuggerPoint.X = 10f;
			_debuggerPoint.Y = 10f;
			_batch.Begin();
			_batch.DrawString(_font, "[Generic]", _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			AbstractScene scene = _scene;
			if (scene == null)
			{
				obj = null;
			}
			else
			{
				obj = scene.GetType().Name;
				if (obj != null)
				{
					goto IL_0220;
				}
			}
			obj = "None";
			goto IL_0220;
		}
		goto IL_04d3;
		IL_0220:
		#nullable enable
		_batch.DrawString(_font, "Scene: " + (string?)obj, _debuggerPoint, Color.White);
		#nullable restore
		_debuggerPoint.Y += 40f;
		_batch.DrawString(_font, "ScreenFader: " + _fader.State.A, _debuggerPoint, Color.White);
		_debuggerPoint.Y += 40f;
		_debuggerPoint.Y += 40f;
		_batch.DrawString(_font, "[Cutscenes]", _debuggerPoint, Color.White);
		_debuggerPoint.Y += 40f;
		_batch.DrawString(_font, string.Format("Cutscene in progress: {0}", (_cutscene == null) ? "No" : "Yes"), _debuggerPoint, Color.White);
		_debuggerPoint.Y += 40f;
		if (_debuggerCutsceneStates != null)
		{
			_batch.DrawString(_font, "Cutscene: " + _debuggerCutsceneStates[0], _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			_batch.DrawString(_font, "Stage: " + _debuggerCutsceneStates[1], _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			_batch.DrawString(_font, "Path: " + _debuggerCutsceneStates[2], _debuggerPoint, Color.White);
			_debuggerPoint.Y += 40f;
			_batch.DrawString(_font, "Current: " + _debuggerCutsceneStates[3], _debuggerPoint, Color.White);
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
		goto IL_04d3;
		IL_065c:
		_game.GraphicsDevice.SetRenderTarget(null);
		_game.GraphicsDevice.Clear(Color.Black);
		_batch.Begin();
		_batch.Draw(_canvas, _destinationRectangle, Color.White);
		if (IsRenderingCursor)
		{
			_batch.Draw(_cursorTexture, Controller.CursorVector, _player.Data.PhoneColor);
		}
		_batch.End();
		return;
		IL_04d3:
		string path2;
		object[] array;
		object obj2;
		if (_pendingScreenshot)
		{
			_pendingScreenshot = false;
			if (!Directory.Exists("Screenshots"))
			{
				Directory.CreateDirectory("Screenshots");
			}
			string path = $"Screenshots/screenshot-{DateTime.Now.DayOfYear}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.png";
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
			using (Stream stream = File.OpenWrite(text))
			{
				_canvas.SaveAsPng(stream, _canvas.Width, _canvas.Height);
			}
			if (_steam != null)
			{
				_steam.AddScreenshotToLibrary(text, _canvas.Width, _canvas.Height);
			}
			if (_debugger && _debuggerCutsceneStates != null)
			{
				path2 = $"{text}.txt";
				array = new object[5];
				AbstractScene scene = _scene;
				if (scene == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = scene.GetType().Name;
					if (obj2 != null)
					{
						goto IL_0625;
					}
				}
				obj2 = "None";
				goto IL_0625;
			}
		}
		goto IL_065c;
		IL_0625:
		array[0] = obj2;
		array[1] = _debuggerCutsceneStates[0];
		array[2] = _debuggerCutsceneStates[1];
		array[3] = _debuggerCutsceneStates[2];
		array[4] = _debuggerCutsceneStates[3];
		File.WriteAllText(path2, string.Format("Scene: {0}\r\nCutscene: {1}\r\nStage: {2}\r\nPath: {3}\r\nCurrent: {4}", array));
		goto IL_065c;
	}

	public void RefreshDisplay()
	{
		SetDisplay(_mouse.CanvasWidth, _mouse.CanvasHeight, !_display.IsFullScreen);
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
		_mouse.SetResolution(width, height, _display.PreferredBackBufferWidth, _display.PreferredBackBufferHeight);
		_destinationRectangle = new Microsoft.Xna.Framework.Rectangle(_mouse.RelativeX, _mouse.RelativeY, _mouse.RelativeWidth, _mouse.RelativeHeight);
		_display.ApplyChanges();
	}

	public void Exit()
	{
		_game.Exit();
	}

	public void StartScene<T>() where T : AbstractScene
	{
		_fader.Show(delegate
		{
			SwitchScene<T>(delegate
			{
				_fader.Hide();
			});
		});
	}

	public void StartScene(string name)
	{
		_fader.Show(delegate
		{
			SwitchScene(name, delegate
			{
				_fader.Hide();
			});
		});
	}

	public void StartScene(AbstractScene scene)
	{
		_fader.Show(delegate
		{
			SwitchScene(scene, delegate
			{
				_fader.Hide();
			});
		});
	}

	public void SwitchScene<T>(Action then = null) where T : AbstractScene
	{
		if (_pendingSceneThen != null)
		{
			Action action = _pendingSceneThen;
			_pendingSceneThen = null;
			action();
		}
		_pendingSceneThen = then;
		_mouse._n4NdRK3l14j7hHgGSJS4dI9LeYR();
		PlayerPreferences.SetPlayerSkin(null);
		_overlay = null;
		_sexscene = null;
		_pendingScene = Activator.CreateInstance(typeof(T), this) as AbstractScene;
		InScenePending = true;
	}

	public void SwitchScene(string name, Action then = null)
	{
		if (_pendingSceneThen != null)
		{
			Action action = _pendingSceneThen;
			_pendingSceneThen = null;
			action();
		}
		_pendingSceneThen = then;
		IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
			where typeof(AbstractScene).IsAssignableFrom(type_0)
			select type_0;
		Type type = source.FirstOrDefault((Type type_0) => type_0.Name == name);
		if (!(type == null))
		{
			_mouse._n4NdRK3l14j7hHgGSJS4dI9LeYR();
			PlayerPreferences.SetPlayerSkin(null);
			_overlay = null;
			_sexscene = null;
			_pendingScene = Activator.CreateInstance(type, this) as AbstractScene;
			InScenePending = true;
		}
		else
		{
			Logger.Error("Failed to load scene '{0}'", name);
		}
	}

	public void SwitchScene(AbstractScene scene, Action then = null)
	{
		if (_pendingSceneThen != null)
		{
			Action action = _pendingSceneThen;
			_pendingSceneThen = null;
			action();
		}
		_pendingSceneThen = then;
		_mouse._n4NdRK3l14j7hHgGSJS4dI9LeYR();
		PlayerPreferences.SetPlayerSkin(null);
		_overlay = null;
		_sexscene = null;
		_pendingScene = scene;
		InScenePending = true;
	}

	public void StartSexscene(string name)
	{
		IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
			where typeof(AbstractSexscene).IsAssignableFrom(type_0)
			select type_0;
		Type type = source.FirstOrDefault((Type type_0) => type_0.Name == name);
		if (!(type == null))
		{
			if (_sexscene != null) {
				Logger.Log(ConsoleColor.White, "Debug", "Changing to sexscene '{0}' -> '{1}'", _sexscene.GetType().Name, type.Name);
			} else {
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

	public void StartCutscene(string name)
	{
		Cutscene cutscene = ReadCutscene(name);
		StartCutscene(cutscene);
	}

	public void StartCutscene(Cutscene cutscene)
	{
		if (cutscene != null)
		{
			if (_cutscene != null) {
				Logger.Log(ConsoleColor.White, "Debug", "Changing to cutscene '{0}' -> '{1}'", _cutscene.Data.Name, cutscene.Data.Name);
			} else {
				Logger.Log(ConsoleColor.White, "Debug", "Starting cutscene '{0}'", cutscene.Data.Name);
			}
			_cutscene = cutscene;
			int stage = _player.Data.GetDecimal(cutscene.Data.Name);
			PhoneOverlay.Hide();
			_cutscene.Begin(stage);
		}
	}

	private Cutscene ReadCutscene(string name)
	{
		// TODO: Such as ModLoader thing implementation
		string path = Path.Combine(Content.RootDirectory, $"Content-Mods/Data/Quests/{name}.json");
		string json;
		if (File.Exists(path))
		{
			json = Compressions.ReadStreamAsText(path);
		}
		else
		{
			path = Path.Combine(Content.RootDirectory, $"Data/Quests/{name}.json");
			if (!File.Exists(path))
			{
				Logger.Error("Failed to load cutscene '{0}'", name);
				return null;
			}
			json = Compressions.ReadStreamAsText(path);
		}
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
				Subscene = Scene.Variant,
				Sexscene = Sexscene?.GetType().Name,
				SexscenePhase = (Sexscene?.State ?? AbstractSexscene.Phase.Idle),
				SexsceneFinished = (Sexscene?.Cumming ?? false),
				FadedOut = (Fading.State.A > 0)
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
		Fading.Show(delegate
		{
			Cutscene cutscene = ReadCutscene(state.Name);
			if (cutscene != null)
			{
				SwitchScene(state.Scene, delegate
				{
					if (state.Subscene != null)
					{
						Scene.SetVariant(state.Subscene);
					}
					if (state.Sexscene != null)
					{
						StartSexscene(state.Sexscene);
						Sexscene._eXH4tq2J0DADXDLofA8G8Yw8fau(state.SexscenePhase, state.SexsceneFinished);
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
						_cutscene.Begin(state.Stage, state.ID);
					}
					else
					{
						Fading.Hide(delegate
						{
							_cutscene = cutscene;
							_cutscene.Begin(state.Stage, state.ID);
						});
					}
				});
			}
		});
	}

	public void Start()
	{
		AutosaveAtSlot(0);
		ResetInGameDrawing();
		_scene.Start();
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
				IEnumerable<Type> source = from type_0 in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
					where typeof(AbstractNPC).IsAssignableFrom(type_0) && !type_0.IsAbstract
					select type_0;
				Type type = source.FirstOrDefault((Type type_0) => type_0.Name == name);
				if (!(type == null))
				{
					if (Activator.CreateInstance(type, this) is AbstractNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT)
					{
						qGGOTxZ8aNWGh0hc26wcmx8wmwT.Game = this;
						qGGOTxZ8aNWGh0hc26wcmx8wmwT.Begin();
						_scene.AddNPC(qGGOTxZ8aNWGh0hc26wcmx8wmwT, (order == LayerOrder.None) ? LayerOrder.Background : order);
						return qGGOTxZ8aNWGh0hc26wcmx8wmwT;
					}
					Logger.Error("Failed to instance npc '{0}'", name);
					return null;
				}
				Logger.Error("Failed to load npc '{0}'", name);
				return null;
			}
			AbstractNPC NPC = NPCLayer.NPC;
			if (NPC != null && NPC._SC7QlorMIWTLSkD757wC7ybszpE)
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
			Version = 5,
			PlayerData = _player.Data,
			CutsceneState = GetCutsceneState(),
			SceneName = _scene.GetType().Name,
			PhoneEnabled = PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj
		});
	}

	public void AutosaveAtSlot(int slot)
	{
		Saves.Autosave(slot, new SaveData
		{
			Version = 5,
			PlayerData = _player.Data,
			SceneName = _scene.GetType().Name,
			PhoneEnabled = PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj
		});
	}

	public bool ReadFromSlot(int slot)
	{
		ResetInGameDrawing();
		SaveData save = Saves.Read(slot);
		if (save != null)
		{
			_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(save);
			_player.Data = save.PlayerData;
			PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = save.PhoneEnabled;
			PhoneOverlay.Get()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
			TypingDialogue._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
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
				if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, save))
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
			_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._NG0eIZcXsX6Fp38GhuED0LKeWHf(save);
			_player.Data = save.PlayerData;
			PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = save.PhoneEnabled;
			PhoneOverlay.Get()._Xrfjrxr72hHh4bDdQB7HzEbJUCb();
			TypingDialogue.Speed = Options.Data.DialogueTextSpeed;
			TypingDialogue._fUgDiz7KX8TZUVzFlTeXMOhmfUT = Options.Data.DialogueAutoSkip;
			if (!_nonContextualPlaces.Contains(save.SceneName))
			{
				save.SceneName = typeof(ClubInsideScene).Name;
			}
			if (!_9gbCIL8lNtgBPuVMJ6pA7rCsMoT._RUw8RieezXPoVSmbk3eROtfKXVi(this, save))
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
			Cutscene.ResetProgression();
		}
		PhoneOverlay.Hide();
		PhoneOverlay.Get().ResetProgression();
		TypingDialogue._gVRGC9VAGHCLvP8p5Q4mqLPvFCm();
		TypingDialogue.BeginCutscene();
		_fader.ApplyNow(new Color(0, 0, 0, 0));
	}
}
