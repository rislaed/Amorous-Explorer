using System;
using Amorous.Game.Commands;
using Amorous.Game.Data.Cutscenes;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;

public class CommandEvent : AbstractEvent<CommandEventData>
{ // _ReclSEGHYgrEBUgjU95b2v5sTCe
	private CommandEventData _eventData;
	private Func<bool> _next;
	private Action _update;

	public CommandEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(CommandEventData eventData)
	{
		base.SetData(eventData);
		_eventData = eventData;
	}

	public override void Start()
	{
		base.Start();
		if (!(_eventData.Command == typeof(Commands.CookingSelectIngredient).Name))
		{
			if (_eventData.Command == typeof(Commands.CookingShowResult).Name)
			{
				if (!(base.Cutscene.Game.Scene is CookingMiniGameScene))
				{
					throw new Exception("Current scene is not CookingScene!");
				}
				CookingMiniGameScene cookingScene = base.Cutscene.Game.Scene as CookingMiniGameScene;
				cookingScene._NvWWx67tvkIBmEn9fgXJ9ZzWJMS();
				_next = null;
				_update = delegate
				{
					base.Completable = cookingScene._T81AMuUIGw7sZkYmJkIpiDPosrD;
				};
			}
			else if (!(_eventData.Command == typeof(Commands.RemyShowNudes).Name))
			{
				if (_eventData.Command == typeof(Commands.RemyHideNudes).Name)
				{
					PhoneOverlay.Get().HideRemyNudes();
					base.Completable = true;
				}
				else if (_eventData.Command == typeof(Commands.PlayCutscene).Name)
				{
					base.Cutscene.Game.StartCutscene(_eventData.Parameters["Cutscene"]);
					base.Completable = true;
				}
				else
				{
					TypingDialogue.Type("A unknown command is triggered: " + _eventData.Command, "[Command]", Color.Green);
					_next = Skip;
					_update = Complete;
				}
			}
			else
			{
				int.TryParse(_eventData.Parameters["Nude"], out var result);
				PhoneOverlay.Get().UpdateRemyNudes(result);
				base.Completable = true;
			}
		}
		else
		{
			if (!(base.Cutscene.Game.Scene is CookingMiniGameScene))
			{
				throw new Exception("Current scene is not CookingScene!");
			}
			CookingMiniGameScene cookingScene = base.Cutscene.Game.Scene as CookingMiniGameScene;
			cookingScene._c9i4Rbj8ENw5b6aqNq271voBctc = true;
			cookingScene.Completable = false;
			_next = null;
			_update = delegate
			{
				base.Completable = cookingScene.Completable;
			};
		}
	}

	public override bool Next()
	{
		if (_next == null)
		{
			return false;
		}
		return _next();
	}

	private bool Skip()
	{
		return base.Next();
	}

	public override void Update(GameTime gameTime)
	{
		if (_update != null)
		{
			_update();
		}
	}

	private void Complete()
	{
		base.Completable = TypingDialogue.Completable;
	}
}
