using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _3IHp43rpkJgOBcY9lrIrwMuwWve : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public const string _tyk6ubAYksgThinoaE8CE4cUqSC = "NPCLayer_";

	public _QGGOTxZ8aNWGh0hc26wcmx8wmwT _4QLHHCk23T1BjK7acKxASbkCefG;

	public _a2qVgWDIm3fBp49WubttSTPsx8K _dPmC8tBC0iph2YBAFmztEsmwUdSA;

	private _nR8eroJOHehP0ZGyyTveo6aMTHg _sVephzY32oTa3X109UReGPT9rd;

	private Action _U1ntvSBQ11Vut0Wd1Vmb115ghn;

	public Action _64JjsghBPDjZ1OxZwhO8Y6dFE5t
	{
		set
		{
			_U1ntvSBQ11Vut0Wd1Vmb115ghn = value;
			_U1ntvSBQ11Vut0Wd1Vmb115ghn?.Invoke();
		}
	}

	public _3IHp43rpkJgOBcY9lrIrwMuwWve(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, _QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, _a2qVgWDIm3fBp49WubttSTPsx8K _a2qVgWDIm3fBp49WubttSTPsx8K_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, _3IHp43rpkJgOBcY9lrIrwMuwWve.smethod_2("NPCLayer_", _3IHp43rpkJgOBcY9lrIrwMuwWve.smethod_1((MemberInfo)_3IHp43rpkJgOBcY9lrIrwMuwWve.smethod_0((object)_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0))))
	{
		_4QLHHCk23T1BjK7acKxASbkCefG = _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0;
		_dPmC8tBC0iph2YBAFmztEsmwUdSA = _a2qVgWDIm3fBp49WubttSTPsx8K_0;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_U1ntvSBQ11Vut0Wd1Vmb115ghn != null)
		{
			if (_sVephzY32oTa3X109UReGPT9rd != null && base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr == null)
			{
				_U1ntvSBQ11Vut0Wd1Vmb115ghn();
			}
			_sVephzY32oTa3X109UReGPT9rd = base._XbOXR6AypLIdJ3gBMGseGi3Wi2i._ZzBuoSDMWwerejOO9Goyv2OCKgE._5zNdOw7qHmuCAPJFMr3SsZdBlCr;
		}
		_4QLHHCk23T1BjK7acKxASbkCefG._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
	}

	static Type smethod_0(object object_0)
	{
		return object_0.GetType();
	}

	static string smethod_1(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}
}
