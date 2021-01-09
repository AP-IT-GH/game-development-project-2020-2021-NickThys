﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guardians_of_the_galaxy.Components
{
    class Star : Component
    {
        #region Fields
        private Texture2D _starTexture;
        #endregion

        #region Constructor
        public Star(Texture2D _starTexture)
        {
            this._starTexture = _starTexture;
        }
        #endregion

        #region Properties
        public Vector2 Position { get; set; }
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _starTexture.Width, _starTexture.Height);
            }
        }
        public Texture2D StarTexture
        {
            get { return _starTexture; }
            set { _starTexture = value; }
        }
        #endregion

        #region Methodes
        public override void Draw(GameTime _gameTime, SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(_starTexture, Rectangle, Color.White);
        }

        public override void Update(GameTime _gameTime)
        {
        }
        #endregion
    }
}