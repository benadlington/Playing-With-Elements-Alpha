using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace Playing_With_Fire___Alpha_0._1.Screens
{
    class Splash : GameScreen
    {
        Texture2D SplashImage;
        public override void Initialise()
        {
            base.Initialise();
        }
        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            SplashImage = Content.Load<Texture2D>("Splash.jpg");
            base.LoadContent(Content);
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();
            if(keyState.IsKeyDown(Keys.Enter))
            {
                ScreenManager.AddScreen(new Menu());
            }
            base.Update(gameTime);
        }
        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(SplashImage, new Rectangle(0, 0, 800, 608), Color.White);
            base.Draw(spriteBatch);
        }
    }
}
