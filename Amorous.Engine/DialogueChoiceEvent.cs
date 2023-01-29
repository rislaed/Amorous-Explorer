using System.Linq;
using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class DialogueChoiceEvent : AbstractEvent<DialogueChoiceEventData>
{ // _HNKZHPtLme6iaFiaVC67QqNpYAi
	public DialogueChoiceItem[] Choices { get; private set; }

	public DialogueChoiceEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(DialogueChoiceEventData eventData)
	{
		base.SetData(eventData);
		Choices = eventData.Choices.ToArray();
	}

	public override void Start()
	{
		base.Start();
		TypingDialogue.Choice(Choices.Select((DialogueChoiceItem choice) => choice.Text).ToArray());
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = !TypingDialogue.Outgoing;
		if (base.Completable)
		{
			int num = TypingDialogue.Which - 1;
			if (num >= 0 && num < Choices.Length)
			{
				base.NextID = Choices[num].NextID;
			}
		}
	}
}
