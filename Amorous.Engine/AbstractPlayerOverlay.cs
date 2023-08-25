using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class AbstractPlayerOverlay
{ // _21uBmerICJi18moE2gpxlEipBgz
	private IAmorous game;

	public List<AbstractLayer> Layers { get; private set; }

	protected IAmorous Game => game;

	protected AbstractPlayerOverlay(IAmorous game)
	{
		this.game = game;
		Layers = new List<AbstractLayer>();
	}

	public AbstractLayer GetLayer(string name)
	{
		return Layers.FirstOrDefault((AbstractLayer layer) => layer.Name == name);
	}

	public SpriteLayer AddSpriteLayer(string name, string texture, int x, int y, int zorder = 0, float scale = 1f)
	{
		Texture2D texture2D = game.Content.Load<Texture2D>(texture);
		SpriteLayer layer = new SpriteLayer(Game.Scene, name, texture2D)
		{
			Disposable = true,
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
		foreach (AbstractLayer layer in Layers.Where((AbstractLayer layer) => layer.Updatable))
		{
			layer.Update(gameTime);
		}
	}

	public virtual void Draw(SpriteBatch spriteBatch)
	{
		IOrderedEnumerable<AbstractLayer> visibleLayers = from layer in Layers
			where layer.Visible
			orderby layer.ZOrder, layer.LayerOrder
			select layer;
		foreach (AbstractLayer layer in visibleLayers)
		{
			layer.Draw(spriteBatch);
		}
	}

	public virtual void End()
	{
		foreach (AbstractLayer layer in Layers)
		{
			if (layer.Disposable)
			{
				layer.Remove();
			}
		}
	}
}
