using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Amorous.Engine.NPC;

public abstract class LayerNPC<THead, TPose, TClothes> : _xZgbANe7gi6i2DAhBEkKpR1QFLe where THead : struct, IConvertible where TPose : struct, IConvertible where TClothes : struct, IConvertible
{
	protected LayerNPC(IAmorous game, string string_0, float float_0 = 1f)
		: base(game, string_0, float_0)
	{
	}

	public _xmfdPa5IagU3cXbLL61gyoXAV7gA GetEmotion(THead gparam_0, params string[] string_0)
	{
		return GetEmotion(Enum.GetName(typeof(THead), (object)gparam_0), string_0);
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE GetPose(TPose gparam_0, params string[] string_0)
	{
		return GetPose(Enum.GetName(typeof(TPose), (object)gparam_0), string_0);
	}

	public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh GetClothes(TPose gparam_0, TClothes gparam_1, params string[] string_0)
	{
		return GetClothes(Enum.GetName(typeof(TPose), (object)gparam_0), Enum.GetName(typeof(TClothes), (object)gparam_1), string_0);
	}

	public void SetEmotion(THead gparam_0)
	{
		SetEmotion(Enum.GetName(typeof(THead), (object)gparam_0));
	}

	public void SetPose(TPose gparam_0)
	{
		SetPose(Enum.GetName(typeof(TPose), (object)gparam_0));
	}

	public void SetClothes(params TClothes[] gparam_0)
	{
		SetClothes(gparam_0.Select((TClothes gparam_0) => Enum.GetName(typeof(TClothes), (object)gparam_0)).ToArray());
	}
}
