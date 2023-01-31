using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public abstract class BreathingNPC : AbstractNPC
{ // _xZgbANe7gi6i2DAhBEkKpR1QFLe
	private class SpritePiece
	{
		private readonly BreathingNPC _npc;
		private Color _mask = Color.White;
		private float _alpha;
		private readonly Texture2D _texture;

		public string Name { get; private set; }

		public float Alpha
		{
			set
			{
				if (value < 0f)
				{
					_alpha = 0f;
				}
				else if (value <= 1f)
				{
					_alpha = value;
				}
				else
				{
					_alpha = 1f;
				}
				_mask.A = (byte)(255f * _alpha);
			}
		}

		public SpritePiece(BreathingNPC npc, string name, Texture2D texture)
		{
			_npc = npc;
			Name = name;
			_texture = texture;
			Alpha = 0f;
		}

		public void Draw(SpriteBatch spriteBatch, float scale, bool hovered)
		{
			if (_mask.A != 0)
			{
				_mask.G = (byte)((!hovered) ? byte.MaxValue : 0);
				_mask.B = (byte)((!hovered) ? byte.MaxValue : 0);
				spriteBatch.Draw(_texture, _npc._location, (Rectangle?)null, _mask, 0f, Vector2.Zero, scale, (SpriteEffects)(_npc.FlipX ? 1 : 0), 0f);
			}
		}
	}

	private readonly string _sprite;
	private List<SpritePiece> _pieces;
	private Vector2 _location = Vector2.Zero;

	public bool Breathing = true;

	protected readonly float BreathingOffset = Utils.RandomFloat(0f, (float)Math.PI * 2f);
	protected float BreathingSpeed = 1f;

	private readonly Effect _effect;

	public override float X
	{
		get
		{
			return _location.X;
		}
		set
		{
			_location.X = value;
		}
	}

	public override float Y
	{
		get
		{
			return _location.Y;
		}
		set
		{
			_location.Y = value;
		}
	}

	protected BreathingNPC(IAmorous game, string sprite, float scale = 1f)
		: base(game)
	{
		_sprite = sprite;
		_pieces = new List<SpritePiece>();
		base.Scale = scale;
		_effect = base.Game.Content.Load<Effect>("Assets/Shaders/Breathing");
	}

	public override void Start()
	{
		foreach (FilterablePose pose in base.Poses)
		{
			pose.Parts.ForEach(delegate(string part)
			{
				LoadAsset(base.Game.Content, part);
			});
			pose.Nudes.ForEach(delegate(string nude)
			{
				LoadAsset(base.Game.Content, nude);
			});
			foreach (FilterableClothes cloth in pose.Clothes)
			{
				cloth.Parts.ForEach(delegate(string cloth)
				{
					LoadAsset(base.Game.Content, cloth);
				});
			}
		}
		foreach (FilterableEmotion emotion in base.Emotions)
		{
			emotion.Parts.ForEach(delegate(string part)
			{
				LoadAsset(base.Game.Content, part);
			});
			if (!string.IsNullOrEmpty(emotion.Blink))
			{
				LoadAsset(base.Game.Content, emotion.Blink);
			}
		}
		string[] pending = GetPieces();
		if (pending == null)
		{
			return;
		}
		List<SpritePiece> pieces = new List<SpritePiece>();
		foreach (string name in pending)
		{
			SpritePiece piece = _pieces.FirstOrDefault((SpritePiece piece) => piece.Name == name);
			if (piece != null)
			{
				pieces.Add(piece);
				_pieces.Remove(piece);
			}
		}
		pieces.AddRange(_pieces);
		_pieces = pieces;
	}

	protected virtual string[] GetPieces()
	{
		return null;
	}

	private void LoadAsset(ContentManager content, string name)
	{
		Texture2D texture = content.Load<Texture2D>(Path.Combine(_sprite, name));
		_pieces.Add(new SpritePiece(this, name, texture));
	}

	public virtual void Draw(SpriteBatch spriteBatch)
	{
		base.Draw();
		if (Breathing)
		{
			_effect.Parameters["Time"].SetValue(Utils.Date);
			_effect.Parameters["BreathingOffset"].SetValue(BreathingOffset);
			_effect.Parameters["BreathingSpeed"].SetValue(BreathingSpeed);
			_effect.CurrentTechnique.Passes[0].Apply();
		}
		DrawPieces(spriteBatch);
	}

	protected void DrawPieces(SpriteBatch spriteBatch)
	{
		using List<SpritePiece>.Enumerator enumerator = _pieces.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Draw(spriteBatch, base.Scale, IsHovered);
		}
	}

	protected override void SetAlpha(string name, float alpha)
	{
		SpritePiece piece = _pieces.FirstOrDefault((SpritePiece piece) => piece.Name == name);
		if (piece != null)
		{
			piece.Alpha = alpha;
		}
	}

	protected override bool Refresh(int stage) => true;
	protected override void Fade(float percent) {}
	protected override void Dispose() {}
}
