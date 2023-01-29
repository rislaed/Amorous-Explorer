using Microsoft.Xna.Framework;

public class CanvasObserver
{ // _wRd4nHuQQlAPEwrHOGkBfut6Uip
	private readonly IAmorous _game;
	private bool _overscroll;
	private bool _cyclingOverscroll;
	private int _overscrollX1;
	private int _overscrollX2;
	private int _overscrollY1;
	private int _overscrollY2;

	public int Width { get; private set; }
	public int Height { get; private set; }
	public int CanvasWidth { get; private set; }
	public int CanvasHeight { get; private set; }
	public int DisplayWidth { get; private set; }
	public int DisplayHeight { get; private set; }
	public int RelativeWidth { get; private set; }
	public int RelativeHeight { get; private set; }
	public float Scale { get; private set; }
	public int RelativeX { get; private set; }
	public int RelativeY { get; private set; }
	public Matrix ScaleMatrix { get; private set; }
	public float ScrollX { get; set; }
	public float ScrollY { get; set; }
	public bool Captured { get; set; }

	public Matrix OverscrollNoneMatrix => Matrix.CreateTranslation(-ScrollX, -ScrollY, 0f);
	public Matrix OverscrollRightMatrix => Matrix.CreateTranslation(-((float)(_overscrollX2 + 1920) + (ScrollX - (float)_overscrollX1)), -ScrollY, 0f);
	public Matrix OverscrollLeftMatrix => Matrix.CreateTranslation(-((float)(_overscrollX1 - 1920) + (ScrollX - (float)_overscrollX2)), -ScrollY, 0f);

	public bool OverscrollRight
	{
		get
		{
			if (_cyclingOverscroll)
			{
				return ScrollX < (float)_overscrollX1;
			}
			return false;
		}
	}

	public bool OverscrollLeft
	{
		get
		{
			if (_cyclingOverscroll)
			{
				return ScrollX > (float)_overscrollX2;
			}
			return false;
		}
	}

	public CanvasObserver(IAmorous game, int width, int height)
	{
		_game = game;
		Width = width;
		Height = height;
		SetResolution(width, height, width, height);
	}

	public void SetResolution(int width, int height, int realWidth, int realHeight)
	{
		CanvasWidth = width;
		CanvasHeight = height;
		DisplayWidth = realWidth;
		DisplayHeight = realHeight;
		float aboveX = (float)width / (float)Width;
		float aboveY = (float)height / (float)Height;
		if (aboveX < aboveY)
		{
			Scale = aboveX;
			RelativeWidth = width;
			RelativeHeight = (int)((float)Height * Scale);
		}
		else
		{
			Scale = aboveY;
			RelativeWidth = (int)((float)Width * Scale);
			RelativeHeight = height;
		}
		RelativeX = (int)((float)(realWidth - RelativeWidth) / 2f);
		RelativeY = (int)((float)(realHeight - RelativeHeight) / 2f);
		ScaleMatrix = Matrix.CreateScale(Scale);
	}

	public Point GlobalToContent(Point point)
	{
		point.X = (int)((float)(point.X - RelativeX) / Scale);
		point.Y = (int)((float)(point.Y - RelativeY) / Scale);
		return point;
	}

	public Point RelativeToContent(Point point)
	{
		point.X = (int)((float)point.X / Scale);
		point.Y = (int)((float)point.Y / Scale);
		return point;
	}

	public Point GlobalToTouch(Point point)
	{
		point = GlobalToContent(point);
		point.X = (int)(ScrollX + (float)point.X);
		if (point.X > _overscrollX2 + 1920)
		{
			point.X = _overscrollX1 + (point.X - (_overscrollX2 + 1920));
		}
		point.Y = (int)(ScrollY + (float)point.Y);
		if (point.Y > _overscrollY2 + 1080)
		{
			point.X = _overscrollY1 + (point.Y - (_overscrollY2 + 1080));
		}
		return point;
	}

	public void GlobalToContent(float x, float y, out float dx, out float dy)
	{
		dx = (x - (float)RelativeX) / Scale;
		dy = (y - (float)RelativeY) / Scale;
	}

	public void SetOverscroll(int x1, int x2, int y1, int y2)
	{
		_overscrollX1 = x1;
		_overscrollX2 = x2;
		_overscrollY1 = y1;
		_overscrollY2 = y2;
		_overscroll = true;
		_cyclingOverscroll = false;
	}

	public void SetCyclingOverscroll(int x1, int x2)
	{
		_overscrollX1 = x1;
		_overscrollX2 = x2;
		_overscroll = false;
		_cyclingOverscroll = true;
	}

	public void ResetOverscroll()
	{
		_overscroll = false;
		_cyclingOverscroll = false;
		ScrollX = 0f;
		ScrollY = 0f;
	}

	public void Update(GameTime gameTime)
	{
		if (Captured || _game.Cutscene != null)
		{
			return;
		}
		Point point = GlobalToContent(_game.Controller.Cursor);
		if (point.X >= 0 && point.Y >= 0 && point.X <= 1920 && point.Y <= 1080)
		{
			if (_overscroll)
			{
				UpdateOverscrolling((float)gameTime.ElapsedGameTime.Milliseconds / 1000f, ref point);
			}
			if (_cyclingOverscroll)
			{
				UpdateHorizontalCycling((float)gameTime.ElapsedGameTime.Milliseconds / 1000f, ref point);
			}
		}
	}

	private void UpdateOverscrolling(float ticks, ref Point point)
	{
		if (point.X < 330)
		{
			ScrollX = MathHelper.Clamp(ScrollX - 1920f * ((330f - (float)point.X) / 330f) * ticks, _overscrollX1, _overscrollX2);
		}
		else if (point.X > 1590)
		{
			ScrollX = MathHelper.Clamp(ScrollX + 1920f * (((float)point.X - 1590f) / 330f) * ticks, _overscrollX1, _overscrollX2);
		}
		if (point.Y < 120)
		{
			ScrollY = MathHelper.Clamp(ScrollY - 1080f * ((120f - (float)point.X) / 120f) * ticks, _overscrollY1, _overscrollY2);
		}
		else if (point.Y > 960)
		{
			ScrollY = MathHelper.Clamp(ScrollY + 1080f * ((float)(point.X - 960) / 120f) * ticks, _overscrollY1, _overscrollY2);
		}
	}

	private void UpdateHorizontalCycling(float ticks, ref Point point)
	{
		if (point.X < 330)
		{
			if (ScrollX < (float)(_overscrollX1 - 1920))
			{
				ScrollX = _overscrollX2;
			}
			else
			{
				ScrollX -= 1920f * ((330f - (float)point.X) / 330f) * ticks;
			}
		}
		else if (point.X > 1590)
		{
			if (ScrollX > (float)(_overscrollX2 + 1920))
			{
				ScrollX = _overscrollX1;
			}
			else
			{
				ScrollX += 1920f * (((float)point.X - 1590f) / 330f) * ticks;
			}
		}
	}
}
