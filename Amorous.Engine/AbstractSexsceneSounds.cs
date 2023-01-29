using Microsoft.Xna.Framework.Content;

public abstract class AbstractSexsceneSounds
{ // _sa8EsNgk4VDRaASdXE7VprdlNlg
	public RandomSoundEffect Squishing;
	public RandomSoundEffect MoaningSlow;
	public RandomSoundEffect MoaningMedium;
	public RandomSoundEffect MoaningFast;
	public RandomSoundEffect MoaningRapid;
	public RandomSoundEffect SlappingMedium;
	public RandomSoundEffect SlappingFast;

	protected AbstractSexsceneSounds(ContentManager content)
	{
		Squishing = new RandomSoundEffect(content);
		MoaningSlow = new RandomSoundEffect(content);
		MoaningMedium = new RandomSoundEffect(content);
		MoaningFast = new RandomSoundEffect(content);
		MoaningRapid = new RandomSoundEffect(content);
		SlappingMedium = new RandomSoundEffect(content);
		SlappingFast = new RandomSoundEffect(content);
	}
}
