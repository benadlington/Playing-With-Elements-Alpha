using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using Playing_With_Fire___Alpha_0._1.Game_Objects;
using Playing_With_Fire___Alpha_0._1.Textures;
using Playing_With_Fire___Alpha_0._1.Upgrades;

namespace Playing_With_Fire___Alpha_0._1.Screens
{
    class Map : GameScreen
    {
        //Objects
        Player player = new Player();
        Grid myGrid;
        KeyboardState keyState;

        List<Wall> wallList = new List<Wall>();
        List<Crate> crateList = new List<Crate>();
        List<Dynamite> dynamiteList = new List<Dynamite>();

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
            keyState = Keyboard.GetState();

            //Dictionary of adjacent cells
            Dictionary<String, Cell> playerAdjacent = myGrid.AdjacentCells(player.Cell);
            if(keyState.IsKeyDown(Keys.W))
            {
                if (playerAdjacent.ContainsKey("Up"))
                {
                    if (playerAdjacent["Up"].Contains == "Crate" || playerAdjacent["Up"].Contains == "Wall")
                    {

                    }
                    else
                    {
                        player.Cell = playerAdjacent["Up"];
                    }
                }
            }
            if (keyState.IsKeyDown(Keys.S))
            {
                if (playerAdjacent.ContainsKey("Down"))
                {
                    if (playerAdjacent["Down"].Contains == "Crate" || playerAdjacent["Down"].Contains == "Wall")
                    {

                    }
                    else
                    {
                        player.Cell = playerAdjacent["Down"];
                    }
                }
            }
            if (keyState.IsKeyDown(Keys.A))
            {
                if (playerAdjacent.ContainsKey("Left"))
                {
                    if (playerAdjacent["Left"].Contains == "Crate" || playerAdjacent["Left"].Contains == "Wall")
                    {

                    }
                    else
                    {
                        player.Cell = playerAdjacent["Left"];
                    }
                }
            }
            if (keyState.IsKeyDown(Keys.D))
            {
                if(playerAdjacent.ContainsKey("Right"))
                {
                    if (playerAdjacent["Right"].Contains == "Crate" || playerAdjacent["Right"].Contains == "Wall")
                    {

                    }
                    else
                    {
                        player.Cell = playerAdjacent["Right"];
                    }
                }
            }
            if(keyState.IsKeyDown(Keys.F))
            {
                Crate crate = new Crate(player.Cell);
                crateList.Add(crate);
            }
            if(keyState.IsKeyDown(Keys.G))
            {
                Wall wall = new Wall(player.Cell);
                wallList.Add(wall);
            }
            if (keyState.IsKeyDown(Keys.Space))
            {
                if(player.Cell.Contains != "Dynamite")
                {
                    Dynamite dynamite = new Dynamite(player.Cell);
                    dynamiteList.Add(dynamite);
                }
            }

            DynamiteExplosion();
            RemoveUnlitDynamite();
            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Materials.background, new Rectangle(0, 0, 800, 608), Color.White);

            DrawGrid(spriteBatch);
            DrawWalls(spriteBatch);
            DrawCrates(spriteBatch);
            DrawDynamite(spriteBatch);


            #region bad drawing
            //drawing tests, this currently draws all of the explosions
            foreach (Cell c in myGrid.floorGrid)
            {
                if (c.Texture != null)
                {
                    spriteBatch.Draw(c.Texture, c.rLocation, Color.White);
                }
            }
            #endregion


            spriteBatch.Draw(player.Texture, player.Cell.rLocation, Color.White);
            base.Draw(spriteBatch);
        }

        private void DrawGrid(SpriteBatch spriteBatch)
        {
            foreach (Cell c in myGrid.floorGrid)
            {
                spriteBatch.Draw(Materials.grid, c.rLocation, Color.White);
            }
        }
        private void DrawWalls(SpriteBatch spriteBatch)
        {
            //drawing walls
            foreach (Wall wall in wallList)
            {
                spriteBatch.Draw(wall.Texture, wall.Location.rLocation, Color.White);
            }
        }
        private void DrawCrates(SpriteBatch spriteBatch)
        {
            //drawing crates
            foreach (Crate crate in crateList)
            {
                spriteBatch.Draw(crate.Texture, crate.Location.rLocation, Color.White);
            }
        }
        private void DrawDynamite(SpriteBatch spriteBatch)
        {
            //drawing the dynamite list (all the ACTIVE dynamite) unlit ones are removed in the update.
            foreach (Dynamite d in dynamiteList)
            {
                spriteBatch.Draw(d.Texture, d.Location.rLocation, Color.White);
            }
        }
        private void DynamiteExplosion()
        {
            List<Cell> adjacentCells = new List<Cell>();
            for (int i = 0; i < dynamiteList.Count; i++)
            {
                adjacentCells = myGrid.AdjacentCellsList(dynamiteList[i].Location, player.Stats.Range);
                for (int x = 0; x < adjacentCells.Count; x++)
                {
                    if(adjacentCells[x] != null)
                    {
                        if (dynamiteList[i].Fuse == 0)
                        {
                            adjacentCells[x].Texture = Materials.explosion;
                        }
                    }
                }

            }
        }
        private void RemoveUnlitDynamite()
        {
            List<Cell> adjacentCells = new List<Cell>();
            //For loop through the dynamite list, if they aren't ignited (destroyed/exploded), it then checks all the adjacent cells to the explosion (up down left right)
            //to see if they contain any crates, if there are crates they are destroyed and removed from the crate list meaning they are no longer being drawn
            for (int i = 0; i < dynamiteList.Count; i++)
            {
                if (dynamiteList[i].Ignited == false)
                {
                    adjacentCells = myGrid.AdjacentCellsList(dynamiteList[i].Location, player.Stats.Range);
                    for (int x = 0; x < adjacentCells.Count; x++)
                    {
                        if(adjacentCells[x] != null)
                        {
                            //checking if the adjacent cells contain a crate, if so deleting them using linq
                            if (adjacentCells[x].Contains == "Crate")
                            {
                                
                                adjacentCells[x].Contains = "";//sets it to "" so I can move back through the cells as it no long thinks there is a crate there
                                crateList.RemoveAll(y => y.Location.rLocation == adjacentCells[x].rLocation); // linq to remove all of the crates from a list
                                UpgradeManager.GetRandomUpgrade();
                            }
                        }
                        //badly unloading texture, change this
                        if(adjacentCells[x] != null)
                        {
                            adjacentCells[x].Texture = null;
                        }
                    }
                    dynamiteList[i].Location.Contains = "";
                    dynamiteList.Remove(dynamiteList[i]);
                }
            }
        }
    }
}
