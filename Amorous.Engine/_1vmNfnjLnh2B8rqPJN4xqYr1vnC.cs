using System;
using System.Reflection;
using Amorous.Engine.Data.Cutscenes;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public class _1vmNfnjLnh2B8rqPJN4xqYr1vnC : AbstractEvent<SpawnNPCEventData>
{
	private AbstractNPC _v5mBBzOHST4Ij2jetldrF2beJtbA;

	public string NPC { get; private set; }

	public string Location { get; private set; }

	public string Layer { get; private set; }

	public string Voice { get; private set; }

	public string Head { get; private set; }

	public string Pose { get; private set; }

	public string[] Clothes { get; private set; }

	public _1vmNfnjLnh2B8rqPJN4xqYr1vnC(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(SpawnNPCEventData spawnNPCEventData_0)
	{
		base.SetData(spawnNPCEventData_0);
		NPC = spawnNPCEventData_0.NPC;
		Location = spawnNPCEventData_0.Location;
		Layer = spawnNPCEventData_0.Layer;
		Voice = spawnNPCEventData_0.Voice;
		Head = spawnNPCEventData_0.Head;
		Pose = spawnNPCEventData_0.Pose;
		Clothes = ((spawnNPCEventData_0.Clothes == null) ? null : spawnNPCEventData_0.Clothes.ToArray());
	}

	public override void ResetVariation()
	{
		base.ResetVariation();
		LayerOrder result = ((!Enum.TryParse<LayerOrder>(Layer, out result)) ? LayerOrder.Background : result);
		_v5mBBzOHST4Ij2jetldrF2beJtbA = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg(NPC, result);
		if (_v5mBBzOHST4Ij2jetldrF2beJtbA == null)
		{
			return;
		}
		_v5mBBzOHST4Ij2jetldrF2beJtbA._zkHMlDFkja4TqmjdlHuZRCj8FCB = true;
		if (_v5mBBzOHST4Ij2jetldrF2beJtbA._rAt6TRbgK04lvrs5QPjcd0n26pk != null)
		{
			Type[] rAt6TRbgK04lvrs5QPjcd0n26pk = _v5mBBzOHST4Ij2jetldrF2beJtbA._rAt6TRbgK04lvrs5QPjcd0n26pk;
			foreach (Type type in rAt6TRbgK04lvrs5QPjcd0n26pk)
			{
				AbstractNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.GetNPCLayer(type.Name);
				if (qGGOTxZ8aNWGh0hc26wcmx8wmwT != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT.Location != 0)
				{
					if (Location == null)
					{
						Location = qGGOTxZ8aNWGh0hc26wcmx8wmwT.Location.ToString();
					}
					if (Head == null)
					{
						Head = qGGOTxZ8aNWGh0hc26wcmx8wmwT.Head;
					}
					if (Pose == null)
					{
						Pose = qGGOTxZ8aNWGh0hc26wcmx8wmwT.Pose;
					}
					if (Clothes == null)
					{
						Clothes = qGGOTxZ8aNWGh0hc26wcmx8wmwT.Clothes;
					}
					qGGOTxZ8aNWGh0hc26wcmx8wmwT._CX43jhSKNOViVFqkMliNa9qgGon();
					break;
				}
			}
		}
		if (!Enum.TryParse<NPCLocation>(Location, out var result2))
		{
			result2 = ((_v5mBBzOHST4Ij2jetldrF2beJtbA.Location == NPCLocation.None) ? NPCLocation.Middle : _v5mBBzOHST4Ij2jetldrF2beJtbA.Location);
			AbstractNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT2 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.GetNPCLayer(result2);
			if (qGGOTxZ8aNWGh0hc26wcmx8wmwT2 != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT2 != _v5mBBzOHST4Ij2jetldrF2beJtbA)
			{
				qGGOTxZ8aNWGh0hc26wcmx8wmwT2._CX43jhSKNOViVFqkMliNa9qgGon();
			}
			_v5mBBzOHST4Ij2jetldrF2beJtbA._7d2DAwjp6FutkJY09U0Mlk43Nmn(result2, Head, Pose, Clothes);
		}
		else if (result2 != 0)
		{
			AbstractNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT3 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.GetNPCLayer(result2);
			if (qGGOTxZ8aNWGh0hc26wcmx8wmwT3 != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT3 != _v5mBBzOHST4Ij2jetldrF2beJtbA)
			{
				qGGOTxZ8aNWGh0hc26wcmx8wmwT3._CX43jhSKNOViVFqkMliNa9qgGon();
			}
			_v5mBBzOHST4Ij2jetldrF2beJtbA._7d2DAwjp6FutkJY09U0Mlk43Nmn(result2, Head, Pose, Clothes);
			NPCLayer NPCLayer2 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.Scene.GetNPCLayer(NPC);
			switch (result2)
			{
			case NPCLocation.Left:
			case NPCLocation.Right:
				NPCLayer2.LayerOrder = 0;
				break;
			case NPCLocation.Middle:
				NPCLayer2.LayerOrder = 1;
				break;
			}
		}
		else
		{
			_v5mBBzOHST4Ij2jetldrF2beJtbA._CX43jhSKNOViVFqkMliNa9qgGon();
		}
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _v5mBBzOHST4Ij2jetldrF2beJtbA == null || !_v5mBBzOHST4Ij2jetldrF2beJtbA._fsCqU0Uh34vrMEsAqlf2BqbTz5B;
	}
}
