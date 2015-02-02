using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Playing_With_Fire___Alpha_0._1
{
    class Cell
    {
        public Point Position { get; set; }
        public int ID { get; set; }
        public Texture2D Texture { get; set; }
        public Rectangle rLocation { get; set; }
        public String Contains { get; set; }


        //constructors
        public Cell()
        {
            Position = new Point(0, 0);
        }
        public Cell(Point _position, Rectangle _rectangle)
        {
            Position = _position;
            rLocation = _rectangle;
            //Texture = Materials.grid;
        }
        public Cell(Point _position, Rectangle _rectangle, Texture2D _texture)
        {
            Position = _position;
            rLocation = new Rectangle(_rectangle.X * 32, _rectangle.Y * 32, 32, 32);
            Texture = _texture;
        }

        //methods
    }
}