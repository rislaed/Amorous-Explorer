using System;
using Microsoft.Xna.Framework;

public class MouseObserver
{ // _wRd4nHuQQlAPEwrHOGkBfut6Uip
	private readonly IAmorous _game;
	private bool _EKoVuulhFH2bvqZKateoyZN7Ink;
	private bool _qazbvc9K4STcPjV9jPSO0qIDsOJA;
	private int _qbtBeaxeUPacOsYC34SPAzHQWlQ;
	private int _VwbWeBrExX6TY1gcFDVqcZBIo8q;
	private int _EcGPmFZBU8SYAqxnKYb0kf1OmsG;
	private int _8n0XEYNk1IjynzDc1pnLpA1QLed;

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
	public float _HgifDflhwFkpuIZBUcLDU6siHsG { get; set; }
	public float _Pxvux7dVnNcKQc1YbJ5ItGoHgfB { get; set; }
	public bool Captured { get; set; }

	public Matrix _oLRK3f26Sw9AKBKi0iR44APDZEt => Matrix.CreateTranslation(0f - _HgifDflhwFkpuIZBUcLDU6siHsG, 0f - _Pxvux7dVnNcKQc1YbJ5ItGoHgfB, 0f);
	public Matrix _00mMjYnrMXUVj1aA8AYlqz1bdTI => Matrix.CreateTranslation(0f - ((float)(_VwbWeBrExX6TY1gcFDVqcZBIo8q + 1920) + (_HgifDflhwFkpuIZBUcLDU6siHsG - (float)_qbtBeaxeUPacOsYC34SPAzHQWlQ)), 0f - _Pxvux7dVnNcKQc1YbJ5ItGoHgfB, 0f);
	public Matrix _MPYpHIXdfUjJipVgAvBCGASJZiZ => Matrix.CreateTranslation(0f - ((float)(_qbtBeaxeUPacOsYC34SPAzHQWlQ - 1920) + (_HgifDflhwFkpuIZBUcLDU6siHsG - (float)_VwbWeBrExX6TY1gcFDVqcZBIo8q)), 0f - _Pxvux7dVnNcKQc1YbJ5ItGoHgfB, 0f);

	public bool _q1DGEI79OguKnK8dCIgPvfGc9Bi
	{
		get
		{
			if (_qazbvc9K4STcPjV9jPSO0qIDsOJA)
			{
				return _HgifDflhwFkpuIZBUcLDU6siHsG < (float)_qbtBeaxeUPacOsYC34SPAzHQWlQ;
			}
			return false;
		}
	}

	public bool _c3CMfxjIJAFFcSeEIluZOLANXnE
	{
		get
		{
			if (_qazbvc9K4STcPjV9jPSO0qIDsOJA)
			{
				return _HgifDflhwFkpuIZBUcLDU6siHsG > (float)_VwbWeBrExX6TY1gcFDVqcZBIo8q;
			}
			return false;
		}
	}

	public MouseObserver(IAmorous game, int width, int height)
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

	public Point Rescale(Point point)
	{
		point.X = (int)((float)(point.X - RelativeX) / Scale);
		point.Y = (int)((float)(point.Y - RelativeY) / Scale);
		return point;
	}

	public Point _2j5HjqIBNOwD2br7yBprKdzVhAK(Point point)
	{
		point.X = (int)((float)point.X / Scale);
		point.Y = (int)((float)point.Y / Scale);
		return point;
	}

	public Point _e6KgAy4CTN1JFYwA88grvAEmDxX(Point point)
	{
		point = Rescale(point);
		point.X = (int)(_HgifDflhwFkpuIZBUcLDU6siHsG + (float)point.X);
		if (point.X > _VwbWeBrExX6TY1gcFDVqcZBIo8q + 1920)
		{
			point.X = _qbtBeaxeUPacOsYC34SPAzHQWlQ + (point.X - (_VwbWeBrExX6TY1gcFDVqcZBIo8q + 1920));
		}
		point.Y = (int)(_Pxvux7dVnNcKQc1YbJ5ItGoHgfB + (float)point.Y);
		if (point.Y > _8n0XEYNk1IjynzDc1pnLpA1QLed + 1080)
		{
			point.X = _EcGPmFZBU8SYAqxnKYb0kf1OmsG + (point.Y - (_8n0XEYNk1IjynzDc1pnLpA1QLed + 1080));
		}
		return point;
	}

	public void Rescale(float x, float y, out float dx, out float dy)
	{
		dx = (x - (float)RelativeX) / Scale;
		dy = (y - (float)RelativeY) / Scale;
	}

	public void _wFfc7xL7eKxed7i9gWtao7pgsnm(int int_0, int int_1, int int_2, int int_3)
	{
		_qbtBeaxeUPacOsYC34SPAzHQWlQ = int_0;
		_VwbWeBrExX6TY1gcFDVqcZBIo8q = int_1;
		_EcGPmFZBU8SYAqxnKYb0kf1OmsG = int_2;
		_8n0XEYNk1IjynzDc1pnLpA1QLed = int_3;
		_EKoVuulhFH2bvqZKateoyZN7Ink = true;
		_qazbvc9K4STcPjV9jPSO0qIDsOJA = false;
	}

