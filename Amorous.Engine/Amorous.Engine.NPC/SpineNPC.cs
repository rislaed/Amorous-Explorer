using System;
using System.Linq;

namespace Amorous.Engine.NPC;

public abstract class SpineNPC<THead, TPose, TClothes> : AbstractSpineNPC where THead : struct, IConvertible where TPose : struct, IConvertible where TClothes : struct, IConvertible
{
	protected SpineNPC(IAmorous game, string path, float scale = 1f, bool premultipliedAlpha = true) : base(game, path, scale, premultipliedAlpha) {}

	public FilterableEmotion AddEmotion(THead emotion, params string[] parts)
	{
		return AddEmotion(Enum.GetName(typeof(THead), (object)emotion), parts);
	}

	public FilterablePose AddPose(TPose pose, params string[] parts)
	{
		return AddPose(Enum.GetName(typeof(TPose), (object)pose), parts);
	}

	public FilterableClothes AddClothes(TPose pose, TClothes clothes, params string[] parts)
	{
		return AddClothes(Enum.GetName(typeof(TPose), (object)pose), Enum.GetName(typeof(TClothes), (object)clothes), parts);
	}

	public void SetEmotion(THead emotion)
	{
		SetEmotion(Enum.GetName(typeof(THead), (object)emotion));
	}

	public void SetPose(TPose pose)
	{
		SetPose(Enum.GetName(typeof(TPose), (object)pose));
	}

	public void SetClothes(params TClothes[] clothes)
	{
		SetClothes(clothes.Select((TClothes cloth) => Enum.GetName(typeof(TClothes), (object)cloth)).ToArray());
	}
}
