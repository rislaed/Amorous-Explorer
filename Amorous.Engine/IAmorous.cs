using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public interface IAmorous
{
	GameWindow _8k7Do3TGW5NrB22zl8QzInP2j7k { get; }

	GraphicsDevice _2yepMkVENnecIsduggABaU2qhXW { get; }

	ContentManager Content { get; }

	_3FFZvGWTAe7rsviKkDPTXEVjxWf _RbWJ7YGnYHCSoD44MRW1h5X6E7E { get; }

	_wRd4nHuQQlAPEwrHOGkBfut6Uip _vsceSzSIjBy2nZrCxAzKZbUiwLq { get; }

	AbstractScene Scene { get; }

	AbstractSexscene Sexscene { get; }

	_nR8eroJOHehP0ZGyyTveo6aMTHg _5zNdOw7qHmuCAPJFMr3SsZdBlCr { get; }

	_gJR4g7ak0hsZAUWX1vJbMqG2P5I _Qj2G6fpAF4mGsATgkV8DPBF3aA1A { get; }

	_8lVOgkauaSHbAkAqHzI1K7mIyOI _o2QVQfIAsuLcmPxn14llGoZA52y { get; }

	IAchievements _aJh9CibG5YKhkExxgRyVopdfSeJ { get; }

	bool _kSReo0whY1pgfTnFOSc44ppANOe { get; }

	bool _NdzU0m9x8QDKpVv3DrQmzY5KduB { get; }

	bool _LWcoDwIWvf8DT3nQmNe5z8fkUvI { get; set; }

	bool _ezjxb7tsh6Db1xblB74OYX4vVK { get; }

	void Initialize();

	void LoadContent();

	void UnloadContent();

	void Update(GameTime gameTime);

	void Draw(GameTime gameTime);

	void _qGU55VUfbqFJ4l6ArNW4JRcLekg();

	void _VN2LxjGLZldLNfiJ1OniiaXfYBg();

	bool _fDSidqggP063WGf2vzkdlA1UDkn(string string_0);

	void _fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int int_0, int int_1);

	void _fSRUnXzLhUs3DfJ1lzl9dGCEmCf(int int_0, int int_1, bool bool_0);

	void _udfEpcIRn7lWl5Lvjdyu0aG0A7G();

	void StartScene<T>() where T : AbstractScene;

	void StartScene(string string_0);

	void StartScene(AbstractScene scene);

	void _OxLRmpxixplTKChiTPUKAx4uTLG<T>(Action action_0 = null) where T : AbstractScene;

	void _OxLRmpxixplTKChiTPUKAx4uTLG(string string_0, Action action_0 = null);

	void _OxLRmpxixplTKChiTPUKAx4uTLG(AbstractScene scene, Action action_0 = null);

	void _gYGB98heFqsLp9tgJbdCP01IKV2(string string_0);

	void _Ec0fhBrUGmjaIKjUfJioigVc65x();

	void RequestScene(string string_0);

	void RequestScene(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0);

	void Start();

	void _lXEQJcXKxsjtZp00Y9aPe0ymGue<T>() where T : _8lVOgkauaSHbAkAqHzI1K7mIyOI;

	void _lXEQJcXKxsjtZp00Y9aPe0ymGue<T>(T gparam_0) where T : _8lVOgkauaSHbAkAqHzI1K7mIyOI;

	void _gYufry4VnA6Ur59PtBsOHrUA8SD();

	AbstractNPC GetNPCLayer(string string_0);

	AbstractNPC GetNPCLayer(NPCLocation npclocation_0);

	AbstractNPC _TwQHHdbdRFRy2ctTZabNfz1Htrg(string string_0, LayerOrder LayerOrder_0);

	T _TwQHHdbdRFRy2ctTZabNfz1Htrg<T>(LayerOrder LayerOrder_0) where T : AbstractNPC;

	void _yh2DwZs16cvRtvGayeYZrMWlrbj(int int_0);

	void _CYyzfcX8IclN1GnWsApBFWBpush(int int_0);

	bool _Ut0dhlh4JTZBMNJPNxxI9f9VqTp(int int_0);

	bool _1yDW5GeZ2MCcssz8ohrF9CK913i(int int_0);

	void _EXfoFnp1OKxeZbd4GcVZMCO2urH(string string_0, string string_1, string string_2);
}
