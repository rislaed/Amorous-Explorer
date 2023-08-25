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
	private readonly Game game;
	private readonly GraphicsDeviceManager graphicsDevice;
	private SpriteBatch spriteBatch;
	private SkeletonMeshRenderer skeletonRenderer;
	private CanvasObserver canvas;
	private RenderTarget2D renderTarget;
	private Microsoft.Xna.Framework.Rectangle destinationRectangle;
	private ScreenFader screenFader;
	private FadingMediaPlayer mediaPlayer;
	private SpineTextureLoader textureLoader;
	private ControllerObserver controller;
	private Notifications notifications;
	private Achievements achievements;
	private SteamObserver steam;
	private Action sceneAfterChanging;
	private AbstractScene scene;
	private AbstractScene pendingToScene;
	private PlayerPreferences preferences;
	private PhoneOverlay phone;
	private TypingDialogue typingDialogue;
	private Cutscene cutscene;
	private AbstractSexscene sexscene;
	private InteractableOverlay overlay;
	private Texture2D cursorOverlay;
	private SpriteFont debuggingFont;

	private bool showControls;
	private bool showDebugging;
	private bool requestedScreenshot;

	private static readonly string[] accessibleScenes = new string[8]
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

	private Microsoft.Xna.Framework.Input.Keys[] keyboardKeys;
	private string[] debuggingOfCutscene;
	private Vector2 debuggingOffset;

	public GameWindow Window => game.Window;
	public GraphicsDevice Graphics => game.GraphicsDevice;
	public ContentManager Content => game.Content;
	public ControllerObserver Controller => controller;
	public CanvasObserver Canvas => canvas;
	public AbstractScene Scene => scene;
	public AbstractSexscene Sexscene => sexscene;
	public Cutscene Cutscene => cutscene;
	public ScreenFader Fader => screenFader;
	public InteractableOverlay Overlay => overlay;
	public IAchievements Achievements => achievements;
	public bool IsFullscreen => graphicsDevice.IsFullScreen;
	public bool IsScenePending { get; set; }
	public bool IsRenderingCursor { get; set; }
	public bool IsShowingControls => showControls;

	public AmorousSingleton(Game game, bool safemode)
	{
		this.game = game;
		Options.Read();
		if (safemode)
		{
			graphicsDevice = new GraphicsDeviceManager(game)
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
			graphicsDevice = new GraphicsDeviceManager(game)
			{
				IsFullScreen = true,
				PreferredBackBufferWidth = currentDisplayMode.Width,
				PreferredBackBufferHeight = currentDisplayMode.Height,
				SynchronizeWithVerticalRetrace = true
			};
		}
		else
		{
			graphicsDevice = new GraphicsDeviceManager(game)
			{
				IsFullScreen = Options.Config.Fullscreen,
				PreferredBackBufferWidth = Options.Config.ResolutionWidth,
				PreferredBackBufferHeight = Options.Config.ResolutionHeight,
				SynchronizeWithVerticalRetrace = true
			};
		}
		Content.RootDirectory = "Content-Release";
		this.game.Content = new CompressableContentManager(Content.ServiceProvider, Content.RootDirectory);
	}

	public void Initialize()
	{
		game.Disposed += delegate
		{
			Options.Save();
		};
		Gui.GetClipboardCallback = (Func<string>)Delegate.Combine(Gui.GetClipboardCallback, new Func<string>(SDL.SDL_GetClipboardText));
		Gui.SetClipboardCallback = (Action<string>)Delegate.Combine(Gui.SetClipboardCallback, (Action<string>)delegate(string text)
		{
			SDL.SDL_SetClipboardText(text);
		});
		string nonSteamFlag = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NonSteam");
		if (!File.Exists(nonSteamFlag) && !File.Exists(nonSteamFlag + ".txt"))
		{
			steam = new SteamObserver();
			if (!steam.Initialize(AmorousData.Code, this))
			{
				steam = null;
			}
		}
		achievements = new Achievements(this, steam);
	}

	public void LoadContent()
	{
		string bootiesFlag = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShowMeSomeBooty");
		Censorship.SetBooties(File.Exists(bootiesFlag) || File.Exists(bootiesFlag + ".txt"));
		controller = new ControllerObserver(this);
		keyboardKeys = (Microsoft.Xna.Framework.Input.Keys[])Enum.GetValues(typeof(Microsoft.Xna.Framework.Input.Keys));
		Controller.Grabbed = true;
		spriteBatch = new SpriteBatch(game.GraphicsDevice);
		skeletonRenderer = new SkeletonMeshRenderer(game.GraphicsDevice);
		canvas = new CanvasObserver(this, 1920, 1080);
		canvas.ChangeResolution(graphicsDevice.PreferredBackBufferWidth, graphicsDevice.PreferredBackBufferHeight, graphicsDevice.PreferredBackBufferWidth, graphicsDevice.PreferredBackBufferHeight);
		renderTarget = new RenderTarget2D(game.GraphicsDevice, 1920, 1080);
		renderTarget.SetUsage(RenderTargetUsage.PreserveContents);
		destinationRectangle = new Microsoft.Xna.Framework.Rectangle(canvas.OffsetX, canvas.OffsetY, canvas.Width, canvas.Height);
		Gui.Renderer = new XnaSquidRenderer(game);
		Gui.Renderer.SetTexture("PhoneScreen", game.Content.Load<Texture2D>("Assets/GUI/Phone/PhoneScreen"));
		Gui.Renderer.SetTexture("Contact_DJ", game.Content.Load<Texture2D>("Assets/GUI/Phone/Contacts/DJ"));
		Overlays.ExitWithoutSavingChanges = ReturnToMenu;
		preferences = new PlayerPreferences();
		screenFader = new ScreenFader(game.GraphicsDevice);
		mediaPlayer = new FadingMediaPlayer(game.Content);
		textureLoader = new SpineTextureLoader(game.Content);
		notifications = new Notifications();
		Texture2D dialogueTexture = game.Content.Load<Texture2D>("Assets/GUI/Dialogue/dialogue");
		Texture2D buttonTexture = game.Content.Load<Texture2D>("Assets/GUI/Dialogue/button");
		cursorOverlay = game.Content.Load<Texture2D>("Assets/GUI/Squid/DefaultCursor");
		IsRenderingCursor = true;
		debuggingFont = game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		SpriteFont italicFont = game.Content.Load<SpriteFont>("Assets/GUI/Fonts/BoldItalic-26");
		typingDialogue = new TypingDialogue(this, dialogueTexture, buttonTexture, debuggingFont, italicFont);
		Saves.Item item = Saves.GetLastItem();
		if (!item.IsEmpty)
		{
			SaveData save = (item.IsAutosave ? Saves.ReadAutosave(item.Index) : Saves.Read(item.Index));
			if (save != null)
			{
				PlayerPreferences.Singleton.Data = save.PlayerData;
			}
		}
		phone = new PhoneOverlay(this, game.Content);
		Clocks.InRealTime = true;
		Clocks.Update();
		showControls = true;
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
		scene = new EmptyScene(this);
		Fader.ApplyWithoutFading(new Color(0, 0, 0, 255));
		SwitchToScene<MainMenuScene>(delegate
		{
			Fader.FadeIn();
		});
	}

	public void UnloadContent() {}

	public void Update(GameTime gameTime)
	{
		if (IsScenePending && pendingToScene == null)
		{
			IsScenePending = false;
			if (sceneAfterChanging != null)
			{
				Action action = sceneAfterChanging;
				sceneAfterChanging = null;
				action();
			}
		}
		controller.Update();
		if (Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.F1))
		{
			showControls = !showControls;
		}
		if ((Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.LeftAlt) && Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) || Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.F2))
		{
			RefreshDisplay();
		}
		if (steam == null && (Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.F12) || Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.PrintScreen)))
		{
			RequestScreenshot();
		}
		if (Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Tab))
		{
			showDebugging = !showDebugging;
		}
		canvas.Update(gameTime);
		screenFader.Update(gameTime);
		mediaPlayer.Update(gameTime);
		mediaPlayer.InterpolateVolume();
		if (pendingToScene != null)
		{
			if (scene != null)
			{
				Logger.Debug("Changing to pending scene '{0}' -> '{1}'", scene.GetType().Name, pendingToScene.GetType().Name);
				scene.End();
			}
			else
			{
				Logger.Debug("Starting pending scene '{0}'", pendingToScene.GetType().Name);
			}
			scene = pendingToScene;
			pendingToScene = null;
			scene.Start();
		}
		scene.Update(gameTime);
		preferences.Update(gameTime);
		phone.Update(gameTime, canvas);
		typingDialogue.Update(gameTime);
		if (cutscene != null)
		{
			cutscene.Update(gameTime);
			if (!cutscene.IsActive)
			{
				debuggingOfCutscene = cutscene.ToString(5);
				Logger.Debug("Finishing cutscene '{0}' ({1})", cutscene.Data.Name, debuggingOfCutscene != null ? string.Join(", ", debuggingOfCutscene).Trim(new char[] { ' ', ',' }) : "...");
				cutscene = null;
			}
		}
		if (sexscene != null)
		{
			sexscene.Update(gameTime);
		}
		if (overlay != null)
		{
			overlay.Update(gameTime);
		}
		notifications.Update(gameTime);
		Microsoft.Xna.Framework.Point cursor = canvas.GlobalToContent(Controller.Cursor);
		List<KeyData> touchedKeys = new List<KeyData>();
		foreach (Microsoft.Xna.Framework.Input.Keys keys in keyboardKeys)
		{
			bool pressed = Controller.IsPressed(keys);
			bool released = Controller.IsReleasing(keys);
			if (pressed || released)
			{
				Squid.Keys? availables = SquidExtensions.Keys[Keyboard.GetKeyFromScancodeEXT(keys)];
				if (availables.HasValue)
				{
					touchedKeys.Add(new KeyData
					{
						Scancode = (int)availables.Value,
						Char = keys.ChangeKeyboard(Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.LeftShift) || Controller.IsHolding(Microsoft.Xna.Framework.Input.Keys.RightShift)),
						Pressed = pressed,
						Released = released
					});
				}
			}
		}
		Gui.SetKeyboard(touchedKeys.ToArray());
		Gui.SetButtons(Controller.IsHolding(ControllerButtonType.LeftButton), Controller.IsHolding(ControllerButtonType.RightButton));
		Gui.SetMouse(cursor.X, cursor.Y, Controller.ScrollWheel);
		Gui.TimeElapsed = gameTime.ElapsedGameTime.Milliseconds;
		if (steam != null)
		{
			steam.Update();
		}
	}

	public void Draw(GameTime gameTime)
	{
		Utils.Date = (float)gameTime.TotalGameTime.TotalSeconds;
		game.GraphicsDevice.SetRenderTarget(renderTarget);
		game.GraphicsDevice.Clear(Color.Black);
		scene.Draw(spriteBatch, skeletonRenderer, canvas.OverscrollNoneMatrix);
		if (canvas.IsOverscrolledToRight)
		{
			scene.Draw(spriteBatch, skeletonRenderer, canvas.OverscrollRightMatrix);
		}
		else if (canvas.IsOverscrolledToLeft)
		{
			scene.Draw(spriteBatch, skeletonRenderer, canvas.OverscrollLeftMatrix);
		}
		if (sexscene != null)
		{
			sexscene.Draw(spriteBatch, skeletonRenderer);
		}
		if (showControls)
		{
			phone.Draw(spriteBatch, skeletonRenderer);
		}
		if (overlay != null)
		{
			overlay.Draw(spriteBatch);
		}
		scene.DrawOverlay(spriteBatch);
		screenFader.Draw(spriteBatch, canvas);
		if (showControls)
		{
			typingDialogue.Draw(spriteBatch);
		}
		notifications.Draw(spriteBatch);
		if (showDebugging)
		{
			object sceneName = null;
			if (cutscene != null)
			{
				debuggingOfCutscene = cutscene.ToString(5);
			}
			debuggingOffset.X = 10f;
			debuggingOffset.Y = 10f;
			spriteBatch.Begin();
			spriteBatch.DrawString(debuggingFont, "[Generic]", debuggingOffset, Color.White);
			debuggingOffset.Y += 40f;
			if (scene != null)
			{
				sceneName = scene.GetType().Name;
			}
			if (sceneName == null)
			{
				sceneName = "None";
			}
			spriteBatch.DrawString(debuggingFont, "Scene: " + sceneName, debuggingOffset, Color.White);
			debuggingOffset.Y += 40f;
			spriteBatch.DrawString(debuggingFont, "ScreenFader: " + screenFader.Value.A, debuggingOffset, Color.White);
			debuggingOffset.Y += 40f;
			debuggingOffset.Y += 40f;
			spriteBatch.DrawString(debuggingFont, "[Cutscenes]", debuggingOffset, Color.White);
			debuggingOffset.Y += 40f;
			spriteBatch.DrawString(debuggingFont, string.Format("Cutscene in progress: {0}", (cutscene == null) ? "No" : "Yes"), debuggingOffset, Color.White);
			debuggingOffset.Y += 40f;
			if (debuggingOfCutscene != null)
			{
				spriteBatch.DrawString(debuggingFont, "Cutscene: " + debuggingOfCutscene[0], debuggingOffset, Color.White);
				debuggingOffset.Y += 40f;
				spriteBatch.DrawString(debuggingFont, "Stage: " + debuggingOfCutscene[1], debuggingOffset, Color.White);
				debuggingOffset.Y += 40f;
				spriteBatch.DrawString(debuggingFont, "Path: " + debuggingOfCutscene[2], debuggingOffset, Color.White);
				debuggingOffset.Y += 40f;
				spriteBatch.DrawString(debuggingFont, "Current: " + debuggingOfCutscene[3], debuggingOffset, Color.White);
				debuggingOffset.Y += 40f;
			}
			else
			{
				spriteBatch.DrawString(debuggingFont, "Cutscene: None", debuggingOffset, Color.White);
				debuggingOffset.Y += 40f;
			}
			debuggingOffset.Y += 40f;
			spriteBatch.DrawString(debuggingFont, "Press Tab to toggle", debuggingOffset, Color.White);
			debuggingOffset.Y += 40f;
			spriteBatch.End();
		}
		if (requestedScreenshot)
		{
			requestedScreenshot = false;
			if (!Directory.Exists("Screenshots"))
			{
				Directory.CreateDirectory("Screenshots");
			}
			string screenshotDirectory = $"Screenshots/screenshot-{DateTime.Now.DayOfYear}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.png";
			string screenshotPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, screenshotDirectory);
			using (Stream stream = File.OpenWrite(screenshotPath))
			{
				renderTarget.SaveAsPng(stream, canvas.AbsoluteWidth, canvas.AbsoluteHeight);
			}
			if (steam != null)
			{
				steam.AddScreenshotToLibrary(screenshotPath, canvas.AbsoluteWidth, canvas.AbsoluteHeight);
			}
			if (showDebugging && debuggingOfCutscene != null)
			{
				string scenePath = $"{screenshotPath}.txt";
				object sceneName = null;
				if (scene != null)
				{
					sceneName = scene.GetType().Name;
				}
				if (sceneName == null)
				{
					sceneName = "None";
				}
				object[] sceneInformation = new object[5];
				sceneInformation[0] = sceneName;
				sceneInformation[1] = debuggingOfCutscene[0];
				sceneInformation[2] = debuggingOfCutscene[1];
				sceneInformation[3] = debuggingOfCutscene[2];
				sceneInformation[4] = debuggingOfCutscene[3];
				File.WriteAllText(scenePath, string.Format("Scene: {0}\r\nCutscene: {1}\r\nStage: {2}\r\nPath: {3}\r\nCurrent: {4}", sceneInformation));
			}
		}
		game.GraphicsDevice.SetRenderTarget(null);
		game.GraphicsDevice.Clear(Color.Black);
		spriteBatch.Begin();
		spriteBatch.Draw(renderTarget, destinationRectangle, Color.White);
		if (IsRenderingCursor)
		{
			spriteBatch.Draw(cursorOverlay, Controller.VectorOfCursor, preferences.Data.PhoneColor);
		}
		spriteBatch.End();
	}

	public void RefreshDisplay()
	{
		SetDisplay(canvas.ModeWidth, canvas.ModeHeight, !graphicsDevice.IsFullScreen);
	}

	public void RequestScreenshot()
	{
		requestedScreenshot = true;
	}

	public bool OpenUrl(string url)
	{
		if (steam == null)
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
		steam.OpenUrl(url);
		return true;
	}

	public void SetDisplay(int width, int height)
	{
		SetDisplay(width, height, graphicsDevice.IsFullScreen);
	}

	public void SetDisplay(int width, int height, bool fullscreen)
	{
		graphicsDevice.IsFullScreen = fullscreen;
		graphicsDevice.PreferredBackBufferWidth = (fullscreen ? GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width : width);
		graphicsDevice.PreferredBackBufferHeight = (fullscreen ? GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height : height);
		graphicsDevice.GraphicsDevice.Viewport = new Viewport(0, 0, graphicsDevice.PreferredBackBufferWidth, graphicsDevice.PreferredBackBufferHeight);
		canvas.ChangeResolution(width, height, graphicsDevice.PreferredBackBufferWidth, graphicsDevice.PreferredBackBufferHeight);
		destinationRectangle = new Microsoft.Xna.Framework.Rectangle(canvas.OffsetX, canvas.OffsetY, canvas.Width, canvas.Height);
		graphicsDevice.ApplyChanges();
	}

	public void Exit()
	{
		game.Exit();
	}

	public void StartScene<T>() where T : AbstractScene
	{
		screenFader.FadeOut(delegate
		{
			SwitchToScene<T>(delegate
			{
				screenFader.FadeIn();
			});
		});
	}

	public void StartScene(string name)
	{
		screenFader.FadeOut(delegate
		{
			SwitchToScene(name, delegate
			{
				screenFader.FadeIn();
			});
		});
	}

	public void StartScene(AbstractScene scene)
	{
		screenFader.FadeOut(delegate
		{
			SwitchToScene(scene, delegate
			{
				screenFader.FadeIn();
			});
		});
	}

	public void SwitchToScene<T>(Action then = null) where T : AbstractScene
	{
		if (sceneAfterChanging != null)
		{
			Action action = sceneAfterChanging;
			sceneAfterChanging = null;
			action();
		}
		sceneAfterChanging = then;
		canvas.ResetOverscroll();
		PlayerPreferences.SetPlayerOverlay(null);
		overlay = null;
		sexscene = null;
		pendingToScene = Activator.CreateInstance(typeof(T), this) as AbstractScene;
		IsScenePending = true;
	}

	public void SwitchToScene(string name, Action then = null)
	{
		if (sceneAfterChanging != null)
		{
			Action action = sceneAfterChanging;
			sceneAfterChanging = null;
			action();
		}
		sceneAfterChanging = then;
		IEnumerable<Type> source = from scene in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
			where typeof(AbstractScene).IsAssignableFrom(scene)
			select scene;
		Type type = source.FirstOrDefault((Type scene) => scene.Name == name);
		if (!(type == null))
		{
			canvas.ResetOverscroll();
			PlayerPreferences.SetPlayerOverlay(null);
			overlay = null;
			sexscene = null;
			pendingToScene = Activator.CreateInstance(type, this) as AbstractScene;
			IsScenePending = true;
		}
		else
		{
			Logger.Error("Failed to load scene '{0}'", name);
		}
	}

	public void SwitchToScene(AbstractScene scene, Action then = null)
	{
		if (sceneAfterChanging != null)
		{
			Action action = sceneAfterChanging;
			sceneAfterChanging = null;
			action();
		}
		sceneAfterChanging = then;
		canvas.ResetOverscroll();
		PlayerPreferences.SetPlayerOverlay(null);
		overlay = null;
		sexscene = null;
		pendingToScene = scene;
		IsScenePending = true;
	}

	public void PlaySexscene(string name)
	{
		IEnumerable<Type> source = from sexscene in Assembly.GetAssembly(typeof(AmorousSingleton))!.GetTypes()
			where typeof(AbstractSexscene).IsAssignableFrom(sexscene)
			select sexscene;
		Type type = source.FirstOrDefault((Type sexscene) => sexscene.Name == name);
		if (!(type == null))
		{
			if (sexscene != null)
			{
				Logger.Debug("Changing to sexscene '{0}' -> '{1}'", sexscene.GetType().Name, type.Name);
			}
			else
			{
				Logger.Debug("Starting sexscene '{0}'", type.Name);
			}
			sexscene = Activator.CreateInstance(type, game.Content) as AbstractSexscene;
		}
		else
		{
			Logger.Error("Failed to load sexscene '{0}'", name);
		}
	}

	public void ResetSexscene()
	{
		sexscene = null;
	}

	public void PlayCutscene(string name)
	{
		PlayCutscene(ReadCutscene(name));
	}

	public void PlayCutscene(Cutscene cutscene)
	{
		if (cutscene != null)
		{
			if (this.cutscene != null)
			{
                Logger.Debug("Changing to cutscene '{0}' -> '{1}'", this.cutscene.Data.Name, cutscene.Data.Name);
			}
			else
			{
                Logger.Debug("Starting cutscene '{0}'", cutscene.Data.Name);
			}
			this.cutscene = cutscene;
			int stage = preferences.Data.GetStage(cutscene.Data.Name);
			PhoneOverlay.Hide();
			this.cutscene.Start(stage);
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
				Stage = Cutscene.Stage.StageData.Stage,
				ID = Cutscene.Stage.EventData.ID,
				Scene = Scene.GetType().Name,
				Subscene = Scene.Subscene,
				Sexscene = Sexscene?.GetType().Name,
				SexscenePhase = (Sexscene?.Phase ?? AbstractSexscene.EPhase.Idle),
				SexsceneFinished = (Sexscene?.Exploded ?? false),
				FadedOut = (Fader.Value.A > 0)
			};
			state.SaveNPCLayer(scene.GetNPCLayer(NPCLocation.Left));
			state.SaveNPCLayer(scene.GetNPCLayer(NPCLocation.Middle));
			state.SaveNPCLayer(scene.GetNPCLayer(NPCLocation.Right));
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
						NPCLayer NPCLayer = scene.GetNPCLayer(item.Name);
						NPCLayer.LayerOrder = item.LayerOrder;
					}
					if (state.FadedOut)
					{
						this.cutscene = cutscene;
						this.cutscene.Start(state.Stage, state.ID);
					}
					else
					{
						Fader.FadeIn(delegate
						{
							this.cutscene = cutscene;
							this.cutscene.Start(state.Stage, state.ID);
						});
					}
				});
			}
		});
	}

	public void Autosave()
	{
		AutosaveAtSlot(0);
		ResetCutscene();
		scene.Autosave();
	}

	public void SetOverlay<T>() where T : InteractableOverlay
	{
		overlay = Activator.CreateInstance(typeof(T), this) as InteractableOverlay;
	}

	public void SetOverlay<T>(T overlay) where T : InteractableOverlay
	{
		this.overlay = overlay;
	}

	public void ResetOverlay()
	{
		overlay = null;
	}

	public AbstractNPC GetNPCLayer(string name)
	{
		if (scene == null)
		{
			return null;
		}
		return scene.GetNPCLayer(name)?.NPC;
	}

	public AbstractNPC GetNPCLayer(NPCLocation location)
	{
		if (scene == null)
		{
			return null;
		}
		return scene.GetNPCLayer(location)?.NPC;
	}

	public AbstractNPC GetNPCLayerAt(string name, LayerOrder order)
	{
		if (scene != null)
		{
			NPCLayer NPCLayer = scene.GetNPCLayer(name);
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
						scene.AddNPC(npc, (order == LayerOrder.None) ? LayerOrder.Background : order);
						return npc;
					}
					Logger.Error("Failed to instance npc '{0}'", name);
					return null;
				}
				Logger.Error("Failed to load npc '{0}'", name);
				return null;
			}
			AbstractNPC NPC = NPCLayer.NPC;
			if (NPC != null && NPC.IsFixedOrder)
			{
				return null;
			}
			NPCLayer.Layer = ((order == LayerOrder.None) ? NPCLayer.Layer : order);
			NPCLayer.ZOrder = ((NPCLayer.Layer == LayerOrder.Background) ? 1 : 3);
			scene.RefreshLayerOrdering();
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
			Version = SavesMigration.CURRENTLY_VERSION,
			PlayerData = preferences.Data,
			CutsceneState = GetCutsceneState(),
			SceneName = scene.GetType().Name,
			PhoneEnabled = PhoneOverlay.Enabled
		});
	}

	public void AutosaveAtSlot(int slot)
	{
		Saves.Autosave(slot, new SaveData
		{
			Version = SavesMigration.CURRENTLY_VERSION,
			PlayerData = preferences.Data,
			SceneName = scene.GetType().Name,
			PhoneEnabled = PhoneOverlay.Enabled
		});
	}

	public bool ReadFromSlot(int slot)
	{
		ResetCutscene();
		SaveData save = Saves.Read(slot);
		if (save != null)
		{
			SavesMigration.RestoreSaveData(save);
			preferences.Data = save.PlayerData;
			PhoneOverlay.Enabled = save.PhoneEnabled;
			PhoneOverlay.GetSingleton().RefreshSkin();
			TypingDialogue.Speed = Options.Config.DialogueTextSpeed;
			TypingDialogue.AutoSkip = Options.Config.DialogueAutoSkip;
			if (save.CutsceneState != null)
			{
				LoadCutscene(save.CutsceneState);
			}
			else
			{
				if (!accessibleScenes.Contains(save.SceneName))
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
		ResetCutscene();
		SaveData save = Saves.ReadAutosave(slot);
		if (save != null)
		{
			SavesMigration.RestoreSaveData(save);
			preferences.Data = save.PlayerData;
			PhoneOverlay.Enabled = save.PhoneEnabled;
			PhoneOverlay.GetSingleton().RefreshSkin();
			TypingDialogue.Speed = Options.Config.DialogueTextSpeed;
			TypingDialogue.AutoSkip = Options.Config.DialogueAutoSkip;
			if (!accessibleScenes.Contains(save.SceneName))
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
		notifications.ShowMessage(icon, title, message);
	}

	private void ReturnToMenu()
	{
		ResetCutscene();
		StartScene<MainMenuScene>();
	}

	private void ResetCutscene()
	{
		if (Cutscene != null)
		{
			Cutscene.ResetState();
		}
		PhoneOverlay.Hide();
		PhoneOverlay.GetSingleton().Reset();
		TypingDialogue.Unselect();
		TypingDialogue.Complete();
		screenFader.ApplyWithoutFading(new Color(0, 0, 0, 0));
	}
}
