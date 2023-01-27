using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class _HNKZHPtLme6iaFiaVC67QqNpYAi : AbstractEvent<DialogueChoiceEventData>
{
	public DialogueChoiceItem[] Choices { get; private set; }

	public _HNKZHPtLme6iaFiaVC67QqNpYAi(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0)
		: base(_nR8eroJOHehP0ZGyyTveo6aMTHg_0)
	{
	}

	public override void SetData(DialogueChoiceEventData dialogueChoiceEventData_0)
	{
		base.SetData(dialogueChoiceEventData_0);
		Choices = dialogueChoiceEventData_0.Choices.ToArray();
	}

	public override void StopCutscene()
	{
		base.StopCutscene();
		_nkzqFdEfDyLcyGikIKGcHjklI4y.DiplayOptions(Choices.Select((DialogueChoiceItem dialogueChoiceItem_0) => dialogueChoiceItem_0.Text).ToArray());
	}

	public override void Update(GameTime gameTime)
	{
		base._xJZUPxDatEzfPQc0nRHR2D1Vwke = !_nkzqFdEfDyLcyGikIKGcHjklI4y._zatbtX2c8i2hGOTptNymBxA8kVI;
		if (base._xJZUPxDatEzfPQc0nRHR2D1Vwke)
		{
			int num = _nkzqFdEfDyLcyGikIKGcHjklI4y._rVWIUtPzqmWcZbPclkfMRcIkeGR - 1;
			if (num >= 0 && num < Choices.Length)
			{
				base.NextID = Choices[num].NextID;
			}
		}
	}
}
