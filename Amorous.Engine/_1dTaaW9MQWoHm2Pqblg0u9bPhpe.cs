using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class _1dTaaW9MQWoHm2Pqblg0u9bPhpe
{
	public Vector2 _Jh6AK28sBy2bS8ZCoKHP3LX45Uk;

	public Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;

	public Rectangle _2psWLw4AI8EIjQzaXnhGg8M1FnaA;

	public int _7Xn1C5tjYnmIif1iZKV8AWsEEbL
	{
		get
		{
			return (int)_Jh6AK28sBy2bS8ZCoKHP3LX45Uk.X;
		}
		set
		{
			_Jh6AK28sBy2bS8ZCoKHP3LX45Uk.X = value;
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA.X = value;
		}
	}

	public int _bCjZ3VSXGKyhmykd2zCnQBiSpDf
	{
		get
		{
			return (int)_Jh6AK28sBy2bS8ZCoKHP3LX45Uk.Y;
		}
		set
		{
			_Jh6AK28sBy2bS8ZCoKHP3LX45Uk.Y = value;
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Y = value;
		}
	}

	public bool _NUP8Fs8I7oMuI6vfg25DFKFlQqE { get; private set; }

	public bool _Fxy2SlgceW90FloFw6a1AEJODYA { get; set; }

	protected _1dTaaW9MQWoHm2Pqblg0u9bPhpe()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = Color.get_White();
		_Fxy2SlgceW90FloFw6a1AEJODYA = true;
	}

	public abstract void _eJedLbGgSejIX7Xyx6RoIYD1soJA();

	public virtual void _4xz3iE0ff4Zjl6ybnWxczeMPKyB()
	{
		_NUP8Fs8I7oMuI6vfg25DFKFlQqE = true;
	}

	public virtual void _TVKS7kokuGdoU8kMxQQPKABgo4c()
	{
		_NUP8Fs8I7oMuI6vfg25DFKFlQqE = false;
	}

	public abstract void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0);
}
