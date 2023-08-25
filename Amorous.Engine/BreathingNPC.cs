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
		private readonly BreathingNPC npc;
		private Color color = Color.White;
		private float alpha;
		private readonly Texture2D texture;

		public string Name { get; private set; }

		public float Alpha
		{
			set
			{
				if (value < 0f)
				{
					alpha = 0f;
				}
				else if (value <= 1f)
				{
					alpha = value;
				}
				else
				{
					alpha = 1f;
				}
				color.A = (byte)(255f * alpha);
			}
		}

		public SpritePiece(BreathingNPC npc, string name, Texture2D texture)
		{
			this.npc = npc;
			Name = name;
			this.texture = texture;
			Alpha = 0f;
		}

		public void Draw(SpriteBatch spriteBatch, float scale, bool hovered)
		{
			if (color.A != 0)
			{
				color.G = (byte)((!hovered) ? byte.MaxValue : 0);
				color.B = (byte)((!hovered) ? byte.MaxValue : 0);
				spriteBatch.Draw(texture, npc.location, (Rectangle?)null, color, 0f, Vector2.Zero, scale, (SpriteEffects)(npc.FlipX ? 1 : 0), 0f);
			}
		}
	}

	private readonly string path;
	private List<SpritePiece> pieces;
	private Vector2 location = Vector2.Zero;

	public bool Breathing = true;

	protected readonly float BreathingOffset = Utils.RandomFloat(0f, (float)Math.PI * 2f);
	protected float BreathingSpeed = 1f;

	private readonly Effect effect;

	public override float X
	{
		get
		{
			return location.X;
		}
		set
		{
			location.X = value;
		}
	}

	public override float Y
	{
		get
		{
			return location.Y;
		}
		set
		{
			location.Y = value;
		}
	}

	protected BreathingNPC(IAmorous game, string path, float scale = 1f) : base(game)
	{
		this.path = path;
		pieces = new List<SpritePiece>();
		base.Scale = scale;
		effect = base.Game.Content.Load<Effect>("Assets/Shaders/Breathing");
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
		List<SpritePiece> sprites = new List<SpritePiece>();
		foreach (string name in pending)
		{
			SpritePiece piece = pieces.FirstOrDefault((SpritePiece piece) => piece.Name == name);
			if (piece != null)
			{
				sprites.Add(piece);
				pieces.Remove(piece);
			}
		}
		sprites.AddRange(pieces);
		pieces = sprites;
	}

	protected virtual string[] GetPieces()
	{
		return null;
	}

	private void LoadAsset(ContentManager content, string name)
	{
		Texture2D texture = content.Load<Texture2D>(Path.Combine(path, name));
		pieces.Add(new SpritePiece(this, name, texture));
	}

	public virtual void Draw(SpriteBatch spriteBatch)
	{
		base.Draw();
		if (Breathing)
		{
			effect.Parameters["Time"].SetValue(Utils.Date);
			effect.Parameters["BreathingOffset"].SetValue(BreathingOffset);
			effect.Parameters["BreathingSpeed"].SetValue(BreathingSpeed);
			effect.CurrentTechnique.Passes[0].Apply();
		}
		DrawPieces(spriteBatch);
	}

	protected void DrawPieces(SpriteBatch spriteBatch)
	{
		using List<SpritePiece>.Enumerator enumerator = pieces.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Draw(spriteBatch, base.Scale, IsHovered);
		}
	}

	protected override void SetAlpha(string name, float alpha)
	{
		SpritePiece piece = pieces.FirstOrDefault((SpritePiece piece) => piece.Name == name);
		if (piece != null)
		{
			piece.Alpha = alpha;
		}
	}

	protected override bool Refresh(int stage) => true;
	protected override void Fade(float amount) {}
	protected override void Dispose() {}
}
