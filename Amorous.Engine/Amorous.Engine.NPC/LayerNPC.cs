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

	public _xmfdPa5IagU3cXbLL61gyoXAV7gA GetEmotion(THead value, params string[] string_0)
	{
		return GetEmotion(Enum.GetName(typeof(THead), (object)value), string_0);
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE GetPose(TPose value, params string[] string_0)
	{
		return GetPose(Enum.GetName(typeof(TPose), (object)value), string_0);
	}

	public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh GetClothes(TPose value, TClothes gparam_1, params string[] string_0)
	{
		return GetClothes(Enum.GetName(typeof(TPose), (object)value), Enum.GetName(typeof(TClothes), (object)gparam_1), string_0);
	}

	public void SetEmotion(THead value)
	{
		SetEmotion(Enum.GetName(typeof(THead), (object)value));
	}

	public void SetPose(TPose value)
	{
		SetPose(Enum.GetName(typeof(TPose), (object)value));
	}

	public void SetClothes(params TClothes[] value)
	{
		SetClothes(value.Select((TClothes cloth) => Enum.GetName(typeof(TClothes), (object)cloth)).ToArray());
	}
}
