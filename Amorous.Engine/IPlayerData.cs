using Microsoft.Xna.Framework;

public interface IPlayerData
{
	string Name { get; set; }

	PlayerData.EBodyType BodyType { get; set; }

	Color BodyColor { get; set; }

	bool ShowNails { get; set; }

	Color NailColor { get; set; }

	PlayerData.EHeadType HeadType { get; set; }

	Color HeadColor { get; set; }

	Color PaperBagColor { get; set; }

	Color PaperBagEyesColor { get; set; }

	PlayerData.EHeadMarkingsType HeadMarkingsType { get; set; }

	Color HeadGauntColor { get; set; }

	Color HeadScruffyColor { get; set; }

	Color HeadSnoutColor { get; set; }

	Color HeadStripesColor { get; set; }

	PlayerData.EHeadAccessoriesType HeadAccessoriesType { get; set; }

	Color HeadHornsColor { get; set; }

	Color EarColor { get; set; }

	Color EarInnerColor { get; set; }

	PlayerData.EEyesType EyesType { get; set; }

	Color EyesBackColor { get; set; }

	Color EyesFrontColor { get; set; }

	PlayerData.EBrowType BrowType { get; set; }

	Color BrowColor { get; set; }

	PlayerData.EMuzzleType MuzzleType { get; set; }

	Color MuzzleColor { get; set; }

	Color NoseColor { get; set; }

	Color TeethColor { get; set; }

	bool ShowMuzzleHorn { get; set; }

	Color MuzzleHornColor { get; set; }

	bool ShowMuzzleMask { get; set; }

	Color MuzzleMaskColor { get; set; }

	PlayerData.EHairstyleType HairstyleType { get; set; }

	Color HairColor { get; set; }

	PlayerData.EFringeType FringeType { get; set; }

	Color FringeColor { get; set; }

	PlayerData.EFeetType FeetType { get; set; }

	Color FeetColor { get; set; }

	PlayerData.ETailType TailType { get; set; }

	Color TailColor { get; set; }

	bool ShowTailPartOne { get; set; }

	Color TailPartOneColor { get; set; }

	bool ShowTailPartTwo { get; set; }

	Color TailPartTwoColor { get; set; }

	PlayerData.EMarkingsType MarkingsType { get; set; }

	Color UnderbellyColor { get; set; }

	Color UnderthighColor { get; set; }

	Color StripesColor { get; set; }

	Color LongForearmColor { get; set; }

	Color ShortForearmColor { get; set; }

	Color AvianForearmColor { get; set; }

	Color LongShinColor { get; set; }

	Color ShortShinColor { get; set; }

	Color AvianShinColor { get; set; }

	PlayerData.ECockType CockType { get; set; }

	Color GenitaliaColor { get; set; }

	Color GenitaliaFleshColor { get; set; }

	PlayerData.EBallsType BallsType { get; set; }

	Color BallsColor { get; set; }

	PlayerData.EBreastsType BreastsType { get; set; }

	Color BreastsColor { get; set; }

	bool ShowNipples { get; set; }

	Color NipplesColor { get; set; }

	Color PhoneColor { get; set; }

	bool GetBit(string string_0);
}
