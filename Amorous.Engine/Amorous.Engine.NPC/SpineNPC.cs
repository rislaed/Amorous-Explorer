using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Amorous.Engine.NPC;

public abstract class SpineNPC<THead, TPose, TClothes> : _tfDAeR6npiqJMLRSXPO1DxGA0TgA where THead : struct, IConvertible where TPose : struct, IConvertible where TClothes : struct, IConvertible
{
	protected SpineNPC(IAmorous game, string string_0, float float_0 = 1f, bool bool_0 = true)
		: base(game, string_0, float_0, bool_0)
	{
	}

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
