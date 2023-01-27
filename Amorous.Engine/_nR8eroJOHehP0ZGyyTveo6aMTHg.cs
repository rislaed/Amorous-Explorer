using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

public class _nR8eroJOHehP0ZGyyTveo6aMTHg
{
	public class _2MhByyFij8YJN7lWVuu8gpYhGCy
	{
		private IEvent _3ITTZcgkF3r3Sr09GXF6V8n6iDH;
		private readonly List<int> _Eb7oabg29v057DnasBnAMWRlzGB = new List<int>();

		public _nR8eroJOHehP0ZGyyTveo6aMTHg _5zNdOw7qHmuCAPJFMr3SsZdBlCr { get; private set; }
		public CutsceneStage Data { get; private set; }
		public EventData State { get; private set; }

		public _2MhByyFij8YJN7lWVuu8gpYhGCy(_nR8eroJOHehP0ZGyyTveo6aMTHg _nR8eroJOHehP0ZGyyTveo6aMTHg_0, CutsceneStage _FMuxd8PX5exXCoRNDVuFFbnirof_0)
		{
			_5zNdOw7qHmuCAPJFMr3SsZdBlCr = _nR8eroJOHehP0ZGyyTveo6aMTHg_0;
			Data = _FMuxd8PX5exXCoRNDVuFFbnirof_0;
			State = null;
			_3ITTZcgkF3r3Sr09GXF6V8n6iDH = null;
		}

		public void StopCutscene(int? nullable_0 = null)
		{
			int _Enec98mrCn8lf4R9d5oYrOaqFsd = nullable_0 ?? Data.StartID;
			State = Data.Events.FirstOrDefault((EventData EventData_0) => EventData_0.ID == _Enec98mrCn8lf4R9d5oYrOaqFsd);
			if (State != null)
			{
			}
		}

		public bool Update(GameTime gameTime)
		{
			if (State != null && _3ITTZcgkF3r3Sr09GXF6V8n6iDH != null)
			{
				_3ITTZcgkF3r3Sr09GXF6V8n6iDH.Update(gameTime);
				if (_3ITTZcgkF3r3Sr09GXF6V8n6iDH._xJZUPxDatEzfPQc0nRHR2D1Vwke)
				{
					int _4yqSx4qQVhHNfyjCxxZbsvtLpfN = _3ITTZcgkF3r3Sr09GXF6V8n6iDH.NextID;
					EventData EventData2 = Data.Events.FirstOrDefault((EventData EventData_0) => EventData_0.ID == _4yqSx4qQVhHNfyjCxxZbsvtLpfN);
					if (EventData2 != null)
					{
						State = EventData2;
						_24VlcVUP8D0YWeuIN6co1zSjTGc(State);
						return false;
					}
					State = null;
					return true;
				}
				return false;
			}
			return true;
		}

		private void _24VlcVUP8D0YWeuIN6co1zSjTGc(EventData EventData_0)
		{
			_5zNdOw7qHmuCAPJFMr3SsZdBlCr.Click?.Invoke(EventData_0);
			_Eb7oabg29v057DnasBnAMWRlzGB.Add(EventData_0.DebugID);
			_3ITTZcgkF3r3Sr09GXF6V8n6iDH = _5zNdOw7qHmuCAPJFMr3SsZdBlCr._ttj6hdqCCktHS2XOUCus3tfDF7U(EventData_0.GetType());
			if (_3ITTZcgkF3r3Sr09GXF6V8n6iDH != null)
			{
				_3ITTZcgkF3r3Sr09GXF6V8n6iDH.SetData(EventData_0);
				_3ITTZcgkF3r3Sr09GXF6V8n6iDH.StopCutscene();
			}
		}

		public string _IOKHSVtx0w8zZNPe8UqYKwU0gFB(int int_0 = 0)
		{
			IEnumerable<string> enumerable = _Eb7oabg29v057DnasBnAMWRlzGB.Select((int int_0) => $"{(int_0 >> 24) & 0xFF}:{int_0 & 0xFFFFFF}");
			if (int_0 == 0)
			{
				return string.Join(" > ", enumerable);
			}
			enumerable = enumerable.Skip(_Eb7oabg29v057DnasBnAMWRlzGB.Count - int_0 - 1).Take(int_0);
			return string.Join(" > ", enumerable);
		}

		public string _g81KxY9Byh1XXf9fABWHnONlji2()
		{
			return _Eb7oabg29v057DnasBnAMWRlzGB.Select((int int_0) => $"{(int_0 >> 24) & 0xFF}:{int_0 & 0xFFFFFF}").LastOrDefault();
		}
	}

