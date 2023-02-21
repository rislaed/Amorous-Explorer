using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;
using Squid;

public abstract class AbstractScene
{ // _7UlnfykmEmZDFt3BmCKZekI43Ih
	public const int OrderBackground = 0;
	public const int OrderBackgroundOverlay = 1;
	public const int OrderForeground = 2;
	public const int OrderForegroundOverlay = 3;

	protected bool IsOrderingChanged;

	private AbstractLayer _capturedLayer;

	public IAmorous Game { get; private set; }
	public List<AbstractLayer> Layers { get; private set; }
	public string Subscene { get; private set; }
	public static bool CapturedByOverlay { get; set; }

	protected BlendState Blending { get; set; }

	public Desktop Squid { get; set; }

	protected AbstractScene(IAmorous game)
	{
		Game = game;
		Layers = new List<AbstractLayer>();
		Blending = BlendState.NonPremultiplied;
		Squid = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		Squid.SetSkin("Assets/GUI/Squid/DefaultSkin", "Assets/GUI/Squid/DefaultSkin - Blue");
		Logger.Log(ConsoleColor.White, "Debug", "Initiating scene '{0}' with desktop state {1}", GetType().Name, Squid.AutoId);
	}

	public virtual void Start() {}
	public virtual void End() {}

	public AbstractLayer GetLayer(string name)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer.Name == name);
	}

	public SpriteLayer AddSpriteLayer(string name, string texture, int x, int y)
	{
		SpriteLayer layer = NewSpriteLayer(name, texture, x, y);
		return AddLayer(layer, OrderBackground);
	}

	public AnimatedLayer AddAnimatedLayer(string name, int x, int y, int delay, params string[] images)
	{
		AnimatedLayer layer = NewAnimatedLayer(name, x, y, delay, images);
		return AddLayer(layer, OrderBackground);
	}

	public DeviationLayer AddDeviationLayer(string name, string texture, int x, int y, float fps, int dx, int dy)
	{
		DeviationLayer layer = NewDeviationLayer(name, texture, x, y, fps, dx, dy);
		return AddLayer(layer, OrderBackground);
	}

	public FadingLayer AddFadingLayer(string name, string texture, int x, int y, int timePerFade, int offset = 0, int delay = 0)
	{
		FadingLayer layer = NewFadingLayer(name, texture, x, y, timePerFade, offset, delay);
		return AddLayer(layer, OrderBackground);
	}

	public InteractableLayer AddInteractableLayer(string name, string texture, int x, int y, string activeTexture, int activeX, int activeY, string interaction)
	{
		InteractableLayer layer = NewInteractableLayer(name, texture, x, y, activeTexture, activeX, activeY, interaction);
		return AddLayer(layer, OrderBackground);
	}

	public ClickableLayer AddClickableLayer(string name, string texture, int x, int y, Action click)
	{
		ClickableLayer layer = NewClickableLayer(name, texture, x, y, click);
		return AddLayer(layer, OrderBackground);
	}

	public AnimatedClickableLayer AddAnimatedClickableLayer(string name, int x, int y, Action click, int delay, params string[] images)
	{
		AnimatedClickableLayer layer = NewAnimatedClickableLayer(name, x, y, click, delay, images);
		return AddLayer(layer, OrderBackground);
	}

	public SpriteLayer AddForegroundSpriteLayer(string name, string texture, int x, int y)
	{
		SpriteLayer layer = NewSpriteLayer(name, texture, x, y);
		return AddLayer(layer, OrderForeground);
	}

	public AnimatedLayer AddForegroundAnimatedLayer(string name, int x, int y, int delay, params string[] images)
	{
		AnimatedLayer layer = NewAnimatedLayer(name, x, y, delay, images);
		return AddLayer(layer, OrderForeground);
	}

	public DeviationLayer AddForegroundDeviationLayer(string name, string texture, int x, int y, float fps, int dx, int dy)
	{
		DeviationLayer layer = NewDeviationLayer(name, texture, x, y, fps, dx, dy);
		return AddLayer(layer, OrderForeground);
	}

	public FadingLayer AddForegroundFadingLayer(string name, string texture, int x, int y, int timePerFade, int offset = 0, int delay = 0)
	{
		FadingLayer layer = NewFadingLayer(name, texture, x, y, timePerFade, offset, delay);
		return AddLayer(layer, OrderForeground);
	}

	public InteractableLayer AddForegroundInteractableLayer(string name, string texture, int x, int y, string activeTexture, int activeX, int activeY, string interaction)
	{
		InteractableLayer layer = NewInteractableLayer(name, texture, x, y, activeTexture, activeX, activeY, interaction);
		return AddLayer(layer, OrderForeground);
	}

	public ClickableLayer AddForegroundClickableLayer(string name, string texture, int x, int y, Action click)
	{
		ClickableLayer layer = NewClickableLayer(name, texture, x, y, click);
		return AddLayer(layer, OrderForeground);
	}

	public AnimatedClickableLayer AddForegroundAnimatedClickableLayer(string name, int x, int y, Action click, int delay, params string[] images)
	{
		AnimatedClickableLayer layer = NewAnimatedClickableLayer(name, x, y, click, delay, images);
		return AddLayer(layer, OrderForeground);
	}

	protected SpriteLayer NewSpriteLayer(string name, string texture, int x, int y)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new SpriteLayer(this, name, texture2D)
		{
			X = x,
			Y = y
		};
	}

	private AnimatedLayer NewAnimatedLayer(string name, int x, int y, int delay, params string[] images)
	{
		if (images.Length == 0)
		{
			throw new ArgumentException("Images cannot be empty");
		}
		List<Texture2D> textures = new List<Texture2D>(images.Length);
		foreach (string assetName in images)
		{
			textures.Add(Game.Content.Load<Texture2D>(assetName));
		}
		return new AnimatedLayer(this, name, delay, textures)
		{
			X = x,
			Y = y
		};
	}

	private DeviationLayer NewDeviationLayer(string name, string texture, int x, int y, float fps, int dx, int dy)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new DeviationLayer(this, name, texture2D, fps, new Vector2(dx, dy))
		{
			X = x,
			Y = y
		};
	}

	private FadingLayer NewFadingLayer(string name, string texture, int x, int y, int timePerFade, int offset, int delay)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new FadingLayer(this, name, texture2D, timePerFade, offset, delay)
		{
			X = x,
			Y = y
		};
	}

	private InteractableLayer NewInteractableLayer(string name, string texture, int x, int y, string activeTexture, int activeX, int activeY, string text)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		Texture2D activeTexture2D = null;
		if (!string.IsNullOrEmpty(activeTexture))
		{
			activeTexture2D = Game.Content.Load<Texture2D>(activeTexture);
		}
		return new InteractableLayer(this, name, texture2D, activeTexture2D, text)
		{
			X = x,
			Y = y,
			ActiveX = activeX,
			ActiveY = activeY
		};
	}

	private ClickableLayer NewClickableLayer(string name, string texture, int x, int y, Action click)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new ClickableLayer(this, name, texture2D, click)
		{
			X = x,
			Y = y
		};
	}

	private AnimatedClickableLayer NewAnimatedClickableLayer(string name, int x, int y, Action action, int delay, params string[] images)
	{
		if (images.Length == 0)
		{
			throw new ArgumentException("Images cannot be empty");
		}
		List<Texture2D> textures = new List<Texture2D>(images.Length);
		foreach (string assetName in images)
		{
			textures.Add(Game.Content.Load<Texture2D>(assetName));
		}
		return new AnimatedClickableLayer(this, name, action, delay, textures)
		{
			X = x,
			Y = y
		};
	}

	public virtual void Update(GameTime gameTime)
	{
		if (IsOrderingChanged)
		{
			Layers = (from layer in Layers
				orderby layer.ZOrder, layer.LayerOrder
				select layer).ToList();
			IsOrderingChanged = false;
		}
		UpdateLayers(gameTime, Layers);
		if (Game.Cutscene != null)
		{
			return;
		}
		if (!CapturedByOverlay)
		{
			bool pressed;
			if ((pressed = Game.Controller.IsPressed(ControllerButtonType.LeftButton)) && _capturedLayer != null)
			{
				_capturedLayer.Continue();
				_capturedLayer = null;
			}
			Microsoft.Xna.Framework.Point point = Game.Canvas.GlobalToTouch(Game.Controller.Cursor);
			Touch(point, pressed, Layers);
		}
		Squid.Update();
	}

	private void UpdateLayers(GameTime gameTime, IEnumerable<AbstractLayer> layers)
	{
		foreach (AbstractLayer layer in layers)
		{
			if (layer.Updatable)
			{
				layer.Update(gameTime);
			}
		}
	}

	private void Touch(Microsoft.Xna.Framework.Point cursor, bool pressed, List<AbstractLayer> layers)
	{
		AbstractLayer clickedLayer = null;
		Microsoft.Xna.Framework.Rectangle bounds = default(Microsoft.Xna.Framework.Rectangle);
		for (int index = layers.Count - 1; index >= 0; index--)
		{
			AbstractLayer layer = layers[index];
			if ((layer is InteractableLayer || layer is ClickableLayer || layer is AnimatedClickableLayer || layer is NPCLayer) && layer.Updatable)
			{
				if (!(layer is NPCLayer))
				{
					layer.Unhover();
					if (clickedLayer == null)
					{
						bounds.X = (int)layer.X;
						bounds.Y = (int)layer.Y;
						bounds.Width = layer.Width;
						bounds.Height = layer.Height;
						if (bounds.Contains(cursor))
						{
							layer.Hover();
							clickedLayer = layer;
						}
					}
				}
				else
				{
					AbstractNPC npc = ((NPCLayer)layer).NPC;
					npc.IsHovered = false;
					if (clickedLayer == null)
					{
						bounds.X = (int)npc.X;
						bounds.Y = (int)npc.Y;
						bounds.Width = (int)((float)npc.Width * npc.Scale);
						bounds.Height = (int)((float)npc.Height * npc.Scale);
						if (npc is AbstractSpineNPC)
						{
							bounds.X -= bounds.Width / 2;
							bounds.Y -= bounds.Height;
						}
						if (npc.Click != null && bounds.Contains(cursor))
						{
							npc.IsHovered = true;
							clickedLayer = layer;
						}
					}
				}
			}
		}
		if (!(clickedLayer != null && pressed))
		{
			return;
		}
		if (!(clickedLayer is NPCLayer))
		{
			if (clickedLayer.Click())
			{
				_capturedLayer = clickedLayer;
			}
			return;
		}
		AbstractNPC clickedNPC = ((NPCLayer)clickedLayer).NPC;
		if (clickedNPC.Click != null)
		{
			clickedNPC.Click();
			_capturedLayer = clickedLayer;
		}
	}

	public virtual void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		DrawLayers(spriteBatch, skeletonMeshRenderer, matrix, Layers);
	}

	public virtual void DrawOverlay(SpriteBatch spriteBatch)
	{
		Squid.Draw();
	}

	private void DrawLayers(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix, IEnumerable<AbstractLayer> layers)
	{
		bool begin = false;
		foreach (AbstractLayer layer in layers)
		{
			if (!layer.Visible)
			{
				continue;
			}
			if (!(layer is NPCLayer))
			{
				if (!(layer is SpineDrawableLayer))
				{
					if (layer is DrawableLayer)
					{
						if (begin)
						{
							spriteBatch.End();
							begin = false;
						}
						((DrawableLayer)layer).DrawableMatrix = matrix;
						layer.Draw(spriteBatch);
					}
					else
					{
						if (!begin)
						{
							spriteBatch.Begin(SpriteSortMode.Deferred, transformationMatrix: matrix, blendState: Blending);
							begin = true;
						}
						layer.Draw(spriteBatch);
					}
					continue;
				}
				if (begin)
				{
					spriteBatch.End();
					begin = false;
				}
				SpineDrawableLayer spineLayer = (SpineDrawableLayer)layer;
				if (!spineLayer.InTalking)
				{
					spineLayer.OffsetX += matrix.M41;
					spineLayer.OffsetY += matrix.M42;
				}
				spineLayer.Draw(spriteBatch, skeletonMeshRenderer);
				if (!spineLayer.InTalking)
				{
					spineLayer.OffsetX -= matrix.M41;
					spineLayer.OffsetY -= matrix.M42;
				}
			}
			else
			{
				if (begin)
				{
					spriteBatch.End();
					begin = false;
				}
				DrawNPC(layer as NPCLayer, spriteBatch, skeletonMeshRenderer, matrix);
			}
		}
		if (begin)
		{
			spriteBatch.End();
		}
	}

	private void DrawNPC(NPCLayer layer, SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		AbstractNPC npc = layer.NPC;
		if (npc is AbstractSpineNPC)
		{
			if (!npc.InTalking)
			{
				((AbstractSpineNPC)npc).X += matrix.M41;
				((AbstractSpineNPC)npc).Y += matrix.M42;
			}
			((AbstractSpineNPC)npc).Draw(spriteBatch, skeletonMeshRenderer);
			if (!npc.InTalking)
			{
				((AbstractSpineNPC)npc).X -= matrix.M41;
				((AbstractSpineNPC)npc).Y -= matrix.M42;
			}
		}
		else if (npc is BreathingNPC)
		{
			spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, null, null, null, null, (!npc.InTalking) ? matrix : Matrix.Identity);
			((BreathingNPC)npc).Draw(spriteBatch);
			spriteBatch.End();
		}
	}

	public virtual void SwitchToSubscene(string subscene)
	{
		Subscene = subscene;
	}

	public NPCLayer GetNPCLayer(string name)
	{
		return GetLayer(NPCLayer.Prefix + name) as NPCLayer;
	}

	public NPCLayer GetNPCLayer(NPCLocation location)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer is NPCLayer && ((NPCLayer)layer).NPC.Location == location) as NPCLayer;
	}

	public NPCLayer GetNPCLayer<T>()
	{
		return GetLayer(NPCLayer.Prefix + typeof(T).Name) as NPCLayer;
	}

	public NPCLayer AddNPC(AbstractNPC npc, LayerOrder order)
	{
		string name = npc.GetType().Name;
		NPCLayer layer = GetNPCLayer(name) ?? new NPCLayer(this, npc, order);
		layer.Layer = order;
		Logger.Log(ConsoleColor.White, "Debug", "Adding NPC '{0}' in order {1} ({2}, {3}, {4}x{5})", name.EndsWith("NPC") ? name.Substring(0, name.Length - 3) : name, (int)order, npc.X, npc.Y, npc.Width, npc.Height);
		AddLayer(layer, (order == LayerOrder.Background) ? OrderBackgroundOverlay : OrderForegroundOverlay);
		return layer;
	}

	public T AddLayer<T>(T layer, int zorder, int state = 0) where T : AbstractLayer
	{
		layer.ZOrder = zorder;
		if (!(layer is NPCLayer))
		{
			Logger.Log(ConsoleColor.White, "Debug", "Adding layer '{0}' in order {1} ({2}, {3}, {4}x{5})", layer.Name, ((byte)zorder), layer.X, layer.Y, layer.Width, layer.Height);
		}
		Layers.Add(layer);
		IsOrderingChanged = true;
		return layer;
	}

	public void RefreshLayerOrdering()
	{
		IsOrderingChanged = true;
	}

	public virtual void Autosave() {}
}
