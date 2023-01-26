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

	public _xmfdPa5IagU3cXbLL61gyoXAV7gA _aRXZ6kQYnlqRUMIC19x1vIPD62D(THead gparam_0, params string[] string_0)
	{
		return _aRXZ6kQYnlqRUMIC19x1vIPD62D(Enum.GetName(typeof(THead), (object)gparam_0), string_0);
	}

	public _NaKchYC4I4GjWR34SfBLAktysCE _zDmJ8ztQTMoRvRw2LsNKu5foPpF(TPose gparam_0, params string[] string_0)
	{
		return _zDmJ8ztQTMoRvRw2LsNKu5foPpF(Enum.GetName(typeof(TPose), (object)gparam_0), string_0);
	}

	public _EZ0kOLXoEoEfWGQDdTbNqaPzDUh _ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(TPose gparam_0, TClothes gparam_1, params string[] string_0)
	{
		return _ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(Enum.GetName(typeof(TPose), (object)gparam_0), Enum.GetName(typeof(TClothes), (object)gparam_1), string_0);
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
