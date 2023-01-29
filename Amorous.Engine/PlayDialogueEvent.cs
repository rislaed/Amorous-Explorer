using Amorous.Engine.Data.Cutscenes;
using Microsoft.Xna.Framework;

public class PlayDialogueEvent : AbstractEvent<PlayDialogueEventData>
{ // _xGEYVq41yf0ul2Cmx7FszeTIVuf
	private bool _completable;

	public string Text { get; private set; }
	public string Title { get; private set; }
	public Color Color { get; private set; }

	public PlayDialogueEvent(Cutscene cutscene)
		: base(cutscene) {}

	public override void SetData(PlayDialogueEventData eventData)
	{
		base.SetData(eventData);
		Text = eventData.Text;
		Title = eventData.Title;
		Color = eventData.Color;
		_completable = false;
	}

	public override void Start()
	{
		base.Start();
		TypingDialogue.Type(Text, Title, Color);
	}

	public override bool Next()
	{
		if (_completable)
		{
			base.Completable = true;
		}
		else
		{
			_completable = true;
			TypingDialogue.SkipToNext();
		}
		return false;
	}

	public override void Update(GameTime gameTime)
	{
		base.Completable = TypingDialogue.Completable;
	}
}