	public void _EPA0ilTeyu3r3U3sXajd13XXT1B(int int_0, int int_1)
	{
		_qbtBeaxeUPacOsYC34SPAzHQWlQ = int_0;
		_VwbWeBrExX6TY1gcFDVqcZBIo8q = int_1;
		_EKoVuulhFH2bvqZKateoyZN7Ink = false;
		_qazbvc9K4STcPjV9jPSO0qIDsOJA = true;
	}

	public void _n4NdRK3l14j7hHgGSJS4dI9LeYR()
	{
		_EKoVuulhFH2bvqZKateoyZN7Ink = false;
		_qazbvc9K4STcPjV9jPSO0qIDsOJA = false;
		_HgifDflhwFkpuIZBUcLDU6siHsG = 0f;
		_Pxvux7dVnNcKQc1YbJ5ItGoHgfB = 0f;
	}

	public void Update(GameTime gameTime)
	{
		if (Captured || _game.Cutscene != null)
		{
			return;
		}
		Point point = Rescale(_game.Controller.Cursor);
		if (point.X >= 0 && point.Y >= 0 && point.X <= 1920 && point.Y <= 1080)
		{
			if (_EKoVuulhFH2bvqZKateoyZN7Ink)
			{
				_YA8VIEiPdA3mZIXmotOA93bAdR1((float)gameTime.ElapsedGameTime.Milliseconds / 1000f, ref point);
			}
			if (_qazbvc9K4STcPjV9jPSO0qIDsOJA)
			{
				_FRs0cZ9KolFCNcNbMdmUMMCEVQ7((float)gameTime.ElapsedGameTime.Milliseconds / 1000f, ref point);
			}
		}
	}

	private void _YA8VIEiPdA3mZIXmotOA93bAdR1(float float_0, ref Point point)
	{
		if (point.X < 330)
		{
			_HgifDflhwFkpuIZBUcLDU6siHsG = MathHelper.Clamp(_HgifDflhwFkpuIZBUcLDU6siHsG - 1920f * ((330f - (float)point.X) / 330f) * float_0, _qbtBeaxeUPacOsYC34SPAzHQWlQ, _VwbWeBrExX6TY1gcFDVqcZBIo8q);
		}
		else if (point.X > 1590)
		{
			_HgifDflhwFkpuIZBUcLDU6siHsG = MathHelper.Clamp(_HgifDflhwFkpuIZBUcLDU6siHsG + 1920f * (((float)point.X - 1590f) / 330f) * float_0, _qbtBeaxeUPacOsYC34SPAzHQWlQ, _VwbWeBrExX6TY1gcFDVqcZBIo8q);
		}
		if (point.Y < 120)
		{
			_Pxvux7dVnNcKQc1YbJ5ItGoHgfB = MathHelper.Clamp(_Pxvux7dVnNcKQc1YbJ5ItGoHgfB - 1080f * ((120f - (float)point.X) / 120f) * float_0, _EcGPmFZBU8SYAqxnKYb0kf1OmsG, _8n0XEYNk1IjynzDc1pnLpA1QLed);
		}
		else if (point.Y > 960)
		{
			_Pxvux7dVnNcKQc1YbJ5ItGoHgfB = MathHelper.Clamp(_Pxvux7dVnNcKQc1YbJ5ItGoHgfB + 1080f * ((float)(point.X - 960) / 120f) * float_0, _EcGPmFZBU8SYAqxnKYb0kf1OmsG, _8n0XEYNk1IjynzDc1pnLpA1QLed);
		}
	}

	private void _FRs0cZ9KolFCNcNbMdmUMMCEVQ7(float float_0, ref Point point)
	{
		if (point.X < 330)
		{
			if (_HgifDflhwFkpuIZBUcLDU6siHsG < (float)(_qbtBeaxeUPacOsYC34SPAzHQWlQ - 1920))
			{
				_HgifDflhwFkpuIZBUcLDU6siHsG = _VwbWeBrExX6TY1gcFDVqcZBIo8q;
			}
			else
			{
				_HgifDflhwFkpuIZBUcLDU6siHsG -= 1920f * ((330f - (float)point.X) / 330f) * float_0;
			}
		}
		else if (point.X > 1590)
		{
			if (_HgifDflhwFkpuIZBUcLDU6siHsG > (float)(_VwbWeBrExX6TY1gcFDVqcZBIo8q + 1920))
			{
				_HgifDflhwFkpuIZBUcLDU6siHsG = _qbtBeaxeUPacOsYC34SPAzHQWlQ;
			}
			else
			{
				_HgifDflhwFkpuIZBUcLDU6siHsG += 1920f * (((float)point.X - 1590f) / 330f) * float_0;
			}
		}
	}
}
