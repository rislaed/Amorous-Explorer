using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class _21uBmerICJi18moE2gpxlEipBgz
{
	private IAmorous Amorous;

	public List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> Layers { get; private set; }

	protected IAmorous Game => Amorous;

	protected _21uBmerICJi18moE2gpxlEipBgz(IAmorous game)
	{
		Amorous = game;
		Layers = new List<_ujAkjlfN5TywwbLAUDzPvtab6uJ>();
	}

	public _ujAkjlfN5TywwbLAUDzPvtab6uJ _0c5TjZklJbu1wzYG2FIcvf3SIdh(string string_0)
	{
		return Layers.FirstOrDefault((_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0) => _ujAkjlfN5TywwbLAUDzPvtab6uJ_0.Name == string_0);
	}

	public _uqydQVaCmCvK7zzWs5W4gZFpKBu _Iz47swAAB7d2iX6PQ1xTIJIv8MJ(string string_0, string string_1, int int_0, int int_1, int int_2 = 0, float float_0 = 1f)
	{
		Texture2D texture2D_ = Amorous._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		_uqydQVaCmCvK7zzWs5W4gZFpKBu uqydQVaCmCvK7zzWs5W4gZFpKBu = new _uqydQVaCmCvK7zzWs5W4gZFpKBu(Game.Scene, string_0, texture2D_)
		{
			_C6GAq9XPMC9PQPnaaRqYWpv4V6S = true,
			X = int_0,
			Y = int_1,
			_ac2H6kMdrgPhXXxabsikjji4SiT = int_2,
			_fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0
		};
		Layers.Add(uqydQVaCmCvK7zzWs5W4gZFpKBu);
		return uqydQVaCmCvK7zzWs5W4gZFpKBu;
	}

	public abstract void Initialize(PlayerData _opIJo2jLUqdOL5yAFP4yzXce0DG_0);

	public virtual void Update(GameTime gameTime_0)
	{
		foreach (_ujAkjlfN5TywwbLAUDzPvtab6uJ item in Layers.Where((_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0) => _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._3ZeCDXqcWHY4XJDBGyav3UzxYaHA))
		{
			item.Update(gameTime_0);
		}
	}

	public virtual void Draw(SpriteBatch spriteBatch_0)
	{
		IOrderedEnumerable<_ujAkjlfN5TywwbLAUDzPvtab6uJ> orderedEnumerable = from _ujAkjlfN5TywwbLAUDzPvtab6uJ_0 in Layers
			where _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._Fxy2SlgceW90FloFw6a1AEJODYA
			orderby _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._ac2H6kMdrgPhXXxabsikjji4SiT, _ujAkjlfN5TywwbLAUDzPvtab6uJ_0.LayerOrder
			select _ujAkjlfN5TywwbLAUDzPvtab6uJ_0;
		foreach (_ujAkjlfN5TywwbLAUDzPvtab6uJ item in orderedEnumerable)
		{
			item.Draw(spriteBatch_0);
		}
	}

	public virtual void End()
	{
		foreach (_ujAkjlfN5TywwbLAUDzPvtab6uJ item in Layers)
		{
			if (item._C6GAq9XPMC9PQPnaaRqYWpv4V6S)
			{
				item._ymyneWF6dfrtfUI08wyb3KExq0D();
			}
		}
	}
}
