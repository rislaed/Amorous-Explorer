using System;
using System.Linq;

namespace Amorous.Engine.NPC;

public abstract class SpineNPC<THead, TPose, TClothes> : AbstractSpineNPC where THead : struct, IConvertible where TPose : struct, IConvertible where TClothes : struct, IConvertible
{
	protected SpineNPC(IAmorous game, string path, float scale = 1f, bool premultipliedAlpha = true)
		: base(game, path, scale, premultipliedAlpha) {}

	public _xmfdPa5IagU3cXbLL61gyoXAV7gA GetEmotion(THead emotion, params string[] self)
	{
		return GetEmotion(Enum.GetName(typeof(THead), (object)emotion), self);
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE GetPose(TPose pose, params string[] self)
	{
		return GetPose(Enum.GetName(typeof(TPose), (object)pose), self);
	}

	public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh GetClothes(TPose pose, TClothes clothes, params string[] self)
	{
		return GetClothes(Enum.GetName(typeof(TPose), (object)pose), Enum.GetName(typeof(TClothes), (object)clothes), self);
	}

	public void SetEmotion(THead emotion)
	{
		SetEmotion(Enum.GetName(typeof(THead), (object)emotion));
	}

	public void SetPose(TPose pose)
	{
		SetPose(Enum.GetName(typeof(TPose), (object)pose));
	}

	public void SetClothes(params TClothes[] clothes)
	{
		SetClothes(clothes.Select((TClothes cloth) => Enum.GetName(typeof(TClothes), (object)cloth)).ToArray());
	}
}
