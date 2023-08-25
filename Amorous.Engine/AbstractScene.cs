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
	public const int ORDER_BACKGROUND = 0;
	public const int ORDER_BACKGROUND_OVERLAY = 1;
	public const int ORDER_FOREGROUND = 2;
	public const int ORDER_FOREGROUND_OVERLAY = 3;

	protected bool IsOrderingChanged;

	private AbstractLayer hoveredOrCapturedLayer;

	public IAmorous Game { get; private set; }
	public List<AbstractLayer> Layers { get; private set; }
	public string Subscene { get; private set; }
	public static bool CapturedByOverlay { get; set; }

	protected BlendState Blending { get; set; }

	public Desktop Desktop { get; set; }

	protected AbstractScene(IAmorous game)
	{
		Game = game;
		Layers = new List<AbstractLayer>();
		Blending = BlendState.NonPremultiplied;
		Desktop = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		Desktop.SetSkin("Assets/GUI/Squid/DefaultSkin", "Assets/GUI/Squid/DefaultSkin - Blue");
		Logger.Debug("Initiating scene '{0}' with desktop state {1}", GetType().Name, Desktop.AutoId);
	}

	public virtual void Start() {}
	public virtual void End() {}

	public AbstractLayer GetLayer(string name)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer.Name == name);
	}

	public SpriteLayer AddSpriteLayer(string name, string texture, int x, int y)
	{
		return AddLayer(CreateSpriteLayer(name, texture, x, y), ORDER_BACKGROUND);
	}

	public AnimatedLayer AddAnimatedLayer(string name, int x, int y, int delay, params string[] images)
	{
		return AddLayer(CreateAnimatedLayer(name, x, y, delay, images), ORDER_BACKGROUND);
	}

	public DeviationLayer AddDeviationLayer(string name, string texture, int x, int y, float speed, int ox, int oy)
	{
		return AddLayer(CreateDeviationLayer(name, texture, x, y, speed, ox, oy), ORDER_BACKGROUND);
	}

	public FadingLayer AddFadingLayer(string name, string texture, int x, int y, int timePerFade, int offset = 0, int delay = 0)
	{
		return AddLayer(CreateFadingLayer(name, texture, x, y, timePerFade, offset, delay), ORDER_BACKGROUND);
	}

	public InteractableLayer AddInteractableLayer(string name, string texture, int x, int y, string touchTexture, int touchX, int touchY, string interaction)
	{
		return AddLayer(CreateInteractableLayer(name, texture, x, y, touchTexture, touchX, touchY, interaction), ORDER_BACKGROUND);
	}

	public ClickableLayer AddClickableLayer(string name, string texture, int x, int y, Action action)
	{
		return AddLayer(CreateClickableLayer(name, texture, x, y, action), ORDER_BACKGROUND);
	}

	public AnimatedClickableLayer AddAnimatedClickableLayer(string name, int x, int y, Action action, int delay, params string[] images)
	{
		return AddLayer(CreateAnimatedClickableLayer(name, x, y, action, delay, images), ORDER_BACKGROUND);
	}

	public SpriteLayer AddSpriteLayerAbove(string name, string texture, int x, int y)
	{
		return AddLayer(CreateSpriteLayer(name, texture, x, y), ORDER_FOREGROUND);
	}

	public AnimatedLayer AddAnimatedLayerAbove(string name, int x, int y, int delay, params string[] images)
	{
		return AddLayer(CreateAnimatedLayer(name, x, y, delay, images), ORDER_FOREGROUND);
	}

	public DeviationLayer AddDeviationLayerAbove(string name, string texture, int x, int y, float speed, int ox, int oy)
	{
		return AddLayer(CreateDeviationLayer(name, texture, x, y, speed, ox, oy), ORDER_FOREGROUND);
	}

	public FadingLayer AddFadingLayerAbove(string name, string texture, int x, int y, int timePerFade, int offset = 0, int delay = 0)
	{
		return AddLayer(CreateFadingLayer(name, texture, x, y, timePerFade, offset, delay), ORDER_FOREGROUND);
	}

	public InteractableLayer AddInteractableLayerAbove(string name, string texture, int x, int y, string touchTexture, int touchX, int touchY, string interaction)
	{
		return AddLayer(CreateInteractableLayer(name, texture, x, y, touchTexture, touchX, touchY, interaction), ORDER_FOREGROUND);
	}

	public ClickableLayer AddClickableLayerAbove(string name, string texture, int x, int y, Action action)
	{
		return AddLayer(CreateClickableLayer(name, texture, x, y, action), ORDER_FOREGROUND);
	}

	public AnimatedClickableLayer AddAnimatedClickableLayerAbove(string name, int x, int y, Action action, int delay, params string[] images)
	{
		return AddLayer(CreateAnimatedClickableLayer(name, x, y, action, delay, images), ORDER_FOREGROUND);
	}

	protected SpriteLayer CreateSpriteLayer(string name, string texture, int x, int y)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new SpriteLayer(this, name, texture2D)
		{
			X = x,
			Y = y
		};
	}

	private AnimatedLayer CreateAnimatedLayer(string name, int x, int y, int delay, params string[] images)
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

	private DeviationLayer CreateDeviationLayer(string name, string texture, int x, int y, float speed, int ox, int oy)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new DeviationLayer(this, name, texture2D, speed, new Vector2(ox, oy))
		{
			X = x,
			Y = y
		};
	}

	private FadingLayer CreateFadingLayer(string name, string texture, int x, int y, int timePerFade, int offset, int delay)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new FadingLayer(this, name, texture2D, timePerFade, offset, delay)
		{
			X = x,
			Y = y
		};
	}

	private InteractableLayer CreateInteractableLayer(string name, string texture, int x, int y, string activeTexture, int touchX, int touchY, string text)
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
			TouchX = touchX,
			TouchY = touchY
		};
	}

	private ClickableLayer CreateClickableLayer(string name, string texture, int x, int y, Action action)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new ClickableLayer(this, name, texture2D, action)
		{
			X = x,
			Y = y
		};
	}

	private AnimatedClickableLayer CreateAnimatedClickableLayer(string name, int x, int y, Action action, int delay, params string[] images)
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
		UpdateInternal(gameTime, Layers);
		if (Game.Cutscene != null)
		{
			return;
		}
		if (!CapturedByOverlay)
		{
			bool pressed;
			if ((pressed = Game.Controller.IsPressed(ControllerButtonType.LeftButton)) && hoveredOrCapturedLayer != null)
			{
				hoveredOrCapturedLayer.Continue();
				hoveredOrCapturedLayer = null;
			}
			Microsoft.Xna.Framework.Point point = Game.Canvas.GlobalToTouch(Game.Controller.Cursor);
			Touch(point, pressed, Layers);
		}
		Desktop.Update();
	}

	private void UpdateInternal(GameTime gameTime, IEnumerable<AbstractLayer> layers)
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
		AbstractLayer hoveredLayer = null;
		Microsoft.Xna.Framework.Rectangle bounds = default(Microsoft.Xna.Framework.Rectangle);
		for (int index = layers.Count - 1; index >= 0; index--)
		{
			AbstractLayer layer = layers[index];
			if ((layer is InteractableLayer || layer is ClickableLayer || layer is AnimatedClickableLayer || layer is NPCLayer) && layer.Updatable)
			{
				if (!(layer is NPCLayer))
				{
					layer.Leave();
					if (hoveredLayer == null)
					{
						bounds.X = (int)layer.X;
						bounds.Y = (int)layer.Y;
						bounds.Width = layer.Width;
						bounds.Height = layer.Height;
						if (bounds.Contains(cursor))
						{
							layer.Enter();
							hoveredLayer = layer;
						}
					}
				}
				else
				{
					AbstractNPC npc = ((NPCLayer)layer).NPC;
					npc.IsHovered = false;
					if (hoveredLayer == null)
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
							hoveredLayer = layer;
						}
					}
				}
			}
		}
		if (!(hoveredLayer != null && pressed))
		{
			return;
		}
		if (!(hoveredLayer is NPCLayer))
		{
			if (hoveredLayer.Click())
			{
				hoveredOrCapturedLayer = hoveredLayer;
			}
			return;
		}
		AbstractNPC hoveredNPC = ((NPCLayer)hoveredLayer).NPC;
		if (hoveredNPC.Click != null)
		{
			hoveredNPC.Click();
			hoveredOrCapturedLayer = hoveredLayer;
		}
	}

	public virtual void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		DrawInternal(spriteBatch, skeletonMeshRenderer, matrix, Layers);
	}

	public virtual void DrawOverlay(SpriteBatch spriteBatch)
	{
		Desktop.Draw();
	}

	private void DrawInternal(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix, IEnumerable<AbstractLayer> layers)
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
						((DrawableLayer)layer).Matrix = matrix;
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
				if (!spineLayer.LockedOnScreen)
				{
					spineLayer.OffsetX += matrix.M41;
					spineLayer.OffsetY += matrix.M42;
				}
				spineLayer.Draw(spriteBatch, skeletonMeshRenderer);
				if (!spineLayer.LockedOnScreen)
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
			if (!npc.LockedOnScreen)
			{
				((AbstractSpineNPC)npc).X += matrix.M41;
				((AbstractSpineNPC)npc).Y += matrix.M42;
			}
			((AbstractSpineNPC)npc).Draw(spriteBatch, skeletonMeshRenderer);
			if (!npc.LockedOnScreen)
			{
				((AbstractSpineNPC)npc).X -= matrix.M41;
				((AbstractSpineNPC)npc).Y -= matrix.M42;
			}
		}
		else if (npc is BreathingNPC)
		{
			spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, null, null, null, null, (!npc.LockedOnScreen) ? matrix : Matrix.Identity);
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
		return GetLayer(NPCLayer.PREFIX + name) as NPCLayer;
	}

	public NPCLayer GetNPCLayer(NPCLocation location)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer is NPCLayer && ((NPCLayer)layer).NPC.Location == location) as NPCLayer;
	}

	public NPCLayer GetNPCLayer<T>()
	{
		return GetLayer(NPCLayer.PREFIX + typeof(T).Name) as NPCLayer;
	}

	public NPCLayer AddNPC(AbstractNPC npc, LayerOrder order)
	{
		string name = npc.GetType().Name;
		NPCLayer layer = GetNPCLayer(name) ?? new NPCLayer(this, npc, order);
		layer.Layer = order;
		Logger.Debug("Adding NPC '{0}' in order {1} ({2}, {3}, {4}x{5})", name.EndsWith("NPC") ? name.Substring(0, name.Length - 3) : name, (int)order, npc.X, npc.Y, npc.Width, npc.Height);
		AddLayer(layer, (order == LayerOrder.Background) ? ORDER_BACKGROUND_OVERLAY : ORDER_FOREGROUND_OVERLAY);
		return layer;
	}

	public T AddLayer<T>(T layer, int zorder, int state = 0) where T : AbstractLayer
	{
		layer.ZOrder = zorder;
		if (!(layer is NPCLayer))
		{
			Logger.Debug("Adding layer '{0}' in order {1} ({2}, {3}, {4}x{5})", layer.Name, ((byte)zorder), layer.X, layer.Y, layer.Width, layer.Height);
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
