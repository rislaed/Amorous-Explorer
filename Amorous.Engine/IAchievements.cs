public interface IAchievements
{ // _691ooXdgg17CWFkMkjedKBBBfYw
	bool IsSteamSupported { get; }
	void GainCutsceneStageAchievement(string string_0, int int_0);
	void SetStage(string key, int value);
	void SetFlag(string key, bool value);
	void UnlockContact(PlayerData.EPhoneContacts contact);
	void GainAchievement(string key);
	void GainTutorial(string string_0);
	void OpenAchievements();
}
