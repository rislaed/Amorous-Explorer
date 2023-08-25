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

	private int schemeDanceA, schemeDanceB;
	private int loops;

	public ClubInsideDancerANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic/Dancer A", 0.8f, premultipliedAlpha: true)
	{
		base.Skeleton.StartAnimationWithLooping("Dance_B");
		AddEmotion(EHeads.Happy, "Eye", "Head", "Jaw", "Pupil").WithBlinking("Blink");
		AddPose(EPoses.Dancing, "Arm left", "Character", "Forearm right", "Leg left", "Leg right", "Tail", "shoulder right").AddNudes("Cock");
		AddClothes(EPoses.Dancing, EClothes.Shirt, "Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Dancing, EClothes.Pants, "Pants crotch", "Pants left", "Pants right").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	public void SetDanceScheme(int danceA, int danceB)
	{
		schemeDanceA = danceA;
		schemeDanceB = danceB;
		base.Skeleton.SetMix("Dance_A", "Dance_B", 0.5f);
		base.Skeleton.SetMix("Dance_B", "Dance_A", 0.5f);
		loops = schemeDanceA;
		StartDanceA();
	}

	public void StartDanceA()
	{
		base.Skeleton.AddAnimation("Dance_A", loop: true, 0f, delegate
		{
			loops--;
			if (loops <= 0)
			{
				loops = schemeDanceB;
				StartDanceB();
			}
		});
	}

	public void StartDanceB()
	{
		base.Skeleton.AddAnimation("Dance_B", loop: true, 0f, delegate
		{
			loops--;
			if (loops <= 0)
			{
				loops = schemeDanceA;
				StartDanceA();
			}
		});
	}
}
