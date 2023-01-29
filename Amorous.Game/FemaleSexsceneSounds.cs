using Microsoft.Xna.Framework.Content;

public class FemaleSexsceneSounds : NeutralSexsceneSounds
{ // _sg4TvSTYoH0YwumBfYnvr7IeDaT
	private static FemaleSexsceneSounds _singleton;

	public FemaleSexsceneSounds(ContentManager content)
		: base(content)
	{
		MoaningSlow.Append("Assets/Sounds/SexScenes/Moaning/Female/Slow/krokbreath1_1", "Assets/Sounds/SexScenes/Moaning/Female/Slow/krokbreath2_1", "Assets/Sounds/SexScenes/Moaning/Female/Slow/krokbreath3_1", "Assets/Sounds/SexScenes/Moaning/Female/Slow/krokslow1_1", "Assets/Sounds/SexScenes/Moaning/Female/Slow/krokslow2_1", "Assets/Sounds/SexScenes/Moaning/Female/Slow/krokslow3_1", "Assets/Sounds/SexScenes/Moaning/Female/Slow/krokslow4_1", "Assets/Sounds/SexScenes/Moaning/Female/Slow/krokslow5_1");
		MoaningMedium.Append("Assets/Sounds/SexScenes/Moaning/Female/Medium/krokmed1_1", "Assets/Sounds/SexScenes/Moaning/Female/Medium/krokmed2_1", "Assets/Sounds/SexScenes/Moaning/Female/Medium/krokmed3_1", "Assets/Sounds/SexScenes/Moaning/Female/Medium/krokmed4_1", "Assets/Sounds/SexScenes/Moaning/Female/Medium/krokmed5_1");
		MoaningFast.Append("Assets/Sounds/SexScenes/Moaning/Female/Fast/krokfast1_1", "Assets/Sounds/SexScenes/Moaning/Female/Fast/krokfast2_1", "Assets/Sounds/SexScenes/Moaning/Female/Fast/krokfast3_1", "Assets/Sounds/SexScenes/Moaning/Female/Fast/krokfast4_1", "Assets/Sounds/SexScenes/Moaning/Female/Fast/krokfast5_1");
		MoaningRapid.Append("Assets/Sounds/SexScenes/Moaning/Female/Rapid/krokcum1_1", "Assets/Sounds/SexScenes/Moaning/Female/Rapid/krokcum2_1", "Assets/Sounds/SexScenes/Moaning/Female/Rapid/krokcum3_1", "Assets/Sounds/SexScenes/Moaning/Female/Rapid/krokcum4_1", "Assets/Sounds/SexScenes/Moaning/Female/Rapid/krokcum5_1");
	}

	public static FemaleSexsceneSounds Get(ContentManager content)
	{
		return _singleton ?? (_singleton = new FemaleSexsceneSounds(content));
	}
}
