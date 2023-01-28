using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework;

public class Cutscene
{
	public class Stage
	{
		private IEvent _event;
		private readonly List<int> _steps = new List<int>();

		public Cutscene Cutscene { get; private set; }
		public CutsceneStageData Data { get; private set; }
		public EventData State { get; private set; }

		public Stage(Cutscene cutscene, CutsceneStageData data)
		{
			Cutscene = cutscene;
			Data = data;
			State = null;
			_event = null;
		}

		public void Begin(int? id = null)
		{
			int _id = id ?? Data.StartID;
			State = Data.Events.FirstOrDefault((EventData eventData) => eventData.ID == _id);
			if (State != null)
			{
				// ?
			}
		}

		public bool Update(GameTime gameTime)
		{
			if (State != null && _event != null)
			{
				_event.Update(gameTime);
				if (_event.Completable)
				{
					int nextId = _event.NextID;
					EventData eventData = Data.Events.FirstOrDefault((EventData eventData) => eventData.ID == nextId);
					if (eventData != null)
					{
						State = eventData;
						ApplyData(State);
						return false;
					}
					State = null;
					return true;
				}
				return false;
			}
			return true;
		}

		private void ApplyData(EventData eventData)
		{
			Cutscene.Click?.Invoke(eventData);
			_steps.Add(eventData.DebugID);
			_event = Cutscene.GetNextEvent(eventData.GetType());
			if (_event != null)
			{
				_event.SetData(eventData);
				_event.Begin();
			}
		}

		public string ToString(int steps = 0)
		{
			IEnumerable<string> enumerable = _steps.Select((int step) => $"{(step >> 24) & 0xFF}:{step & 0xFFFFFF}");
			if (steps == 0)
			{
				return string.Join(" > ", enumerable);
			}
			enumerable = enumerable.Skip(_steps.Count - steps - 1).Take(steps);
			return string.Join(" > ", enumerable);
		}

		public string GetActiveStep()
		{
			return _steps.Select((int step) => $"{(step >> 24) & 0xFF}:{step & 0xFFFFFF}").LastOrDefault();
		}
	}

	private Stage _state;
	private Stage _pendingState;
	private readonly Dictionary<Type, IEvent> _eventByType;

	public Action<EventData> Click { get; set; }
	public IAmorous Game { get; private set; }
	public CutsceneData Data { get; private set; }
	public Stage State => _state;
	public bool Active => _state != null || _pendingState != null;

	public Cutscene(IAmorous amorous, CutsceneData cutscene, params Assembly[] resources)
	{
		Game = amorous;
		Data = cutscene;
		_state = null;
		_eventByType = new Dictionary<Type, IEvent>();
		RefreshEvent(GetType().Assembly);
		foreach (Assembly assembly in resources)
		{
			RefreshEvent(assembly);
		}
	}

	private void RefreshEvent(Assembly assembly)
	{
		IEnumerable<Type> enumerable = from type in assembly.GetTypes()
			where typeof(IEvent).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract
			select type;
		foreach (Type item in enumerable)
		{
			Type baseType = item.BaseType;
			if (baseType == null)
			{
				continue;
			}
			Type[] genericArguments = baseType.GetGenericArguments();
			if (genericArguments.Length == 1)
			{
				Type key = genericArguments[0];
				if (Activator.CreateInstance(item, this) is IEvent value)
				{
					_eventByType.Add(key, value);
				}
			}
		}
	}

	private IEvent GetNextEvent(Type _event)
	{
		if (!_eventByType.ContainsKey(_event))
		{
			return null;
		}
		return _eventByType[_event];
	}

	public void Begin(int stage, int? id = null)
	{
		if (!Active)
		{
			CutsceneStageData stageData = Data.Stages.FirstOrDefault((CutsceneStageData data) => data.Stage == stage);
			if (stageData != null)
			{
				_state = new Stage(this, stageData);
				_state.Begin(id);
			}
			else
			{
				Logger.Warning("Failed to find stage '{0}' in cutscene '{1}'", stage, Data.Name);
			}
		}
	}

	public void BeginCutscene()
	{
		Game.Achievements.GainCutsceneStageAchievement(Data.Name, State.Data.Stage);
		Game.Start();
	}

	public void ResetProgression()
	{
		_pendingState = _state;
		_state = null;
	}

	public virtual void Update(GameTime gameTime)
	{
		if (Active && _state.Update(gameTime))
		{
			Game.Start();
		}
	}

	public string[] ToString(int steps = 0)
	{
		Stage stage = _state ?? _pendingState;
		if (stage == null)
		{
			return null;
		}
		return new string[4]
		{
			Data.Name,
			stage.Data.Stage.ToString(),
			stage.ToString(steps),
			stage.GetActiveStep()
		};
	}
}
