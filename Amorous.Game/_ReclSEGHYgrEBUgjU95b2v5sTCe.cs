using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Amorous.Game.Commands;
using Amorous.Game.Data.Cutscenes;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;

public class _ReclSEGHYgrEBUgjU95b2v5sTCe : AbstractEvent<CommandEventData>
{
	private CommandEventData _Eq0ZSbjV3AWfNe2m5mpykEVrjtD;

	private Func<bool> _7TpbhhncTYU8N40kUaAahODEjQT;

	private Action _YY04FeZbOVc47HHNN5R0M1nZYpc;

	public _ReclSEGHYgrEBUgjU95b2v5sTCe(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(CommandEventData commandEventData_0)
	{
		base.SetData(commandEventData_0);
		_Eq0ZSbjV3AWfNe2m5mpykEVrjtD = commandEventData_0;
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
		if (!(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.CookingSelectIngredient).Name))
		{
			if (_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.CookingShowResult).Name)
			{
				if (!(base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.Scene is CookingMiniGameScene))
				{
					throw new Exception("Current scene is not CookingScene!");
				}
				CookingMiniGameScene _RJTGWz7KqClGKVJa614391g5XSF = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.Scene as CookingMiniGameScene;
				_RJTGWz7KqClGKVJa614391g5XSF._NvWWx67tvkIBmEn9fgXJ9ZzWJMS();
				_7TpbhhncTYU8N40kUaAahODEjQT = null;
				_YY04FeZbOVc47HHNN5R0M1nZYpc = delegate
				{
					base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _RJTGWz7KqClGKVJa614391g5XSF._T81AMuUIGw7sZkYmJkIpiDPosrD;
				};
			}
			else if (!(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.RemyShowNudes).Name))
			{
				if (_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.RemyHideNudes).Name)
				{
					_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._zFlBtKgcAb6cv77WHC6dI3lO8EwA();
					base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
				}
				else if (_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.PlayCutscene).Name)
				{
					base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.RequestScene(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Parameters["Cutscene"]);
					base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
				}
				else
				{
					_nkzqFdEfDyLcyGikIKGcHjklI4y._zunSyHn4DekdA6CngP10dXcR1kq("A unknown command is triggered: " + _Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command, "[Command]", Color.Green);
					_7TpbhhncTYU8N40kUaAahODEjQT = _NjQNLofcM2wbpSVJX5f9ltGMCNg;
					_YY04FeZbOVc47HHNN5R0M1nZYpc = _T09IZIRhbGpjZWBAffDLYRnGVST;
				}
			}
			else
			{
				int.TryParse(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Parameters["Nude"], out var result);
				_poenyHBGUusBcnNcTFB9MQBV72R._AZrO8MxMUE7cKsFYTQ4k9O3q7yC()._f2CdPIvAGYavrZlA3VXyxB0B8Jh(result);
				base._xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
			}
		}
		else
		{
			if (!(base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.Scene is CookingMiniGameScene))
			{
				throw new Exception("Current scene is not CookingScene!");
			}
			CookingMiniGameScene _RJTGWz7KqClGKVJa614391g5XSF2 = base._5zNdOw7qHmuCAPJFMr3SsZdBlCr.Game.Scene as CookingMiniGameScene;
			_RJTGWz7KqClGKVJa614391g5XSF2._c9i4Rbj8ENw5b6aqNq271voBctc = true;
			_RJTGWz7KqClGKVJa614391g5XSF2._xJZUPxDatEzfPQc0nRHR2D1Vwke = false;
			_7TpbhhncTYU8N40kUaAahODEjQT = null;
			_YY04FeZbOVc47HHNN5R0M1nZYpc = delegate
			{
				base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _RJTGWz7KqClGKVJa614391g5XSF2._xJZUPxDatEzfPQc0nRHR2D1Vwke;
			};
		}
	}

	public override bool _NeIQsy78kWqF9jXLl8vb2lOyZgO()
	{
		if (_7TpbhhncTYU8N40kUaAahODEjQT == null)
		{
			return false;
		}
		return _7TpbhhncTYU8N40kUaAahODEjQT();
	}

	private bool _NjQNLofcM2wbpSVJX5f9ltGMCNg()
	{
		return base._NeIQsy78kWqF9jXLl8vb2lOyZgO();
	}

	public override void Update(GameTime gameTime)
	{
		if (_YY04FeZbOVc47HHNN5R0M1nZYpc != null)
		{
			_YY04FeZbOVc47HHNN5R0M1nZYpc();
		}
	}

	private void _T09IZIRhbGpjZWBAffDLYRnGVST()
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = _nkzqFdEfDyLcyGikIKGcHjklI4y._xJZUPxDatEzfPQc0nRHR2D1Vwke;
	}
}
