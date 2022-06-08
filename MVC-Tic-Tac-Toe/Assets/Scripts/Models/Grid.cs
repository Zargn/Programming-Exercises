using System;

namespace Models
{
    public class Grid
    {
        public event Action<Cell, int, int> CellAdded;
        
        public Cell[,] GridCells
        {
            get;
        }

        public void CreateCell(int x, int y)
        {
            GridCells[x, y] = new Cell();
            CellAdded?.Invoke(GridCells[x, y], x, y);
        }

        public Grid(int width, int height)
        {
            GridCells = new Cell[width, height];
        }
    }
}
