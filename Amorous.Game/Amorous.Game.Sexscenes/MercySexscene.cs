using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class MercySexscene : CensoredSexscene
{
	private static readonly List<SpineEvent> _zAqFZFiaBbpl6Gf6nSX9UC3cSh6;

	public MercySexscene(ContentManager contentManager_0)
		: base(contentManager_0, "Assets/SexScenes/Mercy/Mercy Sex", "Assets/SexScenes/Mercy/Background", null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(contentManager_0), float_0: MercySexscene.smethod_14() ? 2.2f : 1f, bool_0: true, float_1: 3000f)
	{
		MercySexscene.smethod_16(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "animation", (Action<int>)null);
		if (MercySexscene.smethod_14())
		{
			MercySexscene.smethod_17(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 450f);
			MercySexscene.smethod_18(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 900f);
		}
		else
		{
			MercySexscene.smethod_17(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 960f);
			MercySexscene.smethod_18(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 1090f);
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		MercySexscene.smethod_19(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 0f);
		if (!MercySexscene.smethod_14())
		{
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy leg left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy arm left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy body", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy arm right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy horn left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy ear left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy fringe left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy eye", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy pupil", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy eyelid", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy head", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy eyelash", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy fringe right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy horn right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy ear right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy hairlock right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy boob left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy boob right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy stomach", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy cock", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy tail", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy leg right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy taint back", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy taint", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player body", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player body underbelly", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player taint", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin left markings short", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortShin) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin left markings long", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongShin) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock uncut", (MercySexscene.smethod_23(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh left markings inner thigh", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh left stripes", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock knot", (MercySexscene.smethod_23(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player balls", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player Underbelly", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin right markings short", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortShin) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin right markings long", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongShin) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh right markings inner thigh", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh right stripes", MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
			bool flag = MercySexscene.smethod_22((Enum)MercySexscene.smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianShin);
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player body", MercySexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player body underbelly", MercySexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player taint", MercySexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin left", MercySexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin left markings short", flag ? MercySexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) : MercySexscene.smethod_27(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin left markings long", flag ? MercySexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) : MercySexscene.smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			if (MercySexscene.smethod_23(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) != _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Cut)
			{
				MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock", MercySexscene.smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			}
			else
			{
				MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock", MercySexscene.smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
				MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock uncut", MercySexscene.smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			}
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh left", MercySexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh left markings inner thigh", MercySexscene.smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh left stripes", MercySexscene.smethod_33(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock knot", MercySexscene.smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player balls", MercySexscene.smethod_34(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player Underbelly", MercySexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin right", MercySexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin right markings short", flag ? MercySexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) : MercySexscene.smethod_27(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player shin right markings long", flag ? MercySexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) : MercySexscene.smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh right", MercySexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh right markings inner thigh", MercySexscene.smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			MercySexscene.smethod_25(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh right stripes", MercySexscene.smethod_33(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
			base._DUynKBx2CM4riE68wCCfknspxeg.Add("Cum");
		}
		else
		{
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy arm left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy body", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy arm right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy horn left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy ear left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy fringe left", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy eye", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy pupil", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy eyelid", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy head", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy eyelash", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy fringe right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy horn right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy ear right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy hairlock right", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy tail", 1f);
			MercySexscene.smethod_20(MercySexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Mercy leg right", 1f);
		}
	}

	static MercySexscene()
	{
		List<SpineEvent> list = new List<SpineEvent>();
		SpineEvent val = MercySexscene.smethod_35();
		val.AnimationName = "animation";
		val.EventName = "ThrustStart";
		SpineEvent obj = val;
		float[] array = new float[6];
		MercySexscene.smethod_36((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj.FrameTimes = array;
		list.Add(val);
		val = MercySexscene.smethod_35();
		val.AnimationName = "animation";
		val.EventName = "ThrustEnd";
		SpineEvent obj2 = val;
		float[] array2 = new float[6];
		MercySexscene.smethod_36((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj2.FrameTimes = array2;
		list.Add(val);
		val = MercySexscene.smethod_35();
		val.AnimationName = "animation";
		val.EventName = "Moan";
		SpineEvent obj3 = val;
		float[] array3 = new float[6];
		MercySexscene.smethod_36((Array)array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj3.FrameTimes = array3;
		list.Add(val);
		_zAqFZFiaBbpl6Gf6nSX9UC3cSh6 = list;
	}

	static bool smethod_14()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_15(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_16(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static void smethod_17(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_18(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
	}

	static void smethod_20(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
	}

	static bool smethod_22(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType smethod_23(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI;
	}

	static Color smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static void smethod_25(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, color_0);
	}

	static Color smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
	}

	static Color smethod_27(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._LcOPiDaC2j5vzxOEYhvW4vRoaRX;
	}

	static Color smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._meyNS02iTIxo212B6c5eoKns2wj;
	}

	static Color smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._cUtgkG5qDvgFmI8c29I9xsLVNON;
	}

	static Color smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._o6OnmHi5rZIQPHESokp9rTaO1ei;
	}

	static Color smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
	}

	static Color smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
	}

	static Color smethod_33(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
	}

	static Color smethod_34(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8qQ7XVlyRYW4icBFxPQCJqgueYD;
	}

	static SpineEvent smethod_35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SpineEvent();
	}

	static void smethod_36(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
