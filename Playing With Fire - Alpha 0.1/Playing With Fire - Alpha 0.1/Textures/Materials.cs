using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace Playing_With_Fire___Alpha_0._1.Textures
{
    class Materials
    {
        public static Texture2D mouse;
        public static Texture2D player;
        public static Texture2D grid;
        public static Texture2D background;
        public static Texture2D button;
        public static Texture2D button_Highlight;

        //game objects
        public static Texture2D crate;
        public static Texture2D dynamite;
        public static Texture2D explosion;
        public static Texture2D wall;

        //upgrades
        public static Texture2D Range;

        static ContentManager c;
        public static void LoadContent(ContentManager Content)
        {
            Debug.WriteLine("Loading Materials");
            c = new ContentManager(Content.ServiceProvider, "Content");

            mouse = Content.Load<Texture2D>("Cursor.png");
            player = c.Load<Texture2D>("blue.png");
            grid = Content.Load<Texture2D>("grid.png");
            background = Content.Load<Texture2D>("background.jpg");
            button = Content.Load<Texture2D>("grid.png");
            button_Highlight = Content.Load<Texture2D>("blue.png");
            
            //game objects
            crate = Content.Load<Texture2D>("crate.jpg");
            dynamite = Content.Load<Texture2D>("Dynamite2.jpg");
            explosion = Content.Load<Texture2D>("explosion2.jpg");
            wall = Content.Load<Texture2D>("wall.jpg");

            //upgrades
            Range = Content.Load<Texture2D>("RangeUpgrade.png");
        }
        public static void UnloadContent()
        {
            Debug.WriteLine("Unloading Materials");
            c.Unload();
        }
        
    }
}
