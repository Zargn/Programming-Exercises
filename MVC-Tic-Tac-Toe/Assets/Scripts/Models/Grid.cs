using System;

namespace Models
{
    public class Grid
    {
        private const int gridSize = 3;
        
        public event Action<Cell> CellAdded;
        
        public Cell[,] GridCells
        {
            get;
        } = new Cell[3,3];

        public void Start()
        {
            for (int y = 0; y < gridSize; y++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    GridCells[x, y] = new Cell();
                    CellAdded.Invoke(GridCells[x, y]);
                }
            }
        }
    }
}
