using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Explorer.Specialized;

public static class AmorousSingletonExtensions
{
	public static void StartScene(this AmorousSingleton singleton, Type type)
	{
		typeof(AmorousSingleton).GetMethod("StartScene", Type.EmptyTypes).MakeGenericMethod(type).Invoke(singleton, new object[0]);
	}

	public static void ResetCutscene(this AmorousSingleton singleton)
	{
		typeof(AmorousSingleton).GetMethod("ResetCutscene", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(singleton, new object[0]);
	}

	public static void ResetSexscene(this AmorousSingleton singleton)
	{
		typeof(AmorousSingleton).GetMethod("ResetSexscene", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(singleton, new object[0]);
	}

	public static CutsceneState GetCutsceneState(this AmorousSingleton singleton)
	{
		return (CutsceneState)typeof(AmorousSingleton).GetMethod("GetCutsceneState", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(singleton, new object[0]);
	}

	public static Cutscene ReadCutscene(this AmorousSingleton singleton, string name)
	{
		return (Cutscene)typeof(AmorousSingleton).GetMethod("ReadCutscene", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(singleton, new object[] { name });
	}

	public static RenderTarget2D GetRenderTarget(this AmorousSingleton singleton)
	{
		return (RenderTarget2D)typeof(AmorousSingleton).GetField("renderTarget", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(singleton);
	}

	public static Rectangle GetDestinationRectangle(this AmorousSingleton singleton)
	{
		return (Rectangle)typeof(AmorousSingleton).GetField("destinationRectangle", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(singleton);
	}

	public static void ChangeSexscene(this AmorousSingleton singleton, AbstractSexscene sexscene)
	{
		typeof(AmorousSingleton).GetField("sexscene", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(singleton, sexscene);
	}

	public static void ChangeCutscene(this AmorousSingleton singleton, Cutscene cutscene)
	{
		typeof(AmorousSingleton).GetField("cutscene", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(singleton, cutscene);
	}

	public static void LoadCutscene(this AmorousSingleton singleton, CutsceneState state)
	{
		typeof(AmorousSingleton).GetMethod("LoadCutscene", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(singleton, new object[] { state });
	}

	public static void PlayCutscene(this AmorousSingleton singleton, Cutscene cutscene, int? stage, int? id = null)
	{
		if (cutscene != null)
		{
			if (singleton.Cutscene != null)
			{
				Logger.Debug("Changing to cutscene '{0}' -> '{1}'", singleton.Cutscene.Data.Name, cutscene.Data.Name);
			}
			else
			{
				Logger.Debug("Starting cutscene '{0}'", cutscene.Data.Name);
			}
			singleton.ChangeCutscene(cutscene);
			if (!stage.HasValue)
			{
				stage = PlayerPreferences.GetPlayerData().GetStage(cutscene.Data.Name);
			}
			PhoneOverlay.Hide();
			cutscene.Start(stage.Value, id);
		}
	}
}
