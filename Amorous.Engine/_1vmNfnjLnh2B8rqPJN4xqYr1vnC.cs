using System;
using System.Reflection;
using Amorous.Engine.Data.Cutscenes;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public class _1vmNfnjLnh2B8rqPJN4xqYr1vnC : AbstractEvent<SpawnNPCEventData>
{
	private _QGGOTxZ8aNWGh0hc26wcmx8wmwT _v5mBBzOHST4Ij2jetldrF2beJtbA;

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

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
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
				_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._VvFE2zgy4FbDjvaEvb67tXJ7aRm(type.Name);
				if (qGGOTxZ8aNWGh0hc26wcmx8wmwT != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT._9m9LEAgaqaeXydYhykSBmf9BrDG != 0)
				{
					if (Location == null)
					{
						Location = qGGOTxZ8aNWGh0hc26wcmx8wmwT._9m9LEAgaqaeXydYhykSBmf9BrDG.ToString();
					}
					if (Head == null)
					{
						Head = qGGOTxZ8aNWGh0hc26wcmx8wmwT._mdS7Bu4eiPPwoFWUcGEOTzh73TJ;
					}
					if (Pose == null)
					{
						Pose = qGGOTxZ8aNWGh0hc26wcmx8wmwT._vzNADWxcLucI3DyP1CebcfYXRut;
					}
					if (Clothes == null)
					{
						Clothes = qGGOTxZ8aNWGh0hc26wcmx8wmwT._QeyVQAHb3TegEFsv9IPdYmxNkGZ;
					}
					qGGOTxZ8aNWGh0hc26wcmx8wmwT._CX43jhSKNOViVFqkMliNa9qgGon();
					break;
				}
			}
		}
		if (!Enum.TryParse<NPCLocation>(Location, out var result2))
		{
			result2 = ((_v5mBBzOHST4Ij2jetldrF2beJtbA._9m9LEAgaqaeXydYhykSBmf9BrDG == NPCLocation.None) ? NPCLocation.Middle : _v5mBBzOHST4Ij2jetldrF2beJtbA._9m9LEAgaqaeXydYhykSBmf9BrDG);
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT2 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._VvFE2zgy4FbDjvaEvb67tXJ7aRm(result2);
			if (qGGOTxZ8aNWGh0hc26wcmx8wmwT2 != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT2 != _v5mBBzOHST4Ij2jetldrF2beJtbA)
			{
				qGGOTxZ8aNWGh0hc26wcmx8wmwT2._CX43jhSKNOViVFqkMliNa9qgGon();
			}
			_v5mBBzOHST4Ij2jetldrF2beJtbA._7d2DAwjp6FutkJY09U0Mlk43Nmn(result2, Head, Pose, Clothes);
		}
		else if (result2 != 0)
		{
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT qGGOTxZ8aNWGh0hc26wcmx8wmwT3 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game._VvFE2zgy4FbDjvaEvb67tXJ7aRm(result2);
			if (qGGOTxZ8aNWGh0hc26wcmx8wmwT3 != null && qGGOTxZ8aNWGh0hc26wcmx8wmwT3 != _v5mBBzOHST4Ij2jetldrF2beJtbA)
			{
				qGGOTxZ8aNWGh0hc26wcmx8wmwT3._CX43jhSKNOViVFqkMliNa9qgGon();
			}
			_v5mBBzOHST4Ij2jetldrF2beJtbA._7d2DAwjp6FutkJY09U0Mlk43Nmn(result2, Head, Pose, Clothes);
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.Scene._VvFE2zgy4FbDjvaEvb67tXJ7aRm(NPC);
			switch (result2)
			{
			case NPCLocation.Left:
			case NPCLocation.Right:
				_3IHp43rpkJgOBcY9lrIrwMuwWve2.LayerOrder = 0;
				break;
			case NPCLocation.Middle:
				_3IHp43rpkJgOBcY9lrIrwMuwWve2.LayerOrder = 1;
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
