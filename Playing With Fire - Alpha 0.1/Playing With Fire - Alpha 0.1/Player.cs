using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Playing_With_Fire___Alpha_0._1.Textures;

namespace Playing_With_Fire___Alpha_0._1
{
    class Player : GameObject
    {
        public Stats Stats { get; set; }
        //public Texture2D Texture { get; set; }
        public int Speed { get; set; }
        //public Cell Location { get; set; }

        public Player()
        {
            Stats = new Stats();
            Cell = new Cell();
            Texture = Materials.player;
            Stats.Range = 3;
            Stats.Health = 10;
            Stats.Speed = 5;
        }
    }
}
