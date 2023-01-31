using Microsoft.Xna.Framework.Content;

public class MaleSexsceneSounds : NeutralSexsceneSounds
{ // _ecVLwNBaQAiybVyX9cgWCvnbkWe
	public MaleSexsceneSounds(ContentManager content)
		: base(content)
	{
		MoaningSlow.Append("Assets/Sounds/SexScenes/Moaning/Male/Slow/Dragonslow1", "Assets/Sounds/SexScenes/Moaning/Male/Slow/Dragonslow2", "Assets/Sounds/SexScenes/Moaning/Male/Slow/Dragonslow3", "Assets/Sounds/SexScenes/Moaning/Male/Slow/Dragonslow4", "Assets/Sounds/SexScenes/Moaning/Male/Slow/Dragonslow5");
		MoaningMedium.Append("Assets/Sounds/SexScenes/Moaning/Male/Medium/Dragonmed1", "Assets/Sounds/SexScenes/Moaning/Male/Medium/Dragonmed2", "Assets/Sounds/SexScenes/Moaning/Male/Medium/Dragonmed3", "Assets/Sounds/SexScenes/Moaning/Male/Medium/Dragonmed4", "Assets/Sounds/SexScenes/Moaning/Male/Medium/Dragonmed5");
		MoaningFast.Append("Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast1", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast2", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast3", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast4", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast5", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast6", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast7", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast8", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast9", "Assets/Sounds/SexScenes/Moaning/Male/Fast/Dragonfast10");
		MoaningRapid.Append("Assets/Sounds/SexScenes/Moaning/Male/Rapid/Dragonrapid1", "Assets/Sounds/SexScenes/Moaning/Male/Rapid/Dragonrapid2", "Assets/Sounds/SexScenes/Moaning/Male/Rapid/Dragonrapid3", "Assets/Sounds/SexScenes/Moaning/Male/Rapid/Dragonrapid4", "Assets/Sounds/SexScenes/Moaning/Male/Rapid/Dragonrapid5");
	}

	public static MaleSexsceneSounds Get(ContentManager content)
	{
		return new MaleSexsceneSounds(content);
	}
}
