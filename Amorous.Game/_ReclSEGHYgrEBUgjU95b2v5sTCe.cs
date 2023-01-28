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

	public _ReclSEGHYgrEBUgjU95b2v5sTCe(Cutscene _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(CommandEventData commandEventData_0)
	{
		base.SetData(commandEventData_0);
		_Eq0ZSbjV3AWfNe2m5mpykEVrjtD = commandEventData_0;
	}

	public override void Begin()
	{
		base.Begin();
		if (!(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.CookingSelectIngredient).Name))
		{
			if (_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.CookingShowResult).Name)
			{
				if (!(base.Cutscene.Game.Scene is CookingMiniGameScene))
				{
					throw new Exception("Current scene is not CookingScene!");
				}
				CookingMiniGameScene _RJTGWz7KqClGKVJa614391g5XSF = base.Cutscene.Game.Scene as CookingMiniGameScene;
				_RJTGWz7KqClGKVJa614391g5XSF._NvWWx67tvkIBmEn9fgXJ9ZzWJMS();
				_7TpbhhncTYU8N40kUaAahODEjQT = null;
				_YY04FeZbOVc47HHNN5R0M1nZYpc = delegate
				{
					base.Completable = _RJTGWz7KqClGKVJa614391g5XSF._T81AMuUIGw7sZkYmJkIpiDPosrD;
				};
			}
			else if (!(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.RemyShowNudes).Name))
			{
				if (_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.RemyHideNudes).Name)
				{
					PhoneOverlay.Get()._zFlBtKgcAb6cv77WHC6dI3lO8EwA();
					base.Completable = true;
				}
				else if (_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command == typeof(Commands.PlayCutscene).Name)
				{
					base.Cutscene.Game.StartCutscene(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Parameters["Cutscene"]);
					base.Completable = true;
				}
				else
				{
					TypingDialogue._zunSyHn4DekdA6CngP10dXcR1kq("A unknown command is triggered: " + _Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Command, "[Command]", Color.Green);
					_7TpbhhncTYU8N40kUaAahODEjQT = _NjQNLofcM2wbpSVJX5f9ltGMCNg;
					_YY04FeZbOVc47HHNN5R0M1nZYpc = _T09IZIRhbGpjZWBAffDLYRnGVST;
				}
			}
			else
			{
				int.TryParse(_Eq0ZSbjV3AWfNe2m5mpykEVrjtD.Parameters["Nude"], out var result);
				PhoneOverlay.Get()._f2CdPIvAGYavrZlA3VXyxB0B8Jh(result);
				base.Completable = true;
			}
		}
		else
		{
			if (!(base.Cutscene.Game.Scene is CookingMiniGameScene))
			{
				throw new Exception("Current scene is not CookingScene!");
			}
			CookingMiniGameScene _RJTGWz7KqClGKVJa614391g5XSF2 = base.Cutscene.Game.Scene as CookingMiniGameScene;
			_RJTGWz7KqClGKVJa614391g5XSF2._c9i4Rbj8ENw5b6aqNq271voBctc = true;
			_RJTGWz7KqClGKVJa614391g5XSF2.Completable = false;
			_7TpbhhncTYU8N40kUaAahODEjQT = null;
			_YY04FeZbOVc47HHNN5R0M1nZYpc = delegate
			{
				base.Completable = _RJTGWz7KqClGKVJa614391g5XSF2.Completable;
			};
		}
	}

	public override bool Next()
	{
		if (_7TpbhhncTYU8N40kUaAahODEjQT == null)
		{
			return false;
		}
		return _7TpbhhncTYU8N40kUaAahODEjQT();
	}

	private bool _NjQNLofcM2wbpSVJX5f9ltGMCNg()
	{
		return base.Next();
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
		base.Completable = TypingDialogue.Completable;
	}
}
