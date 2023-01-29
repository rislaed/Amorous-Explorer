using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class AbstractPlayerSkin
{ // _21uBmerICJi18moE2gpxlEipBgz
	private IAmorous Amorous;
	public List<AbstractLayer> Layers { get; private set; }
	protected IAmorous Game => Amorous;

	protected AbstractPlayerSkin(IAmorous game)
	{
		Amorous = game;
		Layers = new List<AbstractLayer>();
	}

	public AbstractLayer GetLayer(string name)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer.Name == name);
	}

	public SpriteLayer NewSpriteLayer(string name, string texture, int x, int y, int zorder = 0, float scale = 1f)
	{
		Texture2D texture2D = Amorous.Content.Load<Texture2D>(texture);
		SpriteLayer layer = new SpriteLayer(Game.Scene, name, texture2D)
		{
			Removable = true,
			X = x,
			Y = y,
			ZOrder = zorder,
			Scale = scale
		};
		Layers.Add(layer);
		return layer;
	}

	public abstract void Initialize(PlayerData data);

	public virtual void Update(GameTime gameTime)
	{
		foreach (AbstractLayer item in Layers.Where((AbstractLayer layer) => layer.Updatable))
		{
			item.Update(gameTime);
		}
	}

	public virtual void Draw(SpriteBatch spriteBatch)
	{
		IOrderedEnumerable<AbstractLayer> orderedEnumerable = from layer in Layers
			where layer.Visible
			orderby layer.ZOrder, layer.LayerOrder
			select layer;
		foreach (AbstractLayer item in orderedEnumerable)
		{
			item.Draw(spriteBatch);
		}
	}

	public virtual void End()
	{
		foreach (AbstractLayer item in Layers)
		{
			if (item.Removable)
			{
				item.Remove();
			}
		}
	}
}