	private _2MhByyFij8YJN7lWVuu8gpYhGCy Value;
	private _2MhByyFij8YJN7lWVuu8gpYhGCy _9Tci5Q4F5EN9GxZmUEbb3GCaesr;
	private readonly Dictionary<Type, IEvent> _92OAmtDtjVuY31kQhwNYVqhfbiL;

	public Action<EventData> Click { get; set; }
	public IAmorous Game { get; private set; }
	public Cutscene Data { get; private set; }
	public _2MhByyFij8YJN7lWVuu8gpYhGCy _VQZivNSvg2tVi52cTTAQKYhamQK => Value;
	public bool _5PWaXifOOaIVN34JQsXRmvxXtqK => Value != null;

	public _nR8eroJOHehP0ZGyyTveo6aMTHg(IAmorous amorous, Cutscene _0SvCRe0EgzR9DhI3QPe1GUqubAt_0, params Assembly[] assembly_0)
	{
		Game = amorous;
		Data = _0SvCRe0EgzR9DhI3QPe1GUqubAt_0;
		Value = null;
		_92OAmtDtjVuY31kQhwNYVqhfbiL = new Dictionary<Type, IEvent>();
		_QUda7900xSjAzC2c7VwgFjGaTB4(GetType().Assembly);
		foreach (Assembly assembly_ in assembly_0)
		{
			_QUda7900xSjAzC2c7VwgFjGaTB4(assembly_);
		}
	}

	private void _QUda7900xSjAzC2c7VwgFjGaTB4(Assembly assembly_0)
	{
		IEnumerable<Type> enumerable = from type_0 in assembly_0.GetTypes()
			where typeof(IEvent).IsAssignableFrom(type_0) && !type_0.IsInterface && !type_0.IsAbstract
			select type_0;
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
					_92OAmtDtjVuY31kQhwNYVqhfbiL.Add(key, value);
				}
			}
		}
	}

	private IEvent _ttj6hdqCCktHS2XOUCus3tfDF7U(Type type_0)
	{
		if (!_92OAmtDtjVuY31kQhwNYVqhfbiL.ContainsKey(type_0))
		{
			return null;
		}
		return _92OAmtDtjVuY31kQhwNYVqhfbiL[type_0];
	}

	public void StopCutscene(int int_0, int? nullable_0 = null)
	{
		if (!_5PWaXifOOaIVN34JQsXRmvxXtqK)
		{
			CutsceneStage fMuxd8PX5exXCoRNDVuFFbnirof = Data.Stages.FirstOrDefault((CutsceneStage _FMuxd8PX5exXCoRNDVuFFbnirof_0) => _FMuxd8PX5exXCoRNDVuFFbnirof_0.Stage == int_0);
			if (fMuxd8PX5exXCoRNDVuFFbnirof != null)
			{
				Value = new _2MhByyFij8YJN7lWVuu8gpYhGCy(this, fMuxd8PX5exXCoRNDVuFFbnirof);
				Value.StopCutscene(nullable_0);
			}
			else
			{
				Logger.Warning("Failed to find stage '{0}' in cutscene '{1}'", int_0, Data.Name);
			}
		}
	}

	public void _h0KfaNiikKlJV2KkRPIdVDKVJnC()
	{
		Game._aJh9CibG5YKhkExxgRyVopdfSeJ._NtDfAf24kD2Korbc5hoME725A7d(Data.Name, _VQZivNSvg2tVi52cTTAQKYhamQK.Data.Stage);
		Game.Start();
	}

	public void ResetProgression()
	{
		_9Tci5Q4F5EN9GxZmUEbb3GCaesr = Value;
		Value = null;
	}

	public virtual void Update(GameTime gameTime)
	{
		if (_5PWaXifOOaIVN34JQsXRmvxXtqK && Value.Update(gameTime))
		{
			((IAmorous)this).Start();
		}
	}

	public string[] _YYH5zlVZSFq4tPfc1vfadAxnqhV(int int_0 = 0)
	{
		_2MhByyFij8YJN7lWVuu8gpYhGCy _2MhByyFij8YJN7lWVuu8gpYhGCy = Value ?? _9Tci5Q4F5EN9GxZmUEbb3GCaesr;
		if (_2MhByyFij8YJN7lWVuu8gpYhGCy == null)
		{
			return null;
		}
		return new string[4]
		{
			Data.Name,
			_2MhByyFij8YJN7lWVuu8gpYhGCy.Data.Stage.ToString(),
			_2MhByyFij8YJN7lWVuu8gpYhGCy._IOKHSVtx0w8zZNPe8UqYKwU0gFB(int_0),
			_2MhByyFij8YJN7lWVuu8gpYhGCy._g81KxY9Byh1XXf9fABWHnONlji2()
		};
	}
}
