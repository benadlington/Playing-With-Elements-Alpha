using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using Playing_With_Fire___Alpha_0._1.Map_Editor;
using Playing_With_Fire___Alpha_0._1.Textures;

namespace Playing_With_Fire___Alpha_0._1.Screens
{
    class Menu : GameScreen
    {
        //states
        MouseState mouseState;
        Point mousePosition;


        //butons
        Button buttonSinglePlayer;
        Button buttonMultiPlayer;
        Button buttonOptions;
        Button buttonHighScore;
        Button buttonExit;
        List<Button> buttonList = new List<Button>();

        //map editor


        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {

            //buttons
            buttonSinglePlayer = new Button("Single Player", new Rectangle(300, 100, 200, 60));
            buttonMultiPlayer = new Button("Multi Player", new Rectangle(300, 200, 200, 60));
            buttonOptions = new Button("Options", new Rectangle(300, 300, 200, 60));
            buttonHighScore = new Button("High Score", new Rectangle(300, 400, 200, 60));
            buttonExit = new Button("Exit", new Rectangle(300, 500, 200, 60));

            buttonList.Add(buttonSinglePlayer);
            buttonList.Add(buttonMultiPlayer);
            buttonList.Add(buttonOptions);
            buttonList.Add(buttonHighScore);
            buttonList.Add(buttonExit);
            base.LoadContent(Content);
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();
            mouseState = Mouse.GetState();
            mousePosition = mouseState.Position;

            //checking buttons for mouse click using a switch statement
            foreach (Button b in buttonList)
            {
                if(mouseState.LeftButton == ButtonState.Pressed && b.rLocation.Contains(mousePosition))
                {
                    switch(b.Name)
                    {
                        case "Single Player":
                            {
                                ScreenManager.AddScreen(new Map());
                                break;
                            }
                        case "Multi Player":
                            {
                                break;
                            }
                        case "Options":
                            {
                                ScreenManager.AddScreen(new MapEditor());
                                break;
                            }
                        case "High Score":
                            {

                                break;
                            }
                        case "Exit":
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }

            base.Update(gameTime);
        }
        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            //background first thing to draw so it's at the back
            spriteBatch.Draw(Materials.background, new Rectangle(0, 0, 800, 608), Color.White);
            //drawing buttons
            foreach(Button b in buttonList)
            {
                spriteBatch.Draw(Materials.background, b.rLocation, Color.White);
                //highlighted buttons
                if (b.rLocation.Contains(mousePosition))
                {
                    spriteBatch.Draw(Materials.button_Highlight, b.rLocation, Color.White);
                }
            }


           

            //mouse needs to be at the bottom to ensure it is drawn ontop of everything else
            spriteBatch.Draw(Materials.mouse, new Rectangle(mousePosition.X, mousePosition.Y, 20, 35), Color.White);

            base.Draw(spriteBatch);
        }
    }
}
