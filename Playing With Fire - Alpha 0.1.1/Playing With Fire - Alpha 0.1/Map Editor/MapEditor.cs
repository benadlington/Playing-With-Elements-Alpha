using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using Playing_With_Fire___Alpha_0._1.Textures;

namespace Playing_With_Fire___Alpha_0._1.Map_Editor
{
    class MapEditor : GameScreen
    {
        Grid myGrid;
        public override void Initialise()
        {
            myGrid = new Grid();
            myGrid.InitialiseGrid();
            base.Initialise();
        }
        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach(Cell c in myGrid.floorGrid)
            {
                spriteBatch.Draw(Materials.grid, c.rLocation, Color.White);
            }
            base.Draw(spriteBatch);
        }
    }
}
