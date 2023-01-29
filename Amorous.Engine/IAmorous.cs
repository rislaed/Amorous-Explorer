using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public interface IAmorous
{ // _JbeCmOie0phb2cbgG6DdGZrbs3pB
	GameWindow Window { get; }
	GraphicsDevice GLES { get; }
	ContentManager Content { get; }
	ControllerObserver Controller { get; }
	MouseObserver Mouse { get; }
	AbstractScene Scene { get; }
	AbstractSexscene Sexscene { get; }
	Cutscene Cutscene { get; }
	ScreenFader Fading { get; }
	InteractableOverlay Overlay { get; }
	IAchievements Achievements { get; }
	bool IsFullscreen { get; }
	bool InScenePending { get; }
	bool IsRenderingCursor { get; set; }
	bool IsControlsOnScreen { get; }
	void Initialize();
	void LoadContent();
	void UnloadContent();
	void Update(GameTime gameTime);
	void Draw(GameTime gameTime);
	void RefreshDisplay();
	void RequestScreenshot();
	bool OpenUrl(string url);
	void SetDisplay(int width, int height);
	void SetDisplay(int width, int height, bool fullscreen);
	void Exit();
	void StartScene<T>() where T : AbstractScene;
	void StartScene(string name);
	void StartScene(AbstractScene scene);
	void SwitchToScene<T>(Action then = null) where T : AbstractScene;
	void SwitchToScene(string name, Action then = null);
	void SwitchToScene(AbstractScene scene, Action then = null);
	void PlaySexscene(string name);
	void ResetSexscene();
	void StartCutscene(string name);
	void StartCutscene(Cutscene cutscene);
	void Start();
	void SetOverlay<T>() where T : InteractableOverlay;
	void SetOverlay<T>(T overlay) where T : InteractableOverlay;
	void ResetOverlay();
	AbstractNPC GetNPCLayer(string name);
	AbstractNPC GetNPCLayer(NPCLocation location);
	AbstractNPC GetNPCLayerAt(string name, LayerOrder order);
	T GetNPCLayerAt<T>(LayerOrder order) where T : AbstractNPC;
	void SaveAtSlot(int slot);
	void AutosaveAtSlot(int slot);
	bool ReadFromSlot(int slot);
	bool ReadFromAutosaveSlot(int slot);
	void ShowMessage(string icon, string title, string message);
}
