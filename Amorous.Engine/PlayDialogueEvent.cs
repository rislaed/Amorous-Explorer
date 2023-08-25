using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class PlayDialogueEvent : AbstractEvent<PlayDialogueEventData>
{ // _xGEYVq41yf0ul2Cmx7FszeTIVuf
	private bool completed;

	public string Text { get; private set; }
	public string Title { get; private set; }
	public Color Color { get; private set; }

	public PlayDialogueEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(PlayDialogueEventData eventData)
	{
		base.SetData(eventData);
		Text = eventData.Text;
		Title = eventData.Title;
		Color = eventData.Color;
		completed = false;
	}

	public override void Start()
	{
		base.Start();
		TypingDialogue.Type(Text, Title, Color);
	}

	public override bool Next()
	{
		if (completed)
		{
			base.IsCompleted = true;
		}
		else
		{
			completed = true;
			TypingDialogue.SkipToNext();
		}
		return false;
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = TypingDialogue.IsCompleted;
	}
}
