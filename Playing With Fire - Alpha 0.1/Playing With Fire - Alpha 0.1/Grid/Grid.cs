using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Playing_With_Fire___Alpha_0._1
{
    class Grid
    {
        public Cell[,] floorGrid = new Cell[25, 19];
        public void InitialiseGrid()
        {
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 19; y++)
                {
                    floorGrid[x, y] = new Cell(new Point(x, y), getRectangle(x, y));
                }
            }
        }
        private Rectangle getRectangle(int x, int y)
        {
            return new Rectangle(x * 32, y * 32, 32, 32);
        }
        public Dictionary<String,Cell> AdjacentCells(Cell cell)
        {
            Dictionary<String, Cell> cellDic = new Dictionary<string, Cell>();
            //cellDic.Add("Up Left", getCell(new Point(cell.Position.X - 1, cell.Position.Y - 1)));
            if (getCell(new Point(cell.Position.X, cell.Position.Y - 1)) != null)
            {
                cellDic.Add("Up", getCell(new Point(cell.Position.X, cell.Position.Y - 1)));
            }
            //cellDic.Add("Up Right", getCell(new Point(cell.Position.X + 1, cell.Position.Y - 1)));
            if (getCell(new Point(cell.Position.X - 1, cell.Position.Y))!= null)
            {
                cellDic.Add("Left", getCell(new Point(cell.Position.X - 1, cell.Position.Y)));
            }
            if (getCell(new Point(cell.Position.X + 1, cell.Position.Y))!= null)
            {
                cellDic.Add("Right", getCell(new Point(cell.Position.X + 1, cell.Position.Y)));
            }
            //cellDic.Add("Down Left", getCell(new Point(cell.Position.X - 1, cell.Position.Y + 1)));
            if (getCell(new Point(cell.Position.X, cell.Position.Y + 1)) != null)
            {
                cellDic.Add("Down", getCell(new Point(cell.Position.X, cell.Position.Y + 1)));
            }
            //cellDic.Add("Down Right", getCell(new Point(cell.Position.X + 1, cell.Position.Y + 1)));
            return cellDic;
        }
        public List<Cell> AdjacentCellsList(Cell cell, int range)
        {
            List<Cell> cellList = new List<Cell>();
            //up left
            //cellList.Add(getCell(new Point(cell.Position.X - range, cell.Position.Y - range)));
            //up
            for (int i = 1; i <= range; i++)
            {
                //up
                cellList.Add(getCell(new Point(cell.Position.X, cell.Position.Y - i)));
                //down
                cellList.Add(getCell(new Point(cell.Position.X, cell.Position.Y + i)));
                //left
                cellList.Add(getCell(new Point(cell.Position.X - i, cell.Position.Y)));
                //right
                cellList.Add(getCell(new Point(cell.Position.X + i, cell.Position.Y)));

            }
            ////cellList.Add(getCell(new Point(cell.Position.X, cell.Position.Y - range)));
            //up right
            //cellList.Add(getCell(new Point(cell.Position.X + range, cell.Position.Y - range)));
            //down left
            //cellList.Add(getCell(new Point(cell.Position.X - range, cell.Position.Y + range)));
            //down right
            //cellList.Add(getCell(new Point(cell.Position.X + range, cell.Position.Y + range)));
            return cellList;
        }
        public Cell getCell(Point location)
        {
            Cell cell = null;
            if (location.X >= 0 && location.X < 25)
            {
                if(location.Y >= 0 && location.Y < 19)
                {
                    cell = floorGrid[location.X, location.Y];
                }
            }
            return cell;
        }
    }
}
