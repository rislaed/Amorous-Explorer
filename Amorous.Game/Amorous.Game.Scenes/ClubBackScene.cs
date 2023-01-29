using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubBackScene : AbstractScene
{
	private ClubStaticLexNPC _lex;

	private readonly bool _showLex;

	public ClubBackScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubBack/Club back main", -535, 0);
		AddSpriteLayer("Background", "Assets/Scenes/ClubBack/Club back bodies", 1313, 486);
		if (!Censorship.Topless)
		{
			AddSpriteLayer("Background", "Assets/Scenes/ClubBack/Club back shirts", 1313, 486);
		}
		if (!Censorship.Bottomless)
		{
			AddSpriteLayer("Background", "Assets/Scenes/ClubBack/Club back pants", 1313, 486);
		}
		AddClickableLayer("Door", "Assets/Scenes/ClubBack/Door to lounge selectable", -217, 120, OnDoorClick);
		AddClickableLayer("Side", "Assets/Scenes/ClubBack/Front of Club Selectable", 608, 0, OnClubFrontClick);
		AddDeviationLayer("Fan", "Assets/Scenes/ClubBack/Fan", 524, 75, 10f, 68, 75);
		Game.Canvas.SetOverscroll(-535, 535, 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		_showLex = !data.GetFlag(AmorousData.LexLeftClub);
	}

	public override void Start()
	{
		if (_showLex)
		{
			_lex = base.Game.GetNPCLayerAt<ClubStaticLexNPC>(LayerOrder.Foreground);
			_lex.X = -535f;
			_lex.Y = 250f;
			_lex.Click = OnLexClick;
		}
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubLoungeScene>();
	}

	private void OnClubFrontClick()
	{
		base.Game.StartScene<ClubEntranceScene>();
	}

	private void OnLexClick()
	{
		base.Game.StartCutscene(AmorousData.LexPreDate);
	}
}
