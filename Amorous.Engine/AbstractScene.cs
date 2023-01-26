using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;
using Squid;

public abstract class AbstractScene
{
	public const int OrderBackground = 0;
	public const int OrderBackgroundOverlay = 1;
	public const int OrderForeground = 2;
	public const int OrderForegroundOverlay = 3;

	protected bool IsOrderingChanged;
	private AbstractLayer CapturedLayer;
	public IAmorous Game { get; private set; }
	public List<AbstractLayer> Layers { get; private set; }
	public string Variant { get; private set; }
	public static bool CapturedByOverlay { get; set; }
	protected BlendState Blending { get; set; }
	public Desktop Squid { get; set; }

	protected AbstractScene(IAmorous amorous)
	{
		Game = amorous;
		Layers = new List<AbstractLayer>();
		Blending = BlendState.NonPremultiplied;
		Squid = new Desktop
		{
			Skin = Gui.GenerateStandardSkin(),
			Size = new Squid.Point(1920, 1080)
		};
		Squid.SetSkin("Assets/GUI/Squid/DefaultSkin", "Assets/GUI/Squid/DefaultSkin - Blue");
	}

	public virtual void ResetVariation() {}
	public virtual void End() {}

	public AbstractLayer GetLayer(string name)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer.Name == name);
	}

	public TexturedLayer AddTexturedLayer(string name, string texture, int x, int y)
	{
		TexturedLayer layer = NewTexturedLayer(name, texture, x, y);
		return AddLayer(layer, OrderBackground);
	}

	public AnimatedLayer AddAnimatedLayer(string name, int x, int y, int delay, params string[] textures)
	{
		AnimatedLayer layer = NewAnimatedLayer(name, x, y, delay, textures);
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

	public AnimatedClickableLayer AddAnimatedClickableLayer(string name, int x, int y, Action click, int delay, params string[] textures)
	{
		AnimatedClickableLayer layer = NewAnimatedClickableLayer(name, x, y, click, delay, textures);
		return AddLayer(layer, OrderBackground);
	}

	public TexturedLayer AddForegroundTexturedLayer(string name, string texture, int x, int y)
	{
		TexturedLayer layer = NewTexturedLayer(name, texture, x, y);
		return AddLayer(layer, OrderForeground);
	}

	public AnimatedLayer AddForegroundAnimatedLayer(string name, int x, int y, int delay, params string[] textures)
	{
		AnimatedLayer layer = NewAnimatedLayer(name, x, y, delay, textures);
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

	public AnimatedClickableLayer AddForegroundAnimatedClickableLayer(string name, int x, int y, Action click, int delay, params string[] textures)
	{
		AnimatedClickableLayer layer = NewAnimatedClickableLayer(name, x, y, click, delay, textures);
		return AddLayer(layer, OrderForeground);
	}

	protected TexturedLayer NewTexturedLayer(string name, string texture, int x, int y)
	{
		Texture2D texture2D = Game.Content.Load<Texture2D>(texture);
		return new TexturedLayer(this, name, texture2D)
		{
			X = x,
			Y = y
		};
	}

	private AnimatedLayer NewAnimatedLayer(string name, int x, int y, int delay, params string[] textures)
	{
		if (textures.Length == 0)
		{
			throw new ArgumentException("Images cannot be empty");
		}
		List<Texture2D> list = new List<Texture2D>(textures.Length);
		foreach (string assetName in textures)
		{
			list.Add(Game.Content.Load<Texture2D>(assetName));
		}
		return new AnimatedLayer(this, name, delay, list)
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
		return new InteractableLayer(this, name, texture2D, activeTexture2D, activeTexture)
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

	private AnimatedClickableLayer NewAnimatedClickableLayer(string name, int x, int y, Action action, int delay, params string[] textures)
	{
		if (textures.Length == 0)
		{
			throw new ArgumentException("Images cannot be empty");
		}
		List<Texture2D> list = new List<Texture2D>(textures.Length);
		foreach (string assetName in textures)
		{
			list.Add(Game.Content.Load<Texture2D>(assetName));
		}
		return new AnimatedClickableLayer(this, name, action, delay, list)
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
		if (Game._5zNdOw7qHmuCAPJFMr3SsZdBlCr != null)
		{
			return;
		}
		if (!CapturedByOverlay)
		{
			bool bool_;
			if ((bool_ = Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton)) && CapturedLayer != null)
			{
				CapturedLayer.Continue();
				CapturedLayer = null;
			}
			Microsoft.Xna.Framework.Point point = Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._e6KgAy4CTN1JFYwA88grvAEmDxX(Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
			Touch(point, bool_, Layers);
		}
		Squid.Update();
	}

	private void UpdateLayers(GameTime gameTime, IEnumerable<AbstractLayer> layers)
	{
		foreach (AbstractLayer item in layers)
		{
			if (item.Updatable)
			{
				item.Update(gameTime);
			}
		}
	}

	private void Touch(Microsoft.Xna.Framework.Point point, bool bool_0, List<AbstractLayer> layers)
	{
		AbstractLayer layer = null;
		Microsoft.Xna.Framework.Rectangle rectangle = default(Microsoft.Xna.Framework.Rectangle);
		for (int num = layers.Count - 1; num >= 0; num--)
		{
			AbstractLayer next = layers[num];
			if ((next is InteractableLayer || next is ClickableLayer || next is AnimatedClickableLayer || next is NPCLayer) && next.Updatable)
			{
				if (!(next is NPCLayer))
				{
					next.Unhover();
					if (layer == null)
					{
						rectangle.X = (int)next.X;
						rectangle.Y = (int)next.Y;
						rectangle.Width = next.Width;
						rectangle.Height = next.Height;
						if (rectangle.Contains(point))
						{
							next.Hover();
							layer = next;
						}
					}
				}
				else
				{
					AbstractNPC NPC = ((NPCLayer)next).NPC;
					NPC._IvIFs0Tl6RHdTn3daJXsNCXCNyO = false;
					if (layer == null)
					{
						rectangle.X = (int)NPC.X;
						rectangle.Y = (int)NPC.Y;
						rectangle.Width = (int)((float)NPC.Width * NPC.Scale);
						rectangle.Height = (int)((float)NPC.Height * NPC.Scale);
						if (NPC is _tfDAeR6npiqJMLRSXPO1DxGA0TgA)
						{
							rectangle.X -= rectangle.Width / 2;
							rectangle.Y -= rectangle.Height;
						}
						if (NPC.Click != null && rectangle.Contains(point))
						{
							NPC._IvIFs0Tl6RHdTn3daJXsNCXCNyO = true;
							layer = next;
						}
					}
				}
			}
		}
		if (!(layer != null && bool_0))
		{
			return;
		}
		if (!(layer is NPCLayer))
		{
			if (layer.Click())
			{
				CapturedLayer = layer;
			}
			return;
		}
		AbstractNPC npc = ((NPCLayer)layer).NPC;
		if (npc.Click != null)
		{
			npc.Click();
			CapturedLayer = layer;
		}
	}

	public virtual void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		DrawLayers(spriteBatch, skeletonMeshRenderer, matrix, Layers);
	}

	public virtual void Render(SpriteBatch spriteBatch)
	{
		Squid.Draw();
	}

	private void DrawLayers(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix, IEnumerable<AbstractLayer> layers)
	{
		bool flag = false;
		foreach (AbstractLayer item in layers)
		{
			if (!item.Visible)
			{
				continue;
			}
			if (!(item is NPCLayer))
			{
				if (!(item is _WBXNT6eIVGk6ZKExRBJ6JxXE6zb))
				{
					if (item is _fAUddQEKfZyemRb327NhM3GGlmzA)
					{
						if (flag)
						{
							spriteBatch.End();
							flag = false;
						}
						((_fAUddQEKfZyemRb327NhM3GGlmzA)item)._3TrGrUra7cqeIXkbZOrfaoQaD5F = matrix;
						item.Draw(spriteBatch);
					}
					else
					{
						if (!flag)
						{
							spriteBatch.Begin(SpriteSortMode.Deferred, nullable_0: matrix, blendState_0: Blending);
							flag = true;
						}
						item.Draw(spriteBatch);
					}
					continue;
				}
				if (flag)
				{
					spriteBatch.End();
					flag = false;
				}
				_WBXNT6eIVGk6ZKExRBJ6JxXE6zb wBXNT6eIVGk6ZKExRBJ6JxXE6zb = (_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)item;
				if (!wBXNT6eIVGk6ZKExRBJ6JxXE6zb._zkHMlDFkja4TqmjdlHuZRCj8FCB)
				{
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc += matrix.M41;
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY += matrix.M42;
				}
				wBXNT6eIVGk6ZKExRBJ6JxXE6zb.Draw(spriteBatch, skeletonMeshRenderer);
				if (!wBXNT6eIVGk6ZKExRBJ6JxXE6zb._zkHMlDFkja4TqmjdlHuZRCj8FCB)
				{
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc -= matrix.M41;
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY -= matrix.M42;
				}
			}
			else
			{
				if (flag)
				{
					spriteBatch.End();
					flag = false;
				}
				DrawNPC(item as NPCLayer, spriteBatch, skeletonMeshRenderer, matrix);
			}
		}
		if (flag)
		{
			spriteBatch.End();
		}
	}

	private void DrawNPC(NPCLayer npclayer, SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		AbstractNPC NPC = npclayer.NPC;
		if (NPC is _tfDAeR6npiqJMLRSXPO1DxGA0TgA)
		{
			if (!NPC._zkHMlDFkja4TqmjdlHuZRCj8FCB)
			{
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)NPC).X += matrix.M41;
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)NPC).Y += matrix.M42;
			}
			((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)NPC).Draw(spriteBatch, skeletonMeshRenderer);
			if (!NPC._zkHMlDFkja4TqmjdlHuZRCj8FCB)
			{
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)NPC).X -= matrix.M41;
				((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)NPC).Y -= matrix.M42;
			}
		}
		else if (NPC is _xZgbANe7gi6i2DAhBEkKpR1QFLe)
		{
			spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, null, null, null, null, (!NPC._zkHMlDFkja4TqmjdlHuZRCj8FCB) ? matrix : Matrix.Identity);
			((_xZgbANe7gi6i2DAhBEkKpR1QFLe)NPC).Draw(spriteBatch);
			spriteBatch.End();
		}
	}

	public virtual void SetVariant(string skin)
	{
		Variant = skin;
	}

	public NPCLayer GetNPCLayer(string name)
	{
		return GetLayer(NPCLayer.Prefix name) as NPCLayer;
	}

	public NPCLayer GetNPCLayer(NPCLocation npclocation)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer is NPCLayer && ((NPCLayer)layer).NPC.Location == npclocation) as NPCLayer;
	}

	public NPCLayer GetNPCLayer<T>()
	{
		return GetLayer(NPCLayer.Prefix + typeof(T).Name) as NPCLayer;
	}

	public NPCLayer AddNPC(AbstractNPC abstractNPC, LayerOrder layerOrder)
	{
		NPCLayer npcLayer = GetNPCLayer(abstractNPC.GetType().Name) ?? new NPCLayer(this, abstractNPC, layerOrder);
		npcLayer.Layer = layerOrder;
		AddLayer(npcLayer, (layerOrder == LayerOrder.Background) ? OrderBackgroundOverlay : OrderForegroundOverlay);
		return npcLayer;
	}

	public T AddLayer<T>(T layer, int zorder, int state = 0) where T : AbstractLayer
	{
		layer.ZOrder = zorder;
		Layers.Add(layer);
		IsOrderingChanged = true;
		return layer;
	}

	public void RefreshLayerOrdering()
	{
		IsOrderingChanged = true;
	}

	public virtual void RefreshStorage() {}
}
