using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerANPC : SpineNPC<ClubInsideDancerANPC.EHeads, ClubInsideDancerANPC.EPoses, ClubInsideDancerANPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy
	}

	public enum EPoses
	{
		None,
		Dancing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	private int _countDanceA, _countDanceB;
	private int _offset;

	public ClubInsideDancerANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic/Dancer A", 0.8f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("Dance_B");
		AddEmotion(EHeads.Happy, "Eye", "Head", "Jaw", "Pupil").WithBlinking("Blink");
		AddPose(EPoses.Dancing, "Arm left", "Character", "Forearm right", "Leg left", "Leg right", "Tail", "shoulder right").AddNudes("Cock");
		AddClothes(EPoses.Dancing, EClothes.Shirt, "Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Dancing, EClothes.Pants, "Pants crotch", "Pants left", "Pants right").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	public void SetDanceScheme(int danceA, int danceB)
	{
		_countDanceA = danceA;
		_countDanceB = danceB;
		base.Spine.SetMix("Dance_A", "Dance_B", 0.5f);
		base.Spine.SetMix("Dance_B", "Dance_A", 0.5f);
		_offset = _countDanceA;
		StartDanceA();
	}

	public void StartDanceA()
	{
		base.Spine.AddAnimation("Dance_A", looping: true, 0f, delegate
		{
			_offset--;
			if (_offset <= 0)
			{
				_offset = _countDanceB;
				StartDanceB();
			}
		});
	}

	public void StartDanceB()
	{
		base.Spine.AddAnimation("Dance_B", looping: true, 0f, delegate
		{
			_offset--;
			if (_offset <= 0)
			{
				_offset = _countDanceA;
				StartDanceA();
			}
		});
	}
}
