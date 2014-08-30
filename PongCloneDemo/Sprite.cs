using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace PongCloneDemo
{
	public class Sprite
	{
		private readonly Texture2D texture;
		private readonly Vector2 location;

		public Sprite (Texture2D texture, Vector2 location)
		{
			this.texture = texture;
			this.location = location;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (texture, location, Color.White);
		}
	}
}

