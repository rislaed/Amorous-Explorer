using Microsoft.Xna.Framework;

public class CanvasObserver
{ // _wRd4nHuQQlAPEwrHOGkBfut6Uip
	private readonly IAmorous game;
	private bool overscrolling;
	private bool horizontalCycledOverscrolling;
	private int overscrollLeft;
	private int overscrollRight;
	private int overscrollTop;
	private int overscrollBottom;

	public int AbsoluteWidth { get; private set; }
	public int AbsoluteHeight { get; private set; }
	public int ModeWidth { get; private set; }
	public int ModeHeight { get; private set; }
	public int WindowWidth { get; private set; }
	public int WindowHeight { get; private set; }
	public int Width { get; private set; }
	public int Height { get; private set; }
	public float Scale { get; private set; }
	public int OffsetX { get; private set; }
	public int OffsetY { get; private set; }
	public Matrix ScaleMatrix { get; private set; }
	public float ScrollX { get; set; }
	public float ScrollY { get; set; }
	public bool Captured { get; set; }

	public Matrix OverscrollNoneMatrix => Matrix.CreateTranslation(-ScrollX, -ScrollY, 0f);
	public Matrix OverscrollRightMatrix => Matrix.CreateTranslation(-((float)(overscrollRight + 1920) + (ScrollX - (float)overscrollLeft)), -ScrollY, 0f);
	public Matrix OverscrollLeftMatrix => Matrix.CreateTranslation(-((float)(overscrollLeft - 1920) + (ScrollX - (float)overscrollRight)), -ScrollY, 0f);

	public bool IsOverscrolledToRight
	{
		get
		{
			if (horizontalCycledOverscrolling)
			{
				return ScrollX < (float)overscrollLeft;
			}
			return false;
		}
	}

	public bool IsOverscrolledToLeft
	{
		get
		{
			if (horizontalCycledOverscrolling)
			{
				return ScrollX > (float)overscrollRight;
			}
			return false;
		}
	}

	public CanvasObserver(IAmorous game, int width, int height)
	{
		this.game = game;
		AbsoluteWidth = width;
		AbsoluteHeight = height;
		ChangeResolution(width, height, width, height);
	}

	public void ChangeResolution(int width, int height, int windowWidth, int windowHeight)
	{
		ModeWidth = width;
		ModeHeight = height;
		WindowWidth = windowWidth;
		WindowHeight = windowHeight;
		float relativeToWidth = (float)width / (float)AbsoluteWidth;
		float relativeToHeight = (float)height / (float)AbsoluteHeight;
		if (relativeToWidth < relativeToHeight)
		{
			Scale = relativeToWidth;
			Width = width;
			Height = (int)((float)AbsoluteHeight * Scale);
		}
		else
		{
			Scale = relativeToHeight;
			Width = (int)((float)AbsoluteWidth * Scale);
			Height = height;
		}
		OffsetX = (int)((float)(windowWidth - Width) / 2f);
		OffsetY = (int)((float)(windowHeight - Height) / 2f);
		ScaleMatrix = Matrix.CreateScale(Scale);
	}

	public Point GlobalToContent(Point point)
	{
		point.X = (int)((float)(point.X - OffsetX) / Scale);
		point.Y = (int)((float)(point.Y - OffsetY) / Scale);
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
		if (point.X > overscrollRight + 1920)
		{
			point.X = overscrollLeft + (point.X - (overscrollRight + 1920));
		}
		point.Y = (int)(ScrollY + (float)point.Y);
		if (point.Y > overscrollBottom + 1080)
		{
			point.Y = overscrollTop + (point.Y - (overscrollBottom + 1080));
		}
		return point;
	}

	public void GlobalToContent(float x, float y, out float dx, out float dy)
	{
		dx = (x - (float)OffsetX) / Scale;
		dy = (y - (float)OffsetY) / Scale;
	}

	public void SetOverscroll(int x1, int x2, int y1, int y2)
	{
		overscrollLeft = x1;
		overscrollRight = x2;
		overscrollTop = y1;
		overscrollBottom = y2;
		overscrolling = true;
		horizontalCycledOverscrolling = false;
	}

	public void SetCyclingOverscroll(int x1, int x2)
	{
		overscrollLeft = x1;
		overscrollRight = x2;
		overscrolling = false;
		horizontalCycledOverscrolling = true;
	}

	public void ResetOverscroll()
	{
		overscrolling = false;
		horizontalCycledOverscrolling = false;
		ScrollX = 0f;
		ScrollY = 0f;
	}

	public void Update(GameTime gameTime)
	{
		if (Captured || game.Cutscene != null)
		{
			return;
		}
		Point point = GlobalToContent(game.Controller.Cursor);
		if (point.X >= 0 && point.Y >= 0 && point.X <= 1920 && point.Y <= 1080)
		{
			if (overscrolling)
			{
				UpdateOverscrolling((float)gameTime.ElapsedGameTime.Milliseconds / 1000f, ref point);
			}
			if (horizontalCycledOverscrolling)
			{
				UpdateHorizontalCycledOverscrolling((float)gameTime.ElapsedGameTime.Milliseconds / 1000f, ref point);
			}
		}
	}

	private void UpdateOverscrolling(float ticks, ref Point point)
	{
		if (point.X < 330)
		{
			ScrollX = MathHelper.Clamp(ScrollX - 1920f * ((330f - (float)point.X) / 330f) * ticks, overscrollLeft, overscrollRight);
		}
		else if (point.X > 1590)
		{
			ScrollX = MathHelper.Clamp(ScrollX + 1920f * (((float)point.X - 1590f) / 330f) * ticks, overscrollLeft, overscrollRight);
		}
		if (point.Y < 120)
		{
			ScrollY = MathHelper.Clamp(ScrollY - 1080f * ((120f - (float)point.Y) / 120f) * ticks, overscrollTop, overscrollBottom);
		}
		else if (point.Y > 960)
		{
			ScrollY = MathHelper.Clamp(ScrollY + 1080f * ((float)(point.Y - 960) / 120f) * ticks, overscrollTop, overscrollBottom);
		}
	}

	private void UpdateHorizontalCycledOverscrolling(float ticks, ref Point point)
	{
		if (point.X < 330)
		{
			if (ScrollX < (float)(overscrollLeft - 1920))
			{
				ScrollX = overscrollRight;
			}
			else
			{
				ScrollX -= 1920f * ((330f - (float)point.X) / 330f) * ticks;
			}
		}
		else if (point.X > 1590)
		{
			if (ScrollX > (float)(overscrollRight + 1920))
			{
				ScrollX = overscrollLeft;
			}
			else
			{
				ScrollX += 1920f * (((float)point.X - 1590f) / 330f) * ticks;
			}
		}
	}
}
