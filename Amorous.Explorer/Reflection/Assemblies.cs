using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Amorous.Explorer.Reflection;

public static class Assemblies
{
	private static Assembly[] DomainAssemblies => AppDomain.CurrentDomain.GetAssemblies();
	private static string[] LibraryAssemblies = new string[]
	{
		"Newtonsoft.Json",
		"FNA",
		"Spine",
		"Squid",
		"Facepunch.Steamworks",
		"libEGL",
		"libGLESv2",
		"libjpeg-9",
		"libogg-0",
		"libpng16-16",
		"libtheoradec-1",
		"libtheorafile",
		"libvorbis-0",
		"libvorbisfile",
		"MojoShader",
		"SDL2",
		"SDL2_image",
		"soft_oal",
		"steam_api",
		"steam_api64",
		"zlib1"
	};
	public static IEnumerable<Assembly> LoadedAssemblies => DomainAssemblies.Where(
		(assembly) => !LibraryAssemblies.Contains(assembly.GetName().Name)
	);

	public static IEnumerable<Type> ResolveClassesOfType<T>(this Assembly assembly)
	{
		return from type in assembly.GetTypes()
			where typeof(T).IsAssignableFrom(type)
			select type;
	}

	public static IDictionary<Assembly, IEnumerable<Type>> ResolveClassesOfType<T>()
	{
		Dictionary<Assembly, IEnumerable<Type>> collectedClasses = new Dictionary<Assembly, IEnumerable<Type>>();
		foreach (Assembly assembly in LoadedAssemblies)
		{
			IEnumerable<Type> classes = assembly.ResolveClassesOfType<T>();
			if (classes.Count() > 0)
			{
				collectedClasses[assembly] = classes;
			}
		}
		return collectedClasses;
	}

	public static IEnumerable<string> ResolveSubscenesOfType(Type type)
	{
		if (type == null)
		{
			return new string[0];
		}
		return from field in type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy)
			where field.FieldType == typeof(string) && field.IsLiteral && (field.IsPublic || field.IsFamily)
			select (string)field.GetValue(null);
	}

	public static IDictionary<string, IEnumerable<string>> ResolveSubscenes()
	{
		Dictionary<string, IEnumerable<string>> collectedSubscenes = new Dictionary<string, IEnumerable<string>>();
		foreach (KeyValuePair<Assembly, IEnumerable<Type>> classesOfAssembly in ResolveClassesOfType<AbstractScene>())
		{
			foreach (Type typeOfScene in classesOfAssembly.Value)
			{
				IEnumerable<string> subscenes = ResolveSubscenesOfType(typeOfScene);
				if (subscenes.Count() > 0)
				{
					collectedSubscenes[typeOfScene.Name] = new HashSet<string>(subscenes);
				}
			}
		}
		return collectedSubscenes;
	}

	public static IDictionary<string, object> ResolveMethodParameterDictionary(MethodBase method)
	{
		Dictionary<string, object> parameters = new Dictionary<string, object>();
		foreach (ParameterInfo parameter in method.GetParameters())
		{
			parameters[parameter.Name] = parameter.ParameterType;
		}
		return parameters;
	}
}
