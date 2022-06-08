using UnityEngine;

namespace Models
{
    public class Grid : MonoBehaviour
    {
        public Cell[,] GridCells
        {
            get;
        } = new Cell[3,3];
    }
}
