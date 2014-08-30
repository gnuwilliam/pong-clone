#region File Description
//-----------------------------------------------------------------------------
// PongCloneDemoGame.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

#endregion

namespace PongCloneDemo
{
	public class Game1 : Game
	{

		#region Fields

		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		private Paddle paddle;

		#endregion

		#region Initialization

		public Game1 ()
		{
			graphics = new GraphicsDeviceManager (this);
			
			Content.RootDirectory = "Assets";

			graphics.IsFullScreen = false;
		}

		protected override void Initialize ()
		{
			IsMouseVisible = true;
			base.Initialize ();
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch (graphics.GraphicsDevice);
			paddle = new Paddle(Content.Load<Texture2D>("player_paddle"), Vector2.Zero);
		}

		#endregion

		#region Update and Draw

		protected override void Update (GameTime gameTime)
		{
			base.Update (gameTime);
		}

		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.CornflowerBlue);

			spriteBatch.Begin ();
			paddle.Draw (spriteBatch);
			spriteBatch.End ();

			base.Draw (gameTime);
		}

		#endregion
	}
}
