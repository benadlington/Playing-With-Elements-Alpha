using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Playing_With_Fire___Alpha_0._1.Screens;
using System.Diagnostics;

namespace Playing_With_Fire___Alpha_0._1
{
    public class ScreenManager
    {

        public static ContentManager content;

        public static GameScreen currentScreen { get; set; }
        public static GameScreen newScreen { get; set; }
        public static Vector2 Dimensions { get; set; }

        /// <summary>
        /// Gamescreen satck. (The top gamescreen is the current screen, pushing it off will result in the gamescreen below being drawn)
        /// </summary>
        static Stack<GameScreen> screenStack = new Stack<GameScreen>();

        /// <summary>
        /// pushes a screen onto the stack, this will result in the screen being drawn
        /// </summary>
        /// <param name="screen"></param>
        public static void AddScreen(GameScreen screen)
        {
            newScreen = screen;
            screenStack.Push(screen);
            if(currentScreen != null)
            {
                currentScreen.UnloadContent();
                Debug.WriteLine("Screen Content unloaded");
            }
            currentScreen = newScreen;
            try
            {
                currentScreen.LoadContent(content);
                Debug.WriteLine("Screen Contetnt Loaded");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            currentScreen.Initialise();
        }


        //all of the methods below call the relative methods depending on which screen is the current screen, and that is the only screen that needs draw/update etc.
        public static void Initialise()
        {
            if (currentScreen != null)
            {
                currentScreen.Initialise();
            }
        }
        public static void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent(content);
        }
        public static void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }
        public static void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }

    }
}
