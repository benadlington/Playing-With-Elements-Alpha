using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Playing_With_Fire___Alpha_0._1.Screens
{
    class Button
    {
        public String Name { get; set; }
        public Point Location { get; set; }
        public Rectangle rLocation { get; set; }
        public Boolean Highlighted { get; set; }

        public Button()
        {

        }
        public Button(String _name, Rectangle _rlocation)
        {
            Name = _name;
            rLocation = _rlocation;
        }
    }
}
