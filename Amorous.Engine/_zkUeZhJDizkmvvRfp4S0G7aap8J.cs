using System;
using System.Collections.Generic;
using System.Reflection;
using Amorous.Engine.NPC;
using Newtonsoft.Json;

public class _zkUeZhJDizkmvvRfp4S0G7aap8J
{
	public class _CIFXVF6lKl3nSrVOhqjcFXDVlXc
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
	public _TwlwMC1hhdSzamwGWEBxuUkz1gH._qokIrmaaT3Lq6znW10HdrPUO9Fq SexscenePhase { get; set; }

	[JsonProperty("SexsceneFinished")]
	public bool SexsceneFinished { get; set; }

	[JsonProperty("FadedOut")]
	public bool FadedOut { get; set; }

	[JsonProperty("NPCs")]
	public List<_CIFXVF6lKl3nSrVOhqjcFXDVlXc> NPCs { get; }

	public _zkUeZhJDizkmvvRfp4S0G7aap8J()
	{
		_SZxz649StJJuwIKZu1G5dtyjwAB = new List<_CIFXVF6lKl3nSrVOhqjcFXDVlXc>();
	}

	public void _gWHVDvr9GDtRXP2zf2Md18MgZ4b(_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve_0)
	{
		if (_3IHp43rpkJgOBcY9lrIrwMuwWve_0 != null)
		{
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT NPC = _3IHp43rpkJgOBcY9lrIrwMuwWve_0.NPC;
			NPCs.Add(new _CIFXVF6lKl3nSrVOhqjcFXDVlXc
			{
				Name = NPC.GetType().Name,
				Location = NPC._9m9LEAgaqaeXydYhykSBmf9BrDG,
				Head = NPC._mdS7Bu4eiPPwoFWUcGEOTzh73TJ,
				Pose = NPC._vzNADWxcLucI3DyP1CebcfYXRut,
				Clothes = NPC._QeyVQAHb3TegEFsv9IPdYmxNkGZ,
				Layer = _3IHp43rpkJgOBcY9lrIrwMuwWve_0.Layer,
				LayerOrder = _3IHp43rpkJgOBcY9lrIrwMuwWve_0.LayerOrder
			});
		}
	}
}
