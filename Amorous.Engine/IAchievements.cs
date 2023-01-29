public interface IAchievements
{ // _691ooXdgg17CWFkMkjedKBBBfYw
	bool IsSteamSupported { get; }
	void TriggerCutsceneStageAchievement(string cutscene, int stage);
	void SetStage(string key, int stage);
	void SetFlag(string key, bool flag);
	void UnlockContact(PlayerData.EPhoneContacts contact);
	void TriggerAchievement(string key);
	void TriggerTutorialAchievement(string key);
	void OpenAchievements();
}
