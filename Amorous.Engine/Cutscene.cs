using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework;

public class Cutscene
{ // _nR8eroJOHehP0ZGyyTveo6aMTHg
	public class CutsceneStage
	{
		private IEvent @event;
		private readonly List<int> steps = new List<int>();

		public Cutscene Cutscene { get; private set; }
		public CutsceneStageData StageData { get; private set; }
		public EventData EventData { get; private set; }

		public CutsceneStage(Cutscene cutscene, CutsceneStageData data)
		{
			Cutscene = cutscene;
			StageData = data;
			EventData = null;
			@event = null;
		}

		public void Start(int? id = null)
		{
			int startId = id ?? StageData.StartID;
			EventData = StageData.Events.FirstOrDefault((EventData eventData) => eventData.ID == startId);
			if (EventData != null)
			{
				ApplyData(EventData);
			}
		}

		public bool Update(GameTime gameTime)
		{
			if (EventData != null && @event != null)
			{
				@event.Update(gameTime);
				if (@event.IsCompleted)
				{
					int nextId = @event.NextID;
					EventData eventData = StageData.Events.FirstOrDefault((EventData data) => data.ID == nextId);
					if (eventData != null)
					{
						EventData = eventData;
						ApplyData(EventData);
						return false;
					}
					EventData = null;
					return true;
				}
				return false;
			}
			return true;
		}

		private void ApplyData(EventData eventData)
		{
			Cutscene.Progress?.Invoke(eventData);
			steps.Add(eventData.DebugID);
			@event = Cutscene.GetNextEvent(eventData.GetType());
			if (@event != null)
			{
				Logger.Debug("Going to event '{0}' in stage {1} ({2} -> {3})", @event.GetType().Name, eventData.DebugID, eventData.ID, eventData.NextID);
				@event.SetData(eventData);
				@event.Start();
			}
		}

		public string GetSteps(int count = 0)
		{
            IEnumerable<string> enumerable = steps.Select((int step) => $"{(step >> 24) & 0xFF}:{step & 0xFFFFFF}");
			if (count == 0)
			{
				return string.Join(" > ", enumerable);
			}
			enumerable = enumerable.Skip(steps.Count - count - 1).Take(count);
			return string.Join(" > ", enumerable);
		}

		public string GetStep()
		{
			return steps.Select((int step) => $"{(step >> 24) & 0xFF}:{step & 0xFFFFFF}").LastOrDefault();
		}
	}

	private CutsceneStage stage;
	private CutsceneStage inactiveStage;
	private readonly Dictionary<Type, IEvent> eventByType;

	public Action<EventData> Progress { get; set; }
	public IAmorous Game { get; private set; }
	public CutsceneData Data { get; private set; }
	public CutsceneStage Stage => stage;
	public bool IsActive => stage != null;

	public Cutscene(IAmorous amorous, CutsceneData cutscene, params Assembly[] resources)
	{
		Game = amorous;
		Data = cutscene;
		stage = null;
		eventByType = new Dictionary<Type, IEvent>();
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
					eventByType.Add(key, value);
				}
			}
		}
	}

	private IEvent GetNextEvent(Type type)
	{
		if (!eventByType.ContainsKey(type))
		{
			return null;
		}
		return eventByType[type];
	}

	public void Start(int stage, int? id = null)
	{
		if (!IsActive)
		{
			CutsceneStageData stageData = Data.Stages.FirstOrDefault((CutsceneStageData data) => data.Stage == stage);
			if (stageData != null)
			{
				this.stage = new CutsceneStage(this, stageData);
				this.stage.Start(id);
			}
			else
			{
				Logger.Warning("Failed to find stage '{0}' in cutscene '{1}'", stage, Data.Name);
			}
		}
	}

	public void Complete()
	{
		Game.Achievements.TriggerCutsceneStageAchievement(Data.Name, Stage.StageData.Stage);
		Game.Autosave();
	}

	public void ResetState()
	{
		inactiveStage = stage;
		stage = null;
	}

	public virtual void Update(GameTime gameTime)
	{
		if (IsActive && stage.Update(gameTime))
		{
			Complete();
		}
	}

	public string[] ToString(int steps = 0)
	{
		CutsceneStage where = stage ?? inactiveStage;
		if (where == null)
		{
			return null;
		}
		return new string[4]
		{
			Data.Name,
			where.StageData.Stage.ToString(),
			where.GetSteps(steps),
			where.GetStep()
		};
	}
}
