using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Amorous.Explorer.Reflection;

public class LinkedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary
{
	protected Dictionary<TKey, TValue> InnerDictionary { get; private set; }

	public ICollection<TKey> Keys => InnerDictionary.Keys;
	public ICollection<TValue> Values => InnerDictionary.Values;
	ICollection IDictionary.Keys => (InnerDictionary as IDictionary).Keys;
	ICollection IDictionary.Values => (InnerDictionary as IDictionary).Values;
	public int Count => InnerDictionary.Count;
	public bool IsReadOnly => (InnerDictionary as ICollection<KeyValuePair<TKey, TValue>>).IsReadOnly;
	public bool IsFixedSize => (InnerDictionary as IDictionary).IsFixedSize;
	public object SyncRoot => (InnerDictionary as ICollection).SyncRoot;
	public bool IsSynchronized => (InnerDictionary as ICollection).IsSynchronized;
	public IEqualityComparer<TKey> Comparer => InnerDictionary.Comparer;

	public TKey this[TValue entry]
	{
		get => Enumerable.FirstOrDefault(
			this, (pair) => EqualityComparer<TValue>.Default.Equals(entry, pair.Value)
		).Key ?? default(TKey);
		set
		{
			Remove(this[entry]);
			this[value] = entry;
		}
	}

	public virtual TValue this[TKey key] {
		get
		{
			if (key == null)
			{
				return default(TValue);
			}
			if (TryGetValue(key, out var value))
			{
				return value;
			}
			return default(TValue);
		}
		set
		{
			if (key == null)
			{
				if (value == null)
				{
					return;
				}
				key = NewKeyOf(value);
				if (key == null)
				{
					return;
				}
			}
			if (TryGetValue(key, out var entry))
			{
				if (EqualityComparer<TValue>.Default.Equals(entry, value))
				{
					return;
				}
				Remove(key);
			}
			InnerDictionary[key] = value;
		}
	}

	object IDictionary.this[object key] {
		get
		{
			if (key == null || !(key is TKey subkey))
			{
				return null;
			}
			return this[subkey];
		}
		set
		{
			if (!(value is TValue subvalue))
			{
				return;
			}
			if (key == null || !(key is TKey subkey))
			{
				if (value == null)
				{
					return;
				}
				subkey = NewKeyOf(subvalue);
				if (subkey == null)
				{
					return;
				}
			}
			this[subkey] = subvalue;
		}
	}

	public LinkedDictionary() => InnerDictionary = new Dictionary<TKey, TValue>();
	public LinkedDictionary(int capacity) => InnerDictionary = new Dictionary<TKey, TValue>(capacity);
	public LinkedDictionary(IEqualityComparer<TKey> comparer) => InnerDictionary = new Dictionary<TKey, TValue>(comparer);
	public LinkedDictionary(int capacity, IEqualityComparer<TKey> comparer) => InnerDictionary = new Dictionary<TKey, TValue>(capacity, comparer);
	public LinkedDictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary, null) {}
	public LinkedDictionary(IEnumerable<KeyValuePair<TKey, TValue>> pairs) : this(pairs, null) {}

	public LinkedDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) : this(dictionary?.Count ?? 0, comparer)
	{
		foreach (KeyValuePair<TKey, TValue> item in dictionary)
		{
			this[item.Key] = item.Value;
		}
	}

	public LinkedDictionary(IEnumerable<KeyValuePair<TKey, TValue>> pairs, IEqualityComparer<TKey> comparer) : this(comparer)
	{
		foreach (KeyValuePair<TKey, TValue> item in pairs)
		{
			this[item.Key] = item.Value;
		}
	}

	public virtual TKey NewKeyOf(TValue value)
	{
		return default(TKey);
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		if (key == null)
		{
			value = default(TValue);
			return false;
		}
		return InnerDictionary.TryGetValue(key, out value);
	}

	public void Add(TKey key, TValue value)
	{
		if (key == null)
		{
			key = NewKeyOf(value);
		}
		if (key == null || TryGetValue(key, out var entry))
		{
			return;
		}
		this[key] = value;
	}

	void IDictionary.Add(object key, object value)
	{
		if (key == null && value is TValue subvalue)
		{
			key = (object)NewKeyOf(subvalue);
		}
		if (key == null || (this as IDictionary).Contains(key))
		{
			return;
		}
		(this as IDictionary)[key] = value;
	}

	public void Add(TKey key) => this[key] = default(TValue);
	public void Add(TValue value) => this[default(TKey)] = value;
	public void Add(KeyValuePair<TKey, TValue> item) => Add(item.Key, item.Value);

	public void Clear() => InnerDictionary.Clear();

	public bool Contains(KeyValuePair<TKey, TValue> item) => item.Key != null ? (InnerDictionary as ICollection<KeyValuePair<TKey, TValue>>).Contains(item) : false;
	bool IDictionary.Contains(object key) => key != null ? (InnerDictionary as IDictionary).Contains(key) : false;
	public bool ContainsKey(TKey key) => key != null ? InnerDictionary.ContainsKey(key) : false;
	public bool ContainsValue(TValue value) => InnerDictionary.ContainsValue(value);

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => (InnerDictionary as ICollection<KeyValuePair<TKey, TValue>>).CopyTo(array, arrayIndex);
	void ICollection.CopyTo(Array array, int index) => (InnerDictionary as ICollection).CopyTo(array, index);

	public Dictionary<TKey, TValue>.Enumerator GetEnumerator() => InnerDictionary.GetEnumerator();
	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => (InnerDictionary as IEnumerable<KeyValuePair<TKey, TValue>>).GetEnumerator();
	IDictionaryEnumerator IDictionary.GetEnumerator() => (InnerDictionary as IDictionary).GetEnumerator();
	IEnumerator IEnumerable.GetEnumerator() => (InnerDictionary as IEnumerable).GetEnumerator();

	public bool Remove(TKey key) => key != null ? InnerDictionary.Remove(key) : false;
	public bool Remove(TValue value) => Remove(this[value]);
	public bool Remove(KeyValuePair<TKey, TValue> item) => item.Key != null ? (InnerDictionary as ICollection<KeyValuePair<TKey, TValue>>).Remove(item) : false;

	void IDictionary.Remove(object key)
	{
		if (key != null)
		{
			(InnerDictionary as IDictionary).Remove(key);
		}
	}

	public override int GetHashCode() => InnerDictionary.GetHashCode();
	public override bool Equals(object obj) => base.Equals(obj) || InnerDictionary.Equals(obj);
}
