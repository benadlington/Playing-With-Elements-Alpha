using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Playing_With_Fire___Alpha_0._1.Textures;

namespace Playing_With_Fire___Alpha_0._1.Upgrades
{
    class Upgrade
    {
        string Description { get; set; }
        int Value { get; set; }
        Texture2D Texture { get; set; }
        Cell Location { get; set; }

        public Upgrade(Cell _location)
        {
            Location = _location;
        }
    }
}
