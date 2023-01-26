using System;
using System.Collections.Generic;
using System.Reflection;
using Amorous.Engine.NPC;
using Newtonsoft.Json;

public class CutsceneState
{
	public class NPCState
	{
		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("Location")]
		public NPCLocation Location { get; set; }

		[JsonProperty("Head")]
		public string Head { get; set; }

		[JsonProperty("Pose")]
		public string Pose { get; set; }

		[JsonProperty("Clothes")]
		public string[] Clothes { get; set; }

		[JsonProperty("Layer")]
		public LayerOrder Layer { get; set; }

		[JsonProperty("LayerOrder")]
		public int LayerOrder { get; set; }
	}

	[JsonProperty("Name")]
	public string Name { get; set; }

	[JsonProperty("Stage")]
	public int Stage { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Scene")]
	public string Scene { get; set; }

	[JsonProperty("Subscene")]
	public string Subscene { get; set; }

	[JsonProperty("Sexscene")]
	public string Sexscene { get; set; }

	[JsonProperty("SexscenePhase")]
	public AbstractSexscene.Phase SexscenePhase { get; set; }

	[JsonProperty("SexsceneFinished")]
	public bool SexsceneFinished { get; set; }

	[JsonProperty("FadedOut")]
	public bool FadedOut { get; set; }

	[JsonProperty("NPCs")]
	public List<NPCState> NPCs { get; }

	public CutsceneState()
	{
		NPCs = new List<NPCState>();
	}

	public void SaveNPCLayer(NPCLayer layer)
	{
		if (layer != null)
		{
			AbstractNPC NPC = layer.NPC;
			NPCs.Add(new NPCState
			{
				Name = NPC.GetType().Name,
				Location = NPC.Location,
				Head = NPC.Head,
				Pose = NPC.Pose,
				Clothes = NPC.Clothes,
				Layer = layer.Layer,
				LayerOrder = layer.LayerOrder
			});
		}
	}
}
