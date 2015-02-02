using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using System.Threading;
using Playing_With_Fire___Alpha_0._1.Textures;

namespace Playing_With_Fire___Alpha_0._1.Game_Objects
{
    class Wall
    {
        public Texture2D Texture { get; set; }
        public Cell Location { get; set; }

        public Wall()
        {

        }
        public Wall(Cell cell)
        {
            Texture = Materials.wall;
            Location = cell;
            cell.Contains = "Wall";
        }
    }
}
