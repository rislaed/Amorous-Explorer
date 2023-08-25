using System;
using Amorous.Game.Commands;
using Amorous.Game.Data.Cutscenes;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;

public class CommandEvent : AbstractEvent<CommandEventData>
{ // _ReclSEGHYgrEBUgjU95b2v5sTCe
	private CommandEventData eventData;
	private Func<bool> next;
	private Action update;

	public CommandEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(CommandEventData eventData)
	{
		base.SetData(eventData);
		this.eventData = eventData;
	}

	public override void Start()
	{
		base.Start();
		if (!(eventData.Command == typeof(Commands.CookingSelectIngredient).Name))
		{
			if (eventData.Command == typeof(Commands.CookingShowResult).Name)
			{
				if (!(base.Cutscene.Game.Scene is CookingMiniGameScene))
				{
					throw new Exception("Current scene is not CookingScene!");
				}
				CookingMiniGameScene cookingScene = base.Cutscene.Game.Scene as CookingMiniGameScene;
				cookingScene.ShowResult();
				next = null;
				update = delegate
				{
					base.IsCompleted = cookingScene.IsShowingResultCompleted;
				};
			}
			else if (!(eventData.Command == typeof(Commands.RemyShowNudes).Name))
			{
				if (eventData.Command == typeof(Commands.RemyHideNudes).Name)
				{
					PhoneOverlay.GetSingleton().HideRemyNudes();
					base.IsCompleted = true;
				}
				else if (eventData.Command == typeof(Commands.PlayCutscene).Name)
				{
					base.Cutscene.Game.PlayCutscene(eventData.Parameters["Cutscene"]);
					base.IsCompleted = true;
				}
				else
				{
					TypingDialogue.Type("A unknown command is triggered: " + eventData.Command, "[Command]", Color.Green);
					next = Skip;
					update = Complete;
				}
			}
			else
			{
				int.TryParse(eventData.Parameters["Nude"], out var result);
				PhoneOverlay.GetSingleton().UpdateRemyNudes(result);
				base.IsCompleted = true;
			}
		}
		else
		{
			if (!(base.Cutscene.Game.Scene is CookingMiniGameScene))
			{
				throw new Exception("Current scene is not CookingScene!");
			}
			CookingMiniGameScene cookingScene = base.Cutscene.Game.Scene as CookingMiniGameScene;
			cookingScene.IsSelectingIngredient = true;
			cookingScene.IsSelectingIngredientCompleted = false;
			next = null;
			update = delegate
			{
				base.IsCompleted = cookingScene.IsSelectingIngredientCompleted;
			};
		}
	}

	public override bool Next()
	{
		if (next == null)
		{
			return false;
		}
		return next();
	}

	private bool Skip()
	{
		return base.Next();
	}

	public override void Update(GameTime gameTime)
	{
		if (update != null)
		{
			update();
		}
	}

	private void Complete()
	{
		base.IsCompleted = TypingDialogue.IsCompleted;
	}
}
