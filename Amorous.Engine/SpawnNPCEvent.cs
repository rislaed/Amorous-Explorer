using System;
using Amorous.Engine.Data.Cutscenes;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

public class SpawnNPCEvent : AbstractEvent<SpawnNPCEventData>
{ // _1vmNfnjLnh2B8rqPJN4xqYr1vnC
	private AbstractNPC instance;

	public string NPC { get; private set; }
	public string Location { get; private set; }
	public string Layer { get; private set; }
	public string Voice { get; private set; }
	public string Head { get; private set; }
	public string Pose { get; private set; }
	public string[] Clothes { get; private set; }

	public SpawnNPCEvent(Cutscene cutscene) : base(cutscene) {}

	public override void SetData(SpawnNPCEventData eventData)
	{
		base.SetData(eventData);
		NPC = eventData.NPC;
		Location = eventData.Location;
		Layer = eventData.Layer;
		Voice = eventData.Voice;
		Head = eventData.Head;
		Pose = eventData.Pose;
		Clothes = ((eventData.Clothes == null) ? null : eventData.Clothes.ToArray());
	}

	public override void Start()
	{
		base.Start();
		LayerOrder order = ((!Enum.TryParse<LayerOrder>(Layer, out order)) ? LayerOrder.Background : order);
		instance = base.Cutscene.Game.GetNPCLayerAt(NPC, order);
		if (instance == null)
		{
			return;
		}
		instance.LockedOnScreen = true;
		if (instance.Variations != null)
		{
			Type[] variations = instance.Variations;
			foreach (Type type in variations)
			{
				AbstractNPC npc = base.Cutscene.Game.GetNPCLayer(type.Name);
				if (npc != null && npc.Location != 0)
				{
					if (Location == null)
					{
						Location = npc.Location.ToString();
					}
					if (Head == null)
					{
						Head = npc.Head;
					}
					if (Pose == null)
					{
						Pose = npc.Pose;
					}
					if (Clothes == null)
					{
						Clothes = npc.Clothes;
					}
					npc.Reset();
					break;
				}
			}
		}
		if (!Enum.TryParse<NPCLocation>(Location, out var location))
		{
			location = ((instance.Location == NPCLocation.None) ? NPCLocation.Middle : instance.Location);
			AbstractNPC npc = base.Cutscene.Game.GetNPCLayer(location);
			if (npc != null && npc != instance)
			{
				npc.Reset();
			}
			instance.Apply(location, Head, Pose, Clothes);
		}
		else if (location != 0)
		{
			AbstractNPC npc = base.Cutscene.Game.GetNPCLayer(location);
			if (npc != null && npc != instance)
			{
				npc.Reset();
			}
			instance.Apply(location, Head, Pose, Clothes);
			NPCLayer layer = base.Cutscene.Game.Scene.GetNPCLayer(NPC);
			switch (location)
			{
				case NPCLocation.Left:
				case NPCLocation.Right:
					layer.LayerOrder = 0;
					break;
				case NPCLocation.Middle:
					layer.LayerOrder = 1;
					break;
			}
		}
		else
		{
			instance.Reset();
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.IsCompleted = instance == null || !instance.IsRefreshing;
	}
}
