public interface IAchievements
{
	bool IsSteamSupported { get; }
	void GainCutsceneStageAchievement(string string_0, int int_0);
	void SetDecimal(string key, int value);
	void SetBit(string key, bool value);
	void GainContact(PlayerData.EPhoneContacts contact);
	void GainAchievement(string key);
	void GainTutorial(string string_0);
	void OpenAchievements();
}
