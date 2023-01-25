using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	public Vector2 _Jh6AK28sBy2bS8ZCoKHP3LX45Uk;

	public Color Color;

	public int _ac2H6kMdrgPhXXxabsikjji4SiT;

	public int LayerOrder;

	public float _fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1f;

	protected AbstractScene Scene { get; private set; }

	public string Name { get; private set; }

	public bool _3ZeCDXqcWHY4XJDBGyav3UzxYaHA { get; set; }

	public bool _Fxy2SlgceW90FloFw6a1AEJODYA { get; set; }

	public bool _C6GAq9XPMC9PQPnaaRqYWpv4V6S { get; set; }

	public float X
	{
		get
		{
			return _Jh6AK28sBy2bS8ZCoKHP3LX45Uk.X;
		}
		set
		{
			_Jh6AK28sBy2bS8ZCoKHP3LX45Uk.X = value;
		}
	}

	public float Y
	{
		get
		{
			return _Jh6AK28sBy2bS8ZCoKHP3LX45Uk.Y;
		}
		set
		{
			_Jh6AK28sBy2bS8ZCoKHP3LX45Uk.Y = value;
		}
	}

	public int Width { get; protected set; }

	public int Height { get; protected set; }

	protected _ujAkjlfN5TywwbLAUDzPvtab6uJ(AbstractScene AbstractScene_0, string string_0)
	{
		Scene = AbstractScene_0;
		Name = string_0;
		_3ZeCDXqcWHY4XJDBGyav3UzxYaHA = true;
		_Fxy2SlgceW90FloFw6a1AEJODYA = true;
		Color = Color.White;
		_ac2H6kMdrgPhXXxabsikjji4SiT = 0;
	}

	public abstract void Update(GameTime gameTime_0);

	public abstract void Draw(SpriteBatch spriteBatch_0);

	public virtual bool _Hym13mjJB64DQkbAkEMmEae8pQdA()
	{
		return false;
	}

	public virtual void _dGJ5R083rg1lKbVYP4W1TUEBqoh()
	{
	}

	public virtual void _i3qb0SiBqvdxqp5NXIRGrNGErxh()
	{
	}

	public virtual void _oc2Bt2sYu2e2W8gFbd4cz1hv2Fq()
	{
	}

	public virtual void _ymyneWF6dfrtfUI08wyb3KExq0D()
	{
	}
}
